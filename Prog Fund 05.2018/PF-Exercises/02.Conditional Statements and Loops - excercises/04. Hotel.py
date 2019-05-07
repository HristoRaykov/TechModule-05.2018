month = input()
nightsCount = int(input())

priceStudio = 0
priceDouble = 0
priceSuite = 0

if month == 'May' or month == 'October':
    priceStudio = 50
    priceDouble = 65
    priceSuite = 75

    if nightsCount > 7:
        priceStudio *= 0.95
        if month == 'October':
            priceStudio = priceStudio*(nightsCount - 1)/nightsCount

elif month == 'June' or month == 'September':
    priceStudio = 60
    priceDouble = 72
    priceSuite = 82

    if nightsCount > 14:
        priceDouble *= 0.9
        if month == 'September':
            priceStudio = priceStudio * (nightsCount - 1) / nightsCount
    elif nightsCount > 7:
        if month == 'September':
            priceStudio = priceStudio * (nightsCount - 1) / nightsCount

elif month == 'July' or month == 'August' or month == 'December':
    priceStudio = 68
    priceDouble = 77
    priceSuite = 89

    if nightsCount > 14:
        priceSuite *= 0.85

print('Studio: {:.2f} lv.\n'
      'Double: {:.2f} lv.\n' 
      'Suite: {:.2f} lv.'.format(priceStudio*nightsCount,priceDouble*nightsCount,priceSuite*nightsCount))