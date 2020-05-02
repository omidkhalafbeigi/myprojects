import math


def get_func(ls):
    result = []

    for i in range(0, 4, 1):
        if ls[i] == "square":
            result.append(lambda x: x * x)
        elif ls[i] == "circle":
            result.append(lambda x: x * x * math.pi)
        elif ls[i] == "rectangle":
            result.append(lambda x, y: x * y)
        else:
            result.append(lambda x, y: x * y * 0.5)

    return result

