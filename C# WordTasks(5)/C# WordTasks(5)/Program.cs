using C__WordTasks_5_;
using System.Globalization;
namespace C__WordTasks_5_
{
    public class MyClass
    {
        static void Init()
        {
            Console.WriteLine("MyClass class has initialized!");
        }
    }

    public class Class2
    {
        public string name = "Scott";

        public void writename(string s)
        {
            Console.WriteLine($"{s} {name}");
        }
    }
      
    public class Factorial
    {   
        public void factorial(int num)
        {
            int count = num;
            for (int i = 1; i < num; i++)
            {
                count *= i;
            }
            Console.WriteLine(count);
        }
    }
    public class sorter
    {
        public void sorterArr(int[] arr)
        {
            Array.Sort(arr);
            int[] updated =(arr);
            Console.WriteLine($"Sorted array: [{string.Join(", ", arr)}]");
        }
    }

    public class DateDifferenceCalculator
    {
        public void GetDifference(DateTime date1, DateTime date2)
        {
            if (date2 < date1)
            {
                DateTime temp = date1;
                date1 = date2;
                date2 = temp;
            }

            int years = date2.Year - date1.Year;
            int months = date2.Month - date1.Month;
            int days = date2.Day - date1.Day;

            if (days < 0)
            {
                months--;
                days += DateTime.DaysInMonth(date2.AddMonths(-1).Year, date2.AddMonths(-1).Month);
            }

            if (months < 0)
            {
                years--;
                months += 12;
            }

            Console.WriteLine($"Difference: {years} years, {months} months, {days} days");
        }
    }

}
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        int switchcase = int.Parse(Console.ReadLine());

        switch (switchcase)
        {
            case 2:
                Class2 obj1 = new Class2();
                obj1.writename("Hello my name is");
                break;

            case 3:
                Factorial obj2 = new Factorial();
                obj2.factorial(5);
                break;

            case 4:
                sorter obj4 = new sorter();
                int[] testarr = { 1, 2, 3, -1, 0 };
                obj4.sorterArr(testarr);
                break;

            case 5:
                break;

            case 6:
                string dateString = "12-08-2004";

                // format is d-M-yyyy because '-' means day-month-year
                DateTime date = DateTime.ParseExact(
                    dateString,
                    "dd-MM-yyyy",
                    CultureInfo.InvariantCulture
                );

                Console.WriteLine($"Converted Date: {date:yyyy-MM-dd}");

                break;
        }
        }
    }

