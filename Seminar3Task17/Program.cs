// Задача №17
// Напишите программу, которая принимает на вход координаты точки (X и Y),
// причем X не равен 0 и Y не равен 0 и выдает номер четверти плоскости, 
// в которой находится эта точка.

// 1) ввести X
// 2) ввести Y
// 3) поиск ответа 
// 4) вывести результат

//Вводим данные
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}
//По координатам точки определяем номер четверти
int QurerTest(int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 1;
    if (x < 0 && y < 0) return 1;
    if (x > 0 && y < 0) return 1;
    return 0;
}
//Печатаем результат
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}
int x = ReadData("Введите координату X: ");
int y = ReadData("Введите координату Y: ");

int res = QurerTest(x,y);
PrintResult("Точка находится в четверти № "+res);