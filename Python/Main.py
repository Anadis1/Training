n = 123

number = n
sumNumber = 0
while number != 0:
    sumNumber = sumNumber + number % 10
    number = int(number / 10)

res = int(sumNumber)
print(res)

