import random

k = 2
str1 = ""
for el in range(k + 1):
    a = random.randrange(-10, 10)
    if el == 0:
        str1 += f"{a}x^{k - el}"
    if el == k:
        if a > 0:
            str1 += f"+{a}+x^{k - el}+"
    str1 += f"{a}x^{k - el}+"
    print(str1)

