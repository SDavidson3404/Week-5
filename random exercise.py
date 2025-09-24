import random

score = random.randint(1, 100)
score2 = random.randint(1, 100)
score3 = random.randint(1, 100)
score4 = random.randint(1, 100)
score5 = random.randint(1, 100)
score6 = random.randint(1, 100)
score7 = random.randint(1, 100)
score8 = random.randint(1, 100)
score9 = random.randint(1, 100)
score10 = random.randint(1, 100)

scores = [score, score2, score3, score4, score5, score6, score7, score8, score9, score10]

highest = 0
lowest = 100
for score in scores:
    if highest < score:
        highest = score
    if lowest > score:
        lowest = score

average = (score + score2 + score3 + score4 + score5 + score6 + score7 + score8 + score9 + score10) / 10

print(f"The highest score is {highest}, the lowest is {lowest}, and the average is {average}")