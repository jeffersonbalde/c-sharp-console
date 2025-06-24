using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //char initial = 'S';
            //string first_name = "Jefferson";
            //string last_name = "Balde";

            //string message = $"Hello {first_name} {initial} {last_name}";


            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 5; j >= i; j--)
            //    {
            //        Console.Write(i + " ");
            //    }
            //    Console.WriteLine();
            //}


            //int x;
            //int sum = 0;

            //Console.Write("Input no. \n");
            //x = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= x; i++)
            //{
            //    sum += i;
            //}


            //int n;
            //int sum = 0;

            //Console.Write("Enter n: ");
            //n = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= n; i++)
            //{
            //    sum += i;
            //}

            //Console.WriteLine(sum);

            //int n;
            //int sum = 0;

            //while (true)
            //{
            //    Console.Write("Enter n: ");
            //    if (int.TryParse(Console.ReadLine(), out n))
            //        break;
            //    Console.WriteLine("Invalid");
            //}

            //for(int i = 1; i <= n; i++)
            //{
            //    sum += i;
            //}

            //Console.WriteLine(sum);



            var greetings = new GreetingPrinter();
            greetings.PrintGreetings();

            Console.WriteLine();

            var printPattern = new DescendingStarPattern();
            printPattern.PrintPattern();


            

            //Console.WriteLine("Sum of first " + x + " natural numbers is: " + sum);


            //Console.WriteLine(message);


            //int sum = 10;
            //int result = 1;

            //for (int i = 0; i < 5; i++)
            //{
            //    result *= sum;
            //}
            //Console.WriteLine("10 multiplied 5 times is " + result);


            //int[] arr = new int[20] { 1, 2, 3, 4, 5, 1, 6, 1, 0, 2, 3, 1, 4, 1, 2, 2, 3, 1, 1, 2 };

            //int sum = 0;
            //foreach (int num in arr)
            //{
            //    sum += num;
            //}

            //Console.WriteLine("Total sum of array is: " + sum);

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = i + 1; j < arr.Length; j++)
            //    {
            //        if (arr[i] + arr[j] == 7)
            //        {
            //            Console.WriteLine($"Pair found: {arr[i]}, {arr[j]} at indices {i}, {j}");
            //        }
            //    }
            //}

            Console.ReadLine();
        }
    }
}
