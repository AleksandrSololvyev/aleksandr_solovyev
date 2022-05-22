/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
int a;
Console.WriteLine("Введите число");
a = Convert.ToInt32(Console.ReadLine());
if (a > 99)
{
while (a >= 1000) 
{
    a = (a / 10);
}
a = (a % 10);
Console.WriteLine(a);
}
else 
{
Console.WriteLine("третьей цифры нет");
}
