n = int(input())
m = int(input())
maxSum = int(input())
sum = 0
combinationNumber = 0

for n1 in range(n, 0, -1):
    for n2 in range(1, m+1):
        sum += 3 * (n1 * n2)
        combinationNumber += 1
        if sum >= maxSum:
            break
    if sum >= maxSum:
        break

if sum >= maxSum:
    print('{} combinations\n'
          'Sum: {} >= {}'.format(combinationNumber,sum,maxSum))
else:
    print('{} combinations\n'
          'Sum: {}'.format(combinationNumber,sum))