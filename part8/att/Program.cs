using System;

public class Answer {
    public static int[,] TransposeMatrix(int[,] matrix) {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int[,] transposed = new int[cols, rows];
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                transposed[j, i] = matrix[i, j];
            }
        }
        return transposed;
    }
    public static void PrintMatrix(int[,] matrix) {
        for (int i = 0; i < matrix.GetLength(0); i++) {
            for (int j = 0; j < matrix.GetLength(1); j++) {
                Console.Write($"{matrix[i, j]}\t");
            }
            Console.WriteLine();
        }
    }
    public static int SumMainDiagonal(int[,] matrix) {
        int sum = 0;
        int size = matrix.GetLength(0);
        for (int i = 0; i < size; i++) {
            sum += matrix[i, i];
        }
        return sum;
    }

    public static (int, int)? FindElement(int[,] matrix, int value) {
        for (int i = 0; i < matrix.GetLength(0); i++) {
            for (int j = 0; j < matrix.GetLength(1); j++) {
                if (matrix[i, j] == value) {
                    return (i, j);
                }
            }
        }
        return null;
    }
    public static void ReplaceValue(int[,] matrix, int oldValue, int newValue) {
        for (int i = 0; i < matrix.GetLength(0); i++) {
            for (int j = 0; j < matrix.GetLength(1); j++) {
                if (matrix[i, j] == oldValue) {
                    matrix[i, j] = newValue;
                }
            }
        }
    }
    public static void MultiplyByScalar(int[,] matrix, int scalar) {
        for (int i = 0; i < matrix.GetLength(0); i++) {
            for (int j = 0; j < matrix.GetLength(1); j++) {
                matrix[i, j] *= scalar;
            }
        }
    }

    static public void Main(string[] args) {
        // задача 1
        int[,] matrix1 = new int[,] {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };
        Console.WriteLine("Исходная матрица:");
        PrintMatrix(matrix1);
        int[,] transposedMatrix = TransposeMatrix(matrix1);
        Console.WriteLine("\nТранспонированная матрица:");
        PrintMatrix(transposedMatrix);

        // задача 2
        int[,] matrix2 = new int[,] {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };
        Console.WriteLine("Исходная матрица:");
        PrintMatrix(matrix2);
        int sum = SumMainDiagonal(matrix2);
        Console.WriteLine($"\nСумма элементов главной диагонали: {sum}");

        // задача 3
        int[,] matrix3 = new int[,] {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };
        Console.WriteLine("Исходная матрица:");
        PrintMatrix(matrix3);
        int valueToFind = 5; // Можно поменять значение для проверки
        var result = FindElement(matrix3, valueToFind);
        if (result.HasValue) {
            Console.WriteLine($"\nИндекс(ы): ({result.Value.Item1}, {result.Value.Item2})");
        } else {
            Console.WriteLine($"\nЧисло {valueToFind} не найдено.");
        }

        // задача 4
        int[,] matrix4 = new int[,] {
            {1, 2, 3},
            {4, 2, 6},
            {7, 8, 2}
        };
        Console.WriteLine("Исходная матрица:");
        PrintMatrix(matrix4);
        int oldValue = 2; // Можно поменять значение для проверки
        int newValue = 0;
        ReplaceValue(matrix4, oldValue, newValue);
        Console.WriteLine($"\nМатрица после замены {oldValue} на {newValue}:");
        PrintMatrix(matrix4);

        // задача 5
        int[,] matrix5 = new int[,] {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };
        Console.WriteLine("Исходная матрица:");
        PrintMatrix(matrix5);
        int scalar = 2;
        MultiplyByScalar(matrix5, scalar);
        Console.WriteLine($"\nМатрица после умножения на скаляр {scalar}:");
        PrintMatrix(matrix5);
    }
}