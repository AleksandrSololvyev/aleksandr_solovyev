 /*
 Напишите программу, которая принимает на вход 
 пятизначное число и проверяет, является ли оно 
 палиндромом.
 */
 int a;
 Console.WriteLine("Введите пятизначное число");
 a = Convert.ToInt32(Console.ReadLine());
 if (a < 100000 && a > 9999)
 {
 if (a / 10000 == a % 10 && a / 1000 % 10 == a / 10 % 10)
  {
  Console.WriteLine("палиндром");
 }
 else{ 
     Console.WriteLine("не палиндром");
 }
 }
 else{
     Console.WriteLine("Число не пятизначное");
 }
