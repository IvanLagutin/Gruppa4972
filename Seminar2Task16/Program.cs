﻿// Задача №16
// Напишите программу, которая принимает на вход два
// числа и проверяет, является ли одно число квадратом другого.

Console.WriteLine("Введите число");

int numA = int.Parse (Console.ReadLine()??"0");
int numB = int.Parse (Console.ReadLine()??"0");
bool test1 = (numA==numB*numB);
bool test2 = (numB== numA*numA);

if (test1) Console.WriteLine("Первое квадрат второго");
if (test2) Console.WriteLine ("Втрое квадрат первого");
if (!(test1||test2))
{
    Console.WriteLine ("Числа не квадраты друг друга");
}