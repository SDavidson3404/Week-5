numbers = input("Please enter a list of numbers separated by spaces: ")
numberList = numbers.split()
intList = list(map(int, numberList))
sum = 0
for number in intList:
    sum += number
print(sum)