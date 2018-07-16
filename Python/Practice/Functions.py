def sumNumbers(numOne, numTwo):
    total = numOne + numTwo
    return total


result = sumNumbers(2, 4)

print(result)


def sayHello(name):
    print('Hello ' + name)


sayHello('Andrew')


def addOneToNum(num):
    num += 1
    print('The result inside function is ' + str(num))


num = 5
addOneToNum(num)
print('The result outside function is ' + str(num))