toDoList = []
listItem1 = input("Please enter what you would like to do: ")
toDoList.append(listItem1)
listItem2 = input("Please enter something else you would like to do: ")
toDoList.append(listItem2)
listItem3 = input("Please enter one last thing you'd like to do: ")
toDoList.append(listItem3)
print(toDoList)
x = 5
while x == 5
done1 = input(f"Have you done {listItem1}? (Y/N)"
if done1 = "Y":
    toDoList.remove(listItem1)
    x += 1
elif done1 = "N":
    x += 1
else:
    print("please enter a valid response")
while x == 6
done2 = input(f"Have you done {listItem2}? (Y/N)")
if done2 = "Y":
    toDoList.remove(listItem2)
    x += 1
elif done2 = "N":
    x += 1
else:
    print("Please enter a valid response")
while x == 7
done3 = input(f"Have you done {listItem3}? (Y/N)")
if done3 = "Y":
    toDoList.remove(listItem3)
    x += 1
elif done3 = "N"
    x += 1
else:
    print("Please enter a valid response: ")

if x == 8
    print(f"You still have {toDoList} to do")