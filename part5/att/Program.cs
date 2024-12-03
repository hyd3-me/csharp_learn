using System;

class Program {
    static bool IsNumberPresent(int[] arrNumbers, int numberToFind) {
        foreach (int number in arrNumbers) {
            if (number == numberToFind) {
                return true;
            }
        }
        return false;
    }
        static void SwapSigns(int[] arrNumbers) {
        for (int i = 0; i < arrNumbers.Length; i++) {
            arrNumbers[i] = -arrNumbers[i];
        }
    }
    static double CalculateAverage(int[] arrNumbers) {
        double sum = arrNumbers.Sum();
        return sum / arrNumbers.Length;
    }
    static int[] RemoveNegatives(int[] arrNumbers) {
        return arrNumbers.Where(n => n >= 0).ToArray();
    }
    static void Main(string[] args) {
        // задача 1
        int[] arrNumbers1 = { 1, 3, 4, 19, 3 };
        int numberToFind = 8;
        if (IsNumberPresent(arrNumbers1, numberToFind)) {
            Console.WriteLine("Присутствует");
        } else {
            Console.WriteLine("Не присутствует");
        }

        // задача 2
        int[] arrNumbers2 = { 1, -5, 6, -7, 3 };
        SwapSigns(arrNumbers2);
        Console.WriteLine($"[{string.Join(", ", arrNumbers2)}]");

        // задача 3
        int[] arrNumbers3 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        double average = CalculateAverage(arrNumbers3);
        Console.WriteLine(average);

        // задача 4
        int[] arrNumbers4 = { 5, -3, 9, -1, 2, -7, 0 };
        int[] result = RemoveNegatives(arrNumbers4);
        Console.WriteLine($"[{string.Join(", ", result)}]");
    }
}



