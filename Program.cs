using System;

namespace Lab_task
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 5;
            int[size] arr;
            Console.WriteLine("input numbers: ");
            for (int i=0;i<size;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < 5; i++)
            { 
                Console.WriteLine (arr[i]);
            }
        }
    }
}
