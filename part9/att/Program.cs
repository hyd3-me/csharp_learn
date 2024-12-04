using System;
public class Answer {
    public static void PrintRange(int M, int N) {
        if (M > N) return;
        Console.Write(M);
        if (M < N) Console.Write(", ");
        PrintRange(M + 1, N);
    }
    public static int SumRange(int M, int N) {
        if (M > N) return 0;
        return M + SumRange(M + 1, N);
    }
    public static int Ackermann(int m, int n) {
        if (m == 0) return n + 1;
        else if (m > 0 && n == 0) return Ackermann(m - 1, 1);
        else if (m > 0 && n > 0) return Ackermann(m - 1, Ackermann(m, n - 1));
    return 0; // Для случая, если входные данные неверные
}
    static public void Main(string[] args) {
        // задача 1
        int M = 1; // Можно поменять значение для проверки
        int N = 5; // Можно поменять значение для проверки
        Console.WriteLine("Числа в промежутке:");
        PrintRange(M, N);
        Console.Write("\n");

        // задача 2
        int M2 = 1; // Можно поменять значение для проверки
        int N2 = 15; // Можно поменять значение для проверки
        int sum = SumRange(M2, N2);
        Console.WriteLine($"Сумма элементов в промежутке от {M2} до {N2}: {sum}");

        // задача 3
        int m = 2; // Можно поменять значение для проверки
        int n = 3; // Можно поменять значение для проверки
        int result = Ackermann(m, n);
        Console.WriteLine($"A({m}, {n}) = {result}");
    }
}