p = int(input())
d = int(input())
result = 0
new_d = 0
if not ((p % 2) != 0 or (p < 2) or (p > 100) or (d > 1000) or (d < 1)):
     new_d = d
     result = new_d % p
     while not (0 <= result <= (p / 2)):
           new_d += d
           result = new_d % p
print(str(new_d))