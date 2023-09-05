// Задача №0 
// Напишите программу, которая на вход принимает число и
// выдает его квадрат (число умноженное на само себя).

Console.WriteLine("Введите число: ");
//Считывает даннные с консоли
string? inputNum = Console.ReadLine();//??"0";
//Проверяем, чтобы данные были не пустыми
if (inputNum != null)
{
    //  //Просим введите число
    //  int num = int.Parse(inputNum);
    // //Находим квадрат числла
    //  int res = num*num;
    // //Выводим данные в консоль
    //  Console.WriteLine(res);

    Console.WriteLine("Квадрат числа: " + (int)Math.Pow(int.Parse(inputNum), 2));
}

