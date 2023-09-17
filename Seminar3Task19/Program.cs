// №19 Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.


using System;

public class Answer
{
    static bool IsPalindrome(int number){
      // Введите свое решение ниже
      string num = Convert.ToString(number);

if (num.Length != 5)
{
Console.WriteLine("Число не пятизначное");
return false;
}
else if (num[0] == num[4] && num[1] == num[3]) return true;
else return false;
    }
  
  // Не удаляйте и не меняйте метод Main! 
      static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 64546;
        }

        // Не удаляйте строки ниже
        bool result = IsPalindrome(number);
        System.Console.WriteLine($"{result}");
    }
}