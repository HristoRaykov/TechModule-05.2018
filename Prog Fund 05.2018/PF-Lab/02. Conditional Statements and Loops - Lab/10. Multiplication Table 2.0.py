number = int(input())
multiplier = int(input())

if multiplier < 10:
    for i in range(multiplier, 11):
        print('{} X {} = {}'.format(number, i, number*i))
else:
    print(print('{} X {} = {}'.format(number, multiplier, number*multiplier)))
