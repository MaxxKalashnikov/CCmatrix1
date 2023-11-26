using System;

namespace ЛБ6_ЗД2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White; 
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black; 
            Console.Clear();
            Console.Write("Введите желаемое количество строк: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите желаемое количество столбцов: ");
            int m = Convert.ToInt32(Console.ReadLine());           
            int[,] arr = new int[n, m];
            int[] sum = new int[1000];
            Random random = new Random();
            // Заполнение массива
            for (int row = 0; row < n; row++)
                for (int col = 0; col < m; col++)
                    arr[row, col] = random.Next(51); // от 0 до 51
            // Вывод массива на экран
            Console.WriteLine("/////////////////////////////////");
            Console.WriteLine("Исходная матрица:");
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                    Console.Write(arr[row, col] + "\t");
                Console.WriteLine();
            }
            Console.WriteLine("/////////////////////////////////");
            // Счет суммы каждой строки 
            for (int row = 0; row < n; row++)
            {
                sum[row] = 0;
                for (int col = 0; col < m; col++)
                {
                    sum[row] += arr[row, col];
                }
                Console.WriteLine("Сумма " + (row + 1) + "-ой строки равна: " + sum[row]);
            }            
            //Сортировка строк 
            for (int row = 0; row < n - 1; row++)
                for (int k = row + 1; k < n; k++)
                    if (sum[row] > sum[k])
                    {
                        for (int j = 0; j < n; j++)
                        {
                            int q = arr[row, j];
                            arr[row, j] = arr[k, j];
                            arr[k, j] = q;
                        }
                    }
            // Вывод измененной матрицы
            Console.WriteLine("/////////////////////////////////");
            Console.WriteLine("Измененная матрица:");
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                    Console.Write(arr[row, col] + "\t");
                Console.WriteLine();
            }
            Console.ReadKey(true);
        }
    }
}
