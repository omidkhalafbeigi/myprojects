# Sieve of Eratosthenes

import time
start = time.time()
number = int(input('Enter number: '))
counter = 2
result = 0
list_of_numbers = list(range(2, number + 1, 1))
for i in range(2, number + 1, 1):
    for j in range(i, number + 1, 1):
        result = counter * i
        counter += 1
        if result in list_of_numbers:
            del(list_of_numbers[list_of_numbers.index(result)])
        else:
            pass
end = time.time()
time_spent = end - start
print(f'Prime numbers: \n{list_of_numbers}\nTimes spent: {time_spent.__round__(3)}s')