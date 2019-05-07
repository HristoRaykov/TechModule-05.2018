word = input()

wordPlural = ''

if word[-1] == 'y':
    wordPlural = word[:-1]+'ies'
elif word[-1] == 'o' or word[-2:] == 'ch' or word[-1] == 's' or word[-2:] == 'sh' or\
        word[-1] == 'x' or word[-1] == 'z':
    wordPlural = word + 'es'
else:
    wordPlural = word + 's'

print(wordPlural)

