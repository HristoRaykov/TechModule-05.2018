num = int(input())

while num % 2 == 0:
    print('Please write an odd number.')
    num = int(input())

print('The number is: ' + str(abs(num)))
