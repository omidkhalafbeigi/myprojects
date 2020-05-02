import random as rnd

number = input("Enter your number between 0 and 9: ")
if int(number) > 9 or int(number) < 0:
    print("Enter correct number.")
else:
    number_rnd = rnd.randrange(1, 9, 1, _int=int)
    counter = 1

    while number != "exit" and number != number_rnd:
        if int(number) > number_rnd:
            print("Too high...")
            counter += 1
        elif int(number) < number_rnd:
            print("Too slow...")
            counter += 1
        else:
            counter += 1
            break
        number = input("Enter your number between 0 and 9: ")
        if int(number) > 9 or int(number) < 0:
            print("Enter correct number...")
            continue

    print("Number is: {}".format(str(number_rnd), number_rnd, number_rnd))
    print("You did guess for {} times.".format(str(counter), counter, counter))
