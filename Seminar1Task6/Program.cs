// Задача 6:
// Напишите программу, которая на вход принимает число
// и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// internal class Program
// static void Main(string[]args)
Console.Write("Введите число: ");
int numOddOrEven=Convert.ToInt32(Console.ReadLine());
if (numOddOrEven % 2 ==0)
{
    Console.WriteLine("Число {0} четное", numOddOrEven);
}
else 
{
    Console.WriteLine("Число {0} нечетное", numOddOrEven);
}