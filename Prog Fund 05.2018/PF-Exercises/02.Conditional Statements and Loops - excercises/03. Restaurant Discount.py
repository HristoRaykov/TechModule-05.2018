groupSize = int(input())
package = input()
price = 0
hallName = ''

if groupSize <= 50:
    price = 2500
    hallName = 'Small Hall'
    if package == 'Normal':
        price += 500
        price *= 0.95
    elif package == 'Gold':
        price += 750
        price *= 0.9
    elif package == 'Platinum':
        price += 1000
        price *= 0.85
elif groupSize <= 100:
    price = 5000
    hallName = 'Terrace'
    if package == 'Normal':
        price += 500
        price *= 0.95
    elif package == 'Gold':
        price += 750
        price *= 0.9
    elif package == 'Platinum':
        price += 1000
        price *= 0.85
elif groupSize <= 120:
    hallName = 'Great Hall'
    price = 7500
    if package == 'Normal':
        price += 500
        price *= 0.95
    elif package == 'Gold':
        price += 750
        price *= 0.9
    elif package == 'Platinum':
        price += 1000
        price *= 0.85

if groupSize <= 120:
    print('We can offer you the {}\nThe price per person is {:.2f}$'.format(hallName, price/groupSize))
else:
    print('We do not have an appropriate hall.')
