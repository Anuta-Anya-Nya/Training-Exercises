# удалить из списка все вхождения второго списка
def array_diff(a, b):
    for i in range(0, len(b)):
        for k in range(0, len(a)):
            if b[i] == a[k]:
                a[k] = "-"
    ind = 0
    while ind < len(a):
        if a[ind] == "-":
            a.remove("-")
            ind -= 1
        ind += 1
    return a

# def array_diff(a, b):
#     for i in range(len(b)):
#         while b[i] in a:
#             a.remove(b[i])
#     return a


list_1 = []
list_2 = [1, 2]
print(array_diff(list_1, list_2))
