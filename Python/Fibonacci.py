#Fibonatchi
number = int(input("Enter number: "))
a1 = 0
a2 = 1
a3 = 0
print(a1)
print(a2)
while (a3 < number):
     a3 = a1 + a2
     a1 = a2
     a2 = a3
     print(a3)