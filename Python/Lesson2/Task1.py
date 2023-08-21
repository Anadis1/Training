
def input_num():
    num = int(input("Input num: "))
    return num

def fact(num):
    product = 1
    i = 1
    while i <= num:
        product *= i
        i += 1

    print(product)

n = input_num()

fact(n)