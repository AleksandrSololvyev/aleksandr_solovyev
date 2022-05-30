 //Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//-1, -7, 567, 89, 223-> 3
Console.Write("Введите числа через пробел: ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);// split = convert all symbols in line
int NumOver0 = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        NumOver0++;
    }
}
Console.WriteLine($"Чисел больше нуля: {NumOver0}");

