profession = input()
drink = ''
quantity = int(input())
totalPrice = 0

if profession == 'Athlete':
    drink = 'Water'
    totalPrice = quantity * 0.7
elif profession == 'Businessman' or profession == 'Businesswoman':
    drink = 'Coffee'
    totalPrice = quantity * 1
elif profession == 'SoftUni Student':
    drink = 'Beer'
    totalPrice = quantity * 1.7
else:
    drink = 'Tea'
    totalPrice = quantity * 1.2

print('The %s has to pay %.2f.' %(profession,totalPrice))