dayType = input()
age = int(input())
ticketPrice = 0

if 0 <= age <= 18:
    if dayType == 'Weekday':
        ticketPrice = 12
    elif dayType == 'Weekend':
        ticketPrice = 15
    elif dayType == 'Holiday':
        ticketPrice = 5
elif 18 < age <= 64:
    if dayType == 'Weekday':
        ticketPrice = 18
    elif dayType == 'Weekend':
        ticketPrice = 20
    elif dayType == 'Holiday':
        ticketPrice = 12
elif 64 < age <= 122:
    if dayType == 'Weekday':
        ticketPrice = 12
    elif dayType == 'Weekend':
        ticketPrice = 15
    elif dayType == 'Holiday':
        ticketPrice = 10

if age < 0 or age >122:
    print('Error!')
else:
    print('{}$'.format(ticketPrice))
