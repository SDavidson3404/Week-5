import math
radii = int(input("Please enter your first radii of a circle: "))
radii2 = int(input("Please enter your second radii of a circle: "))
radii3 = int(input("Please enter the final radii of a circle: "))

area = math.pi * radii ** 2
area2 = math.pi * radii2 ** 2
area3 = math.pi * radii3 ** 2

print(f"The areas of the circles are {area}, {area2}, and {area3}")