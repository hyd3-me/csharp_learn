using System;
using static System.Console;

Clear();

Write("input first num: ");
int a = int.Parse(ReadLine());
Write("input second num: ");
int b = int.Parse(ReadLine());

if (a % b == 0) {
    WriteLine("Кратно");
} else {
    WriteLine($"Не кратно {a % b}");
}