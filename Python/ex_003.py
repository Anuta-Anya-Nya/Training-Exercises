# заменить первые буквы сло на заглавные
def to_jaden_case(string):
    my_str = list(string.split(" "))
    list_str = []
    for i in range(0, len(my_str)):
        list_str.append(my_str[i].capitalize())
    new_string = ' '.join(list_str)
    return new_string

# def to_jaden_case(string):
#     list = string.split()
#     new_list = [i.capitalize() for i in list]
#     return ' '.join(new_list)

# def to_jaden_case(string):
#     return ' '.join(word.capitalize() for word in string.split())


print(to_jaden_case("I am fool one two rt's"))
