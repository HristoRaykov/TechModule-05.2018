num1 = int(input())
num2 = int(input())

minNum = min(num1, num2)
maxNum = max(num1, num2)

for i in range(minNum,maxNum+1):
    print(i)
