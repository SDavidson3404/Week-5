import os
path = input("Please enter the folder location which you would like to check: ")
content = os.listdir(path)
for entry in os.scandir(path):
    fileSize = os.path.getsize(entry)
    print(f"file: {entry}, size: {fileSize}")