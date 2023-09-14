// Задача №18
// Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y).

// 1) ввести номер четверти
// 2) ответить на вопрос
// 3) вывести результат


int getQurter()
{
    Console.Write("Введите номер четверти: ");
    return Convert.ToInt32(Console.ReadLine());
}
//Вводим данные
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine()?? "0");
    return num;
}

string pointsIdent(int quarterNum)
{
    if (quarterNum == 1) return "Возможные значения: x>0, y>0";
    if (quarterNum == 2) return "Возможные значения: x<0, y>0";
    if (quarterNum == 3) return "Возможные значения: x<0, y<0";
    if (quarterNum == 4) return "Возможные значения: x>0, y<0";
    return "Неверное значени";
}
int quarterNum= getQurter();
Console.WriteLine(pointsIdent(quarterNum));
