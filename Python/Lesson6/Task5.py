N = int(input("Введите потолок: "))

def sum_del(N):
    sum = 0
    for i in range(1, N):
        if N % i == 0:
            sum +=i
    return sum
list_ans = []
for i in range(1, N):
    for j in range(1, N):
        if sum_del(j) == i and sum_del(i) == j and i != j:
            if j not in list_ans:
                list_ans.append(i)
                print(j, i)