n = int(input())

oddNumberCount = 0
number = 1
sum = 0

while oddNumberCount != n:
    if number % 2 == 1:
        oddNumberCount += 1
        sum += number
        print(number)
    number += 1

print('Sum: ' + str(sum))