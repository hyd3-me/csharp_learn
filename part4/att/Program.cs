
// задача 1
System.Console.Write("введите основание: ");
int powerBase = int.Parse(System.Console.ReadLine());

System.Console.Write("введите степень: ");
int exponent = int.Parse(System.Console.ReadLine());


int Power(int powerBase, int exponent) {
    int pow = 1;
    for (int i = 0; i < exponent; i++) {
        pow *= powerBase;
    }
    return pow;
}
if (exponent < 0) {
    System.Console.Write("степень должна быть больше нуля");
    return;
}
int pow = Power(powerBase, exponent);
System.Console.WriteLine($"число {powerBase} в степени {exponent} равно {pow}");


// задача 2
System.Console.WriteLine("введите число");
int num = int.Parse(System.Console.ReadLine());

int SumAllDigit(int num) {
    int result = 0;
    while (num > 0) {
        result += num % 10;
        num = num / 10;
    }
    return result;
}

int sum = SumAllDigit(num);
System.Console.WriteLine($"сумма всех чисел в числе {num} равна {sum}");


// задача 3
System.Console.WriteLine("длина массива");
int arrayLength = int.Parse(System.Console.ReadLine());

System.Console.WriteLine("от какого значения диапазон");
int minRange = int.Parse(System.Console.ReadLine());

System.Console.WriteLine("до какого значения диапазон");
int maxRange = int.Parse(System.Console.ReadLine());

int[] CreateArray(int length, int min, int max) {
    int[] array = new int[length];
    Random random = new Random();
    for (int i = 0; i < length; i++) {
        array[i] = random.Next(minRange, maxRange + 1);
    }
    return array;
}

int[] array = CreateArray(arrayLength, minRange, maxRange);
System.Console.WriteLine($"созданный массив: [{System.String.Join(", ", array)}]");