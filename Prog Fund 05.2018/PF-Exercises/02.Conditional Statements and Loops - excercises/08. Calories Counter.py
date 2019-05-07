n = int(input())
totalCal = 0
ingredient = ''

for i in range(n):
    ingredient = input().lower()
    if ingredient == 'cheese':
        totalCal += 500
    elif ingredient == 'tomato sauce':
        totalCal += 150
    elif ingredient == 'salami':
        totalCal += 600
    elif ingredient == 'pepper':
        totalCal += 50

print('Total calories: {}'.format(totalCal))