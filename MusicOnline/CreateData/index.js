const { ZingMp3 } = require("zingmp3-api-full");

function crawlPlaylist(IdPlaylist, size, type) {
    const musics = []; // Khai báo biến musics để lưu danh sách bài hát

    return ZingMp3.getDetailPlaylist(IdPlaylist).then((data) => { // Sử dụng IdPlaylist trong getDetailPlaylist
        const promises = [];

        for (let i = 0; i < Math.min(size, data.data.song.items.length); ++i) {
            const encodeId = data.data.song.items[i].encodeId;
            let title = "";
            let artistsNames = "";
            let genre = "";
            let thumbnail = "";
            let preview_mp3 = "";
            let lyrics = [];
            let isAdd = true;


            const promise = ZingMp3.getInfoSong(encodeId)
                .then((item) => {
                    const song = item.data;
                    title = song.title;
                    artistsNames = song.artistsNames;
                    genre = song.genres[1].title;
                    thumbnail = song.thumbnailM;
                })
                .then(() => ZingMp3.getSong(encodeId))
                .then((item) => {
                    if (item.err === 0) preview_mp3 = item.data['128'];
                    else isAdd = false; // Thành viên vip mới nghe được
                })
                .then(() => ZingMp3.getLyric(encodeId))
                .then((data) => {
                    try {
                        data.data.sentences.forEach((element) => {
                            lyrics.push(element.words.map((item) => item.data).join(' '));
                        });

                        lyrics = lyrics.map((item) => item).join('\n');
                    } catch (e) {
                        // Không có lyrics
                        isAdd = false;
                    }
                })
                .then(() => {
                    const music = {
                        title: title,
                        artistsNames: artistsNames,
                        genre: genre,
                        type: type,
                        thumbnail: thumbnail,
                        preview_mp3: preview_mp3,
                        lyrics: lyrics
                    };

                    if (isAdd) musics.push(music);
                });

            promises.push(promise);
        }

        return Promise.all(promises).then(() => musics); // Trả về danh sách bài hát sau khi Promise.all hoàn thành
    })
        .catch((error) => {
            console.error(error);
        });
}

function exportFileJson(array, name) {
    return new Promise((resolve, reject) => {
        const fs = require('fs');
        const json = JSON.stringify(array);

        fs.writeFile(name + '.json', json, 'utf8', (err) => {
            if (err) {
                reject(err);
            } else {
                resolve();
            }
        });
    })
    
}

function createData(IdPlaylist, name, size, type) {
    return new Promise((resolve, reject) => {
        crawlPlaylist(IdPlaylist, size, type).then((musics) => {
            console.log(name + ": " + musics.length)
            exportFileJson(musics, name).then(() => {
                return resolve()
            })
        })
    })
}

function createDataFull(dataCrawl, fileFull) {
    const fs = require('fs');

    const promises = [];

    dataCrawl.forEach((item) => {
        const promise = createData(item.IdPlaylist, item.NameJson, item.Size, item.Type)
        promises.push(promise);
    })

    Promise.all(promises).then(() => {
        let mergedData = []

        dataCrawl.forEach(item => {
            const jsonData = fs.readFileSync("./" + item.NameJson + ".json");
            const data = JSON.parse(jsonData);
            mergedData = mergedData.concat(data);
        });

        fs.writeFileSync(fileFull + ".json", JSON.stringify(mergedData), 'utf8');
    })
}

const dataCrawl = [
    {
        IdPlaylist: 'ZWZB969E',
        NameJson: 'NhacViet',
        Size: 30,
        Type: "Việt Nam"
    },
    {
        IdPlaylist: 'ZWZB96AB',
        NameJson: 'NhacAuMy',
        Size: 100,
        Type: "Âu Mỹ"
    }
]

createDataFull(dataCrawl, 'musics')