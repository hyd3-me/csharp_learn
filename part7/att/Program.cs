class Program {
    static void FindMaxInRows(int[,] array) {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);
        for (int i = 0; i < rows; i++) {
            int max = array[i, 0];
            for (int j = 1; j < cols; j++) {
                if (array[i, j] > max) {
                    max = array[i, j];
                }
            }
            Console.WriteLine($"Максимальный элемент в строке {i}: {max}");
        }
    }

    static void FindSumInColumns(int[,] array) {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);
        for (int j = 0; j < cols; j++) {
            int sum = 0;
            for (int i = 0; i < rows; i++) {
                sum += array[i, j];
                }
            Console.WriteLine($"Сумма элементов в столбце {j}: {sum}");
        }
    }

    static void TransposeMatrix(int[,] array) {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);
        int[,] transposed = new int[cols, rows];
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                transposed[j, i] = array[i, j];
            }
        }
        Console.WriteLine("Транспонированный массив:");
        for (int i = 0; i < cols; i++) {
            for (int j = 0; j < rows; j++) {
                Console.Write(transposed[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static void ReplaceNegativeNumbers(int[,] array) {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                if (array[i, j] < 0) {
                    array[i, j] = -array[i, j];
                }
            }
        }
        Console.WriteLine("Массив после замены отрицательных чисел:");
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static void Main() {
        // задача 1
        int[,] array1 = {
            { 1, 3, 5, 7 },
            { 2, 4, 6, 8 },
            { 9, 10, 11, 12 }
        };
        FindMaxInRows(array1);

        // задача 2
        int[,] array2 = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 },
            { 10, 11, 12 }
        };
        FindSumInColumns(array2);

        // задача 3
        int[,] array3 = {
            { 1, 2 },
            { 3, 4 },
            { 5, 6 }
        };
        TransposeMatrix(array3);

        // задача 4
        int[,] array4 = {
            { 1, -2, 3 },
            { -4, 5, -6 },
            { 7, -8, 9 }
        };
        ReplaceNegativeNumbers(array4);
    }
}