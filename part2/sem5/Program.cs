using System;
using static System.Console;

Clear();

Write("enter a num: ");
int a = int.Parse(ReadLine());
Write("enter b num: ");
int b = int.Parse(ReadLine());

if (b*b == a) {
    WriteLine("the num a is the square of the num b");
} else {
    if (Math.Pow(a, 2) == b) {
        WriteLine("the num b is the square of the num a");
    } else {
        WriteLine("not a square");
    }
}