//Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
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
         int GetMinNumber(int[] arr)
        {
            int min = 0;
            for (i = 0; i < arr.Length; i++)
            {
              if (arr[i] < min) min = arr[i];
            }
            return min;
        }
        int GetMaxNumber(int[] arr)
        {
            int max = 0;
            for (i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max) max = arr[i];
            }
            return max;
        }
        int GetDif(int[] arr)
        {
               int dif = 0;
               {
                   dif = (arr.Max() - arr.Min());
               }
               return dif;
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
        int min = GetMinNumber(arr);
        Console.WriteLine();
        int max = GetMaxNumber(arr);
         Console.WriteLine();
        int dif = GetDif(arr);
        Console.WriteLine($"Разница между максимальным и минимальным элементов массива: {dif}");
    }
}