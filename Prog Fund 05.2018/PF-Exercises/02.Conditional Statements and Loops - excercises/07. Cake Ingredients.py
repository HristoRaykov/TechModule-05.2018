ingredient = input()
counter = 0

while ingredient != 'Bake!':
    counter += 1
    print('Adding ingredient {}.'.format(ingredient))
    ingredient = input()
print('Preparing cake with {} ingredients.'.format(counter))