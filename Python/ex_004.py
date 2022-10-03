def is_isogram(string):
    for i in range(0, len(string)-1):
        char = string[i].lower()
        for k in range(i+1, len(string)):
            if char == string[k].lower():
                return False
    return True

# return len(string) == len(set(string.lower())) // set создание множества, где неповторяющиеся элементы. т.е. если в строке все элементы уникальны, тогда она будет равно множеству


print(is_isogram(""))
