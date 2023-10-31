const { ZingMp3 } = require("zingmp3-api-full");

function crawlPlaylist(IdPlaylist) {
    const musics = []; // Khai báo biến musics để lưu danh sách bài hát

    size = 30; 

    return ZingMp3.getDetailPlaylist(IdPlaylist).then((data) => { // Sử dụng IdPlaylist trong getDetailPlaylist
        const promises = [];

        for (let i = 0; i < Math.min(size, data.data.song.items.length); ++i) {
            const encodeId = data.data.song.items[i].encodeId;
            let title = "";
            let artistsNames = "";
            let genre = "";
            let preview_mp3 = "";
            let lyrics = [];
            let isAdd = true;

            const promise = ZingMp3.getInfoSong(encodeId)
                .then((item) => {
                    const song = item.data;
                    title = song.title;
                    artistsNames = song.artistsNames;
                    genre = song.genres[1].title;
                })
                .then(() => ZingMp3.getSong(encodeId))
                .then((item) => {
                    if(item.err === 0) preview_mp3 = item.data['128'];
                    else isAdd = false; // Thành viên vip mới nghe được
                })
                .then(() => ZingMp3.getLyric(encodeId))
                .then((data) => {
                    try {
                        data.data.sentences.forEach((element) => {
                            lyrics.push(element.words.map((item) => item.data).join(' '));
                        });

                        lyrics = lyrics.map((item) => item).join('\n');
                    }   catch (e) {
                        // Không có lyrics
                        isAdd = false;
                    }
                })
                .then(() => {
                    const music = {
                        title: title,
                        artistsNames: artistsNames,
                        genre: genre,
                        preview_mp3: preview_mp3,
                        lyrics: lyrics
                    };

                    if(isAdd) musics.push(music);
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
    const fs = require('fs');
    const json = JSON.stringify(array);
    
    fs.writeFile(name + '.json', json, 'utf8', (err) => {
      if (err) {
        console.error('Error writing JSON file:', err);
      } else {
        console.log('JSON file has been saved.');
      }
    });
}

function createData(IdPlaylist, name) {
    crawlPlaylist(IdPlaylist).then((musics) => {
        console.log(name + ": " + musics.length)
        exportFileJson(musics, name)
    })
}

createData('ZWZB969E', 'NhacViet')
// createData('ZWZB96AB', 'NhacAuMy')