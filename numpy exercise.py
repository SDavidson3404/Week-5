import numpy
import random

matrixSizeA = int(input("Please enter the first dimension of the matrices: "))
matrixSizeB = int(input("Please enter the second dimension of the matrices: "))

matrixA = numpy.array([])
matrixB = numpy.array([])

for i in range(matrixSizeA):
    a = []
    for j in range(matrixSizeB):
        a.append(random.randint(1, 50))
    matrixA = numpy.append(matrixA, a)

for i in range(matrixSizeB):
    a = []
    for j in range(matrixSizeA):
        a.append(random.randint(1, 50))
    matrixB = numpy.append(matrixB, a)


result = numpy.dot(matrixA, matrixB)
print(result)