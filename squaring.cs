 //Напишите цикл, который принимает на вход два числа 
 //(A и B) и возводит число A в натуральную степень B.
 // 3, 5 -> 243 (3⁵)
 //2, 4 -> 16
 int result, i;
Console.WriteLine("Введите число, которое хотите возвести в степень");
 int number = int.Parse(Console.ReadLine());
 Console.WriteLine("Введите степень этого числа");
 int degree = int.Parse(Console.ReadLine());
 result = number;
 for (i = 1; i < degree; i++)
{
 result = result * number;
}
{
 Console.WriteLine($"Полученное число: {result}");
}

