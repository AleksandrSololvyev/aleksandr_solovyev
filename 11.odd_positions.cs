//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

internal class Program
{
    private static void Main(string[] args)
    {
        int i;
        int[] InitArray(int length)
        {
            int[] arr = new int[length];
            Random rnd = new Random();
            for (i = 0; i < length; i++)
            {
                arr[i] = rnd.Next(0, 20);
            }

            return arr;
        }
        int GetSummOfNumbersOnOddPositions(int[] arr)
        {
            int summ = 0;
            for (i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0)
                summ = summ + arr[i];
            }
            return summ;
        }
        void PrintArray(int[] arr)
        {
            foreach (int item in arr)
                Console.Write($"{item} ");
        }
        Console.WriteLine("Введите размерность массива:");
        int length = int.Parse(Console.ReadLine());
        int[] arr = InitArray(length);
        Console.WriteLine("Полученный массив:");
        PrintArray(arr);
        int summ = GetSummOfNumbersOnOddPositions(arr);
        Console.WriteLine();
        Console.WriteLine($"Сумма чисел на нечётных позициях: {summ}");
    }
}