// №13 Напишите программу,
// которая выводит третью цифру заданного числа или
// сообщает, что третьей цифры нет.


Console.WriteLine("Введите первое число");
int ran = Convert.ToInt32(Console.ReadLine());
char[] digitChar = ran.ToString().ToCharArray();
System.Console.Write(digitChar[2]);
