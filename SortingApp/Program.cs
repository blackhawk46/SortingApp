using System;

namespace SortingApp
{
    class Program
    {
        static void Main()
        {
            int n = 0;

            Console.WriteLine("Enter the number of elements in the array from 2 to 100");

            while (n==0)
            {
                Int32.TryParse(Console.ReadLine(), out n);
                if (n > 100 || n < 2)
                {
                    n = 0;
                    Console.WriteLine("Wrong input... try again");
                }
            }

            int[] array = new int[n];

            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(1, 999);
            }

            Console.WriteLine("Unsorted:");

            foreach (int i in array)
            {
                Console.Write("{0} ", i);
            }

            BubbleSort(array);

            Console.WriteLine("\nSorted:");

            foreach (int i in array)
            {
                Console.Write("{0} ", i);
            }

            void BubbleSort(int[] numbers)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    for (int j = i + 1; j < numbers.Length; j++)
                    {
                        if (numbers[i] > numbers[j])
                        {
                            int tmp = numbers[i];
                            numbers[i] = numbers[j];
                            numbers[j] = tmp;
                        }
                    }
                }
            }

             Console.ReadKey();
        }
    }
}
