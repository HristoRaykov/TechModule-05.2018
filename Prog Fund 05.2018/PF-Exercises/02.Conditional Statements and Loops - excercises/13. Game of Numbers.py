n = int(input())
m = int(input())
magicNumber = int(input())

sum = 0
firstNumber = 0
secondNumber = 0
isNumber = False
counter = 0

for n1 in range(n, m + 1):
    for n2 in range(n, m + 1):
        sum = n1 + n2
        counter += 1
        if sum == magicNumber:
            isNumber = True
            firstNumber = n1
            secondNumber = n2

if isNumber:
    print('Number found! {} + {} = {}'.format(firstNumber, secondNumber, magicNumber))
else:
    print('{} combinations - neither equals {}'.format(counter, magicNumber))