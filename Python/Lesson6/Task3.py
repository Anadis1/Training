list_1 = [9,8,15,5, 2, 1, 10]

# count = 0
# for i in range(-1, len(list_1)-1):
#     if list_1[i] > list_1[i+1] and list_1[i] > list_1[i-1]:
#         count +=1
#         print(list_1[i])
# print(count)

# print(sum([1 for x in range(-1, len(list_1)-1) if list_1[x] > list_1[x+1] and list_1[x] > list_1[x-1]]))
print(sum([1 for x in range(-1, len(list_1)-1) if list_1[x-1] < list_1[x] > list_1[x+1]]))