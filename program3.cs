/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
int a;
Console.WriteLine("Введите цифру");
a = Convert.ToInt32(Console.ReadLine());
if (a <= 5 || a > 7)/*цифры от 0 до 9*/
{
    Console.WriteLine("нет");
}
else 
{
    Console.WriteLine("да");
}