import csv
scores = []
filepath = input("Please input the file location: ")
column = input("What is the name of the column the scores in?: ")
with open(filepath, "r") as file:
    reader = csv.DictReader(file)
    for row in reader:
        scores.append({col: row[col] for col in column})