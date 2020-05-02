#Internal Multiplication 3d vector

rows = int(input("Enter rows: "));
columns = int(input("Enter columns: "));

matrix1 = {};
matrix2 = {};
matrix_result = {};

for r in range(1, rows + 1, 1):
    for c in range(1, columns + 1, 1):
        matrix1[str(r) + "," + str(c)] = int(input("(Matrix1) -> Enter element [" + str(r) + "][" + str(c) + "] value: "));

for r in range(1, rows + 1, 1):
    for c in range(1, columns + 1, 1):
        matrix2[str(r) + "," + str(c)] = int(input("(Matrix2) -> Enter element [" + str(r) + "][" + str(c) + "] value: "));

for r in range(1, rows + 1, 1):
    for c in range(1, columns + 1, 1):
        matrix_result[str(r) + "," + str(c)] = matrix2[str(r) + "," + str(c)] + matrix1[str(r) + "," + str(c)];

for r in range(1, rows + 1, 1):
    for c in range(1, columns + 1, 1):
        print(matrix_result[str(r) + "," + str(c)], end = "    ");
    print("\n", end = "");

input();