using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_4
{ 
    class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
                Console.WriteLine("\n-------------------------------------------------------");
                Console.WriteLine("******* программа сортировки рандомного массива ******");
                Console.WriteLine("\n-------------------------------------------------------");
                int[] array = new int[20];
            int summ = 0;
            Random rand = new Random();
            Console.WriteLine("создаем рандомный массив\n");
            for (int i = 0; i < 20; i++)
            {
                array[i] = rand.Next(-5, 21);
                Console.Write(array[i]);
                Console.Write("\t");
            }
            Console.WriteLine("\n----------------------");
            Console.WriteLine("сортируем созданный массив");
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20 - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int z = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = z;
                    }
                }
            }
            Console.WriteLine("\n----------------------");
            Console.WriteLine("выводим сортированный массив\n");
            for (int i = 0; i < 20; i++)
            {
                Console.Write(array[i]);
                Console.Write("\t");
                summ = summ + array[i];
            }
            Console.WriteLine("\n----------------------");
            Console.WriteLine("\nсумма чисел массива ровна: " + summ);
            Console.ReadKey();
        }
    }
}
}