fo = open('test.txt', 'w')

print('Name:', fo.name)
print('Is the file closed:', fo.closed)
print('Opening mode:', fo.mode)

fo.write('<3 Python')
fo.write(' and CSharp!')
fo.close()

fo = open('test.txt', 'a')
fo.write(' And I also like CPP')
fo.close()

fo = open('test.txt', 'r+')
text = fo.read()
fo.close()
print(text)

fo = open('newtest.txt', 'w+')
fo.write('This is my new file')
fo.close()