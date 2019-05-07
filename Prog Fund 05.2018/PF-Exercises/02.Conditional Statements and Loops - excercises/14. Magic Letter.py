firstLetter = input()
secondLetter = input()
exceptionLetter = input()

for letter1 in range(ord(firstLetter), ord(secondLetter + 1)):
    if letter1 != ord(exceptionLetter):
        for letter2 in range(ord(firstLetter), ord(secondLetter + 1)):
            if letter2 != ord(exceptionLetter):
                for letter3 in range(ord(firstLetter), ord(secondLetter + 1)):
                    if letter3 != ord(exceptionLetter):
                        print('{}{}{}'.format(chr(letter1), chr(letter2), chr(letter3)))
