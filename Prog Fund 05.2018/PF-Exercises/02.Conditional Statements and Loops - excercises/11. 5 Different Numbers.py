a = int(input())
b = int(input())

minNum = min(a, b)
maxNum = max(a, b)

if maxNum - minNum >= 4:
    for n1 in range(minNum, maxNum + 1 - 4):
        for n2 in range(n1 + 1, maxNum + 1 - 3):
            for n3 in range(n2 + 1,maxNum + 1 - 2):
                for n4 in range(n3 + 1, maxNum + 1 - 1):
                    for n5 in range(n4 + 1, maxNum + 1 - 0):
                        print('{} {} {} {} {}'.format(n1, n2, n3, n4, n5))
else:
    print('No')
