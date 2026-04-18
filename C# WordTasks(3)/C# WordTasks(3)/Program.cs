using System.Linq;

namespace C__WordTasks_3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.
            //string[] ARR = ["1", "7 9 5"]
            //int[] arr2 = [numbers]
            //string arr3 = ["the", "fox", "over lazy", "dog"]

            //2.
            //1, 0

            //3.
            //string[] favefood = ["apple", "orange", "plum", "melon", "kiwi"]
            //string favesport = ["football", "hockey", "tennis"]
            //string favemovie = ["scream", "interstellar", "Godfather", "scarface"]
            //foreach (string n in array)
            //            {
            //                console.WriteLine(n)
            //}
            //            for (int i = 0; i < array.length; i++)
            //            {
            //                console.Write(array[i]);
            //            }


            Console.Write("Input three numbers separated by comma: ");
            string input = Console.ReadLine();

            int sum = input.Split(',')
                           .Select(int.Parse)
                           .Sum();

            Console.WriteLine("The sum of three numbers: " + sum);

            ///
            int sum = 0;

            Console.WriteLine("The odd numbers are:");

            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + " ");
                    sum += i;
                }
            }

            Console.WriteLine();
            Console.WriteLine("The Sum of odd Numbers is: " + sum);

            //6.in 30's
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

            //7.in 30's
            int rows = 4;
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
