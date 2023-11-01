import json
import requests
import os
from urllib.parse import urlparse

def download_image(url, file_name, folder_path="Image"):
    if not os.path.exists(folder_path):
        os.makedirs(folder_path)

    file_extension = os.path.splitext(urlparse(url).path)[1]
    file_path = os.path.join(folder_path, file_name + file_extension)

    response = requests.get(url)

    # Lưu ảnh vào tệp tin
    with open(file_path, "wb") as file:
        file.write(response.content)

def dowloadImage(fileJson):
    with open(fileJson, "r", encoding="utf-8") as file:
        data = json.load(file)

    for item in data:
        download_image(item['thumbnail'], item['title'])

def download_mp3(url, file_name):
    folder_path = 'Mp3'
    if not os.path.exists(folder_path):
        os.makedirs(folder_path)

    file_path = os.path.join(folder_path, file_name + '.mp3')
    response = requests.get(url)

    # Lưu ảnh vào tệp tin
    with open(file_path, "wb") as file:
        file.write(response.content)

def dowloadMp3(fileJson):
    with open(fileJson, "r", encoding="utf-8") as file:
        data = json.load(file)

    for item in data:
        download_mp3(item['preview_mp3'], item['title'])

dowloadImage('musics.json')
dowloadMp3('musics.json')