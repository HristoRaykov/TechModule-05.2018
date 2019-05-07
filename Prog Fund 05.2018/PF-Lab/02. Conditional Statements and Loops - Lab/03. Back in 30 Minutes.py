hour = int(input())
minutes = int(input())

if minutes >= 30:
    hour += 1
    minutes -= 30
else:
    minutes += 30

if hour == 24:
    hour = 0

print('{}:{:02}'.format(hour,minutes))