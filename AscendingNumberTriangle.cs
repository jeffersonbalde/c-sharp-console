using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    internal class AscendingNumberTriangle
    {
        public void PrintPattern()
        {

            int row;

            while (true)
            {
                Console.Write("Enter number of row: ");

                if (int.TryParse(Console.ReadLine(), out row) && row > 0)
                    break;

                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }

            // OUTPUT
            // 1
            // 2 2
            // 3 3 3
            // 4 4 4 4
            // 5 5 5 5 5
        }
    }
}
