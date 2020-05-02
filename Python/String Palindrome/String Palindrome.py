def is_palindrome(name):
    # String palindrome like Ana, Repaper
    reverse_name = ""

    for i in range(len(name) - 1, -1, -1):
        reverse_name += name[i]

    if reverse_name == name:
        return True
    else:
        return False


name = input("Enter name: ")
if is_palindrome(name) is True:
    print("Your name is Palindrome.")
else:
    print("Your name isn't Palindrome.")
