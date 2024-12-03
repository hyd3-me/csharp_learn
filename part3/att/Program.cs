using System;
using System.Collections.Generic;

public class Answer {

    // задача 1
    static int SumArray(int[] arrNumbers) {
        int sum = 0;
        for (int i = 0; i < arrNumbers.Length; i++) {
            sum += arrNumbers[i];
        }
        return sum;
    }

    // задача 2
    static int MaxValue(int[] arrNumbers) {
        int max = arrNumbers[0];
        for (int i = 0; i < arrNumbers.Length; i++) {
            if (arrNumbers[i] > max) {
                max = arrNumbers[i];
            }
        }
        return max;
    }

    // задача 3
    static int ProductOfArray(int[] arrNumbers) {
        int prod_result = 1;
        for (int i = 0; i < arrNumbers.Length; i++) {
            prod_result *= arrNumbers[i];
        }
        return prod_result;
    }

    // задача 4

    static int[] RemoveEvenNumbers(int[] numbers) {
        List<int> listOddNums = new List<int>();
        for (int i = 0; i < numbers.Length; i++) {
            if (numbers[i] % 2 != 0) {
                listOddNums.Add(numbers[i]);
            }
        }
        return listOddNums.ToArray();
    }

    static double AverageInRange(int[] numbers, int start, int end) {
        if (start < 0 || end >= numbers.Length || start > end) {
            throw new ArgumentException("Неверные индексы диапазона.");
        }
        double sum = 0;
        int count = end - start + 1;
        for (int i = start; i <= end; i++) {
            sum += numbers[i];
        }
        return sum / count;
    }
    
    static public void Main(string[] args) {

        int[] arrNumbers1 = { 1, 2, 3, 4, 5 };
        int result = SumArray(arrNumbers1);
        Console.WriteLine($"задача 1: {result}");

        int[] arrNumbers2 = { 7, 1, 8, 3, 4 };
        int maxResult = MaxValue(arrNumbers2);
        Console.WriteLine($"задача 2: {maxResult}");

        int[] arrNumbers3 = { 2, 3, 4 };
        int prod_result = ProductOfArray(arrNumbers3);
        Console.WriteLine($"задача 3: {prod_result}");

        int[] arrNumbers4 = {1, 2, 3, 4, 5};
        int[] result4 = RemoveEvenNumbers(arrNumbers4);
        Console.WriteLine($"задача 4: {String.Join(", ", result4)}");

        int[] numbers5 = {1, 4, 6, 8, 10}; // Массив можно поменять для проверки
        int start = 1; // Начальный индекс диапазона
        int end = 3; // Конечный индекс диапазона

        double result5 = AverageInRange(numbers5, start, end);
        Console.WriteLine($"задача 5: {result5}");
    }
}
