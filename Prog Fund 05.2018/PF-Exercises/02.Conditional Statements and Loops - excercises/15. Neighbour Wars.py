peshoDamage = int(input())
goshoDamage = int(input())
winner = ''
roundNumber = 1
peshoHealth = 100
goshoHealth = 100

while peshoHealth > 0 and goshoHealth > 0:
    if roundNumber % 2 == 1:
        if goshoHealth > peshoDamage:
            goshoHealth -= peshoDamage
            print('{} used {} and reduced {} to {} health.'.format('Pesho', 'Roundhouse kick', 'Gosho', goshoHealth))
        else:
            winner = 'Pesho'
            break
    else:
        if peshoHealth > goshoDamage:
            peshoHealth -= goshoDamage
            print('{} used {} and reduced {} to {} health.'.format('Gosho', 'Thunderous fist', 'Pesho', peshoHealth))
        else:
            winner = 'Gosho'
            break
    if roundNumber % 3 == 0:
        peshoHealth += 10
        goshoHealth += 10
    roundNumber += 1

print('{} won in {}th round.'.format(winner, roundNumber))
