myStr = "Hello"
myInt = 4
myFloat = 5.2

myList = [1, 2, 3, 'Hello']
myDict = {'a': 1, 'b': 2, 'c': 3}

print(type(myStr), myStr)
print(type(myInt), myInt)
print(type(myFloat), myFloat)
print(type(myList), myList)
print(type(myDict), myDict)

print(myList[3])

greetings = myStr + ' World'
print(greetings)

peoples = ['Jim', 'Sara', 'Tim', 'Bob']

for people in peoples:
    print(people)

for i in range(len(peoples)):
    print(peoples[i])