def sum(a, b):
    if b == 0:
        return a
    elif b > 0:
        return sum(a + 1, b - 1)

a = 7
b = 6
print(sum(a, b))