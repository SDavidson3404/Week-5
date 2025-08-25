colors = ["Blue", "blue", "Red", "red", "Pink", "pink"]
colorGuess = input("Please enter a color: ")
if colorGuess in colors:
    print(f"yes, {colorGuess} is in the color list")
else:
    print(f"sorry, {colorGuess} is not in the color list")