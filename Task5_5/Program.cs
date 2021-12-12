using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_5
{
    class Program
    {
        static void Main()
        {
        
                    Console.WriteLine("Введите количество N строк и столбцов массива ");
            int N = Convert.ToInt32(Console.ReadLine());

            int[,] array = new int[N, N];


            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    array[i, j] = 1 - (i + j) % 2;
                    Console.Write(array[i, j] + " ");
                }
                
                Console.WriteLine();
                
            }
            Console.ReadKey();
        }
    }
}
