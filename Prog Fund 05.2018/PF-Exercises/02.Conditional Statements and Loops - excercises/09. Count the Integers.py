consoleEntry = 0
counter = 0

while True:
    try:
        consoleEntry = int(input())
        counter += 1
    except:
        break

print(counter)