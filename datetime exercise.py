from datetime import datetime
today = datetime.today()
birthday = input("Please enter your next birthday in YYYY-MM-DD format: ")
date_object = datetime.strptime(birthday, "%Y-%m-%d")

difference = date_object - today

print(f"Your birthday is {difference} away")