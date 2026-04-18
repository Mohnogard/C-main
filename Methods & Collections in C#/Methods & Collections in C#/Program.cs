using System.Linq;
namespace Methods___Collections_in_C_
{
    internal class Program
    {

        static int CalculateAverage(int a, int b, int c)
        {
            return ((a + b + c) / 3);
        }

        static void second()
        {
            List<string> names = new List<string>();
            names.Add("Ahmad");
            names.Add("Sara");
            names.Add("mohammad1");
            names.Add("mohammad2");
            names.Add("mohammad3");
            foreach (string n in names)
            {
                Console.WriteLine(n);
            }
            names.Remove("Ahmad");
            Console.WriteLine();
            foreach (string n in names)
            {
                Console.WriteLine(n);
            }
        }

        static void third()
        {
            Console.WriteLine("Welcome!");
        }

        static string fourth(string n)
        {
            return ($"Hello {n}");
        }

        static int fifth(int age = 5)
        {
            return (age + 1);
        }

        static int sixth(int a, int b)
        {
            return (a + b);
        }
        static void seventh(string[] args)
        {

            foreach (string n in args)
            {
                Console.Write(n + " ");
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            /*  Task 1 – Method
            Console.WriteLine(CalculateAverage (1, 2, 3));
            */


            /*  Task 2 – List
            second();
            */


            /*  Task 3 – Dictionary
            Dictionary<int, string> students = new Dictionary<int, string>();

            students.Add(1, "Ali");
            students.Add(2, "Omar");
            students.Add(3, "Aliiii");
            foreach (int n in students.Keys)
            {
                Console.WriteLine($"{students[n]}");
            }
            */


            /*  Task 4 – LINQ
            int[] numbers = { 5, 10, 15, 20, 25, 30 };
            string[] names = { "Ahmad", "Ali", "Sara", "Mona", "Omar" };

            var result0 = numbers.Where(n => n > 15);
            var result1 = numbers.Where(n => n % 2 == 0);
            var result2a = numbers.OrderBy(n => n);
            var result2b = numbers.OrderBy(n => -n);
            var result3 = names.Contains("A");
            var result4 = numbers.FirstOrDefault(n => n > 10);
            var optional = numbers.Select(n => n * 2); 
            foreach (var num in optional)
            {
                Console.WriteLine(num);
            }
            */

           

            third();

            string a = fourth("ahmad");
            Console.WriteLine(a);
            Console.WriteLine();

            int b = fifth(); //default value
            Console.WriteLine(b);
            Console.WriteLine();
            int c = fifth(2); // custom value
            Console.WriteLine(c);
            Console.WriteLine();

            int d = sixth(1, 2);
            Console.WriteLine(d);
            Console.WriteLine();

            seventh(["h", "e", "l", "l", "o"]);

        }

    }
}