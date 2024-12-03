// задача 1
using System;

Console.Write("введте трехзначное число: ");
int result = int.Parse(Console.ReadLine());

if (result < 100 || result > 999) {
    Console.WriteLine("должно быть трехзначное число");
    return;
}
int number = result / 10 % 10;
Console.WriteLine($"вторая цифра {number}");

// задача 2
Console.Write("введте число: ");
int num1 = int.Parse(Console.ReadLine());

if (num1 < 100) {
    Console.WriteLine("третьей цифры нет");
    return;
}
while (num1 > 999) {
    num1 /= 10;
}

Console.WriteLine($"третья цифра -> {num1 % 10}");

// задача 3
Console.Write("введте день недели: ");
int num_day = int.Parse(Console.ReadLine());

if (num_day > 0 && num_day < 8) {
    if (num_day > 5) {
        Console.WriteLine("выходной");
    } else {
        Console.WriteLine("не выходной");
    }
} else {
    Console.WriteLine("некоректный день");
}