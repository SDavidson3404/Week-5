import json

filepath = input("Please input file path you'd like to convert: ")
with open(filepath, "r") as file:
    data = json.load(file)

print(data)