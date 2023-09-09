values = [2, 3, 5, 7, 11, 13, 17, 19, 23, 29]
transormed_values = list(map(lambda values: values, values))
if values == transormed_values:
    print('ok')
else:
    print('fail')