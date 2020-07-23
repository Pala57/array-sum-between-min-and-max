using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            bool f;
            do
            {
                Console.WriteLine("Ввести N= ");
                f = int.TryParse(Console.ReadLine(), out N);
                if (!f)
                {
                    Console.WriteLine("Помилка введіть ще раз");
                }
            } while (!f);
            int[] arr = new int[N];

            int min = int.MaxValue;
            int index = 0;
            int sum = 1;
            Random rnd = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-5, 8);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(" " + arr[i]);
            }
            int index1 = 0;
            int index2 = 0;
            int sum2 = 0;
            bool k = true;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    index1 = i;
                    break;
                }
            }
            for (int i = index1; i < arr.Length; i++)
            {
                k = true;
                if (arr[i] > 0)
                {
                    k = false;
                    i++;
                    if (arr[i] > 0)
                    {
                        k = true;
                        index2 = i;
                        break;
                    }

                }

            }

            Console.WriteLine("\tиндекс 1 = " + index1 + "\tиндекс 2 = " + index2);

            for (int i = index1; i <= index2; i++)
            {
                sum2 += arr[i];
            }
            Console.WriteLine("\nСума = " + sum2);
            Console.ReadKey();
        }




    }

}
