# ДАнный список удалить дубли, перенести - в конец списка
my_list = [1, 1, 1, 1, 2, 2, 3, 3, 3, 3, 4, 4, 5]
print(my_list)
number = my_list[0]
for i in range(0, len(my_list)-1):
    if number == my_list[i+1]:
        my_list[i+1] = "-"
    else:
        number = my_list[i+1]
print(my_list)
for i in range(1, len(my_list)):
    if my_list[i] != "-" and my_list[i-1] == "-":
        while my_list[i-1] == "-":
            my_list[i-1] = my_list[i]
            my_list[i] = "-"
            i = i-1
print(my_list)
