using System;
using static System.Console;

Clear();
int number = new Random().Next(100, 1000);

int a1 = number / 100;
int a2 = number % 10;

Console.WriteLine($"{number}->{a1*10 + a2}");