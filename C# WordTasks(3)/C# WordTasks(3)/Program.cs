using System.Linq;

namespace C__WordTasks_3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1.
            string[] ARR = ["1", "7 9 5"]
            string[] arr2=["Str" "alex","moh"]
            string[] arr3 = ["the", "fox", "over lazy", "dog"]
            
            2.
            1, 0

            */

            //3.
            string[] favefood = ["apple", "orange", "plum", "melon", "kiwi"];
            string[] favesport = ["football", "hockey", "tennis"];
            string[] favemovie = ["scream", "interstellar", "Godfather", "scarface"];
            foreach (string n in favefood)
            {
                Console.WriteLine(n);
            }
            for (int i = 0; i < favefood.Length; i++)
            {
                Console.WriteLine(favefood[i]+ " ");
            }

            //4.
            Console.WriteLine("Input three numbers separated by comma: ");
            string input = Console.ReadLine();

            int sum = input.Split(',')
                           .Select(int.Parse)
                           .Sum();

            Console.WriteLine("The sum of three numbers: " + sum);

            ///
            int sum2 = 0;

            Console.WriteLine("The odd numbers are:");

            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i+ " ");
                    sum2 += i;
                }
            }

            Console.WriteLine("The Sum of odd Numbers is: " + sum2);

            //6.
            int rows = 3;

            for (int i = 1; i <= rows; i++)
            {
                // spaces
                for (int j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }

                // stars
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            //7.
            int rows1 = 4;
            int num = 1;

            for (int i = 1; i <= rows; i++)
            {
                // spaces
                for (int j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }

                // numbers
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(num + " ");
                    num++;
                }

                Console.WriteLine();
            }
        }
    }
}
