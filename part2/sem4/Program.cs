using System;
using static System.Console;

Clear();

Write("input first num: ");
int number = int.Parse(ReadLine());


if (( number % 7 == 0) && (number % 23 == 0)) {
    WriteLine($"{number}->yes");
} else {
    WriteLine($"{number}->no");
}