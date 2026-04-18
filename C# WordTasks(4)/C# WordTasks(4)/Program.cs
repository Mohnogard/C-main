using System.Linq;

namespace C__WordTasks_4_
{
    class cuber
    {
        public int baseNum = 1;
        public void cubeNums(int x)
        {
            for (int i = 1; i <= x; i++)
            {
                baseNum = i;
                for (int j = 1; j < 3; j++)
                {
                    baseNum *= i;
                }
                Console.WriteLine($"Number is: {i} and its cube is: {baseNum}");
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
                    case 1:
                        static void sumAndAvg(int[] nums)
                        {
                            double average = nums.Average(x=>x);
                            int sums = (int)nums.Sum(x=>x);
                            Console.WriteLine($"the sum is {sums}");
                            Console.WriteLine($"Theaverage is {average}");

                        }
                        int[] test = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                        sumAndAvg(test);
                        break;
                    case 2:
                        cuber obj = new cuber();
                        obj.cubeNums(5);
                        break;

                    case 3:
                        static string getYears(int[] years)
                        {
                            string text = string.Join(", ", years.Where(x => x > 1950));
                            return text;
                        }
                        int[] years = { 1988, 1999, 1800, 1950 };
                        Console.WriteLine(getYears(years));
                        break;
                    case 4:
                        static int toDays(int inYears)
                        {
                            return inYears * 365;
                        }
                        Console.WriteLine(toDays(50));
                        break;
                    case 5:
                        static int animals(int chickens, int cows, int pigs)
                        {
                            return (chickens * 2 + cows * 4 + pigs * 4);
                        }
                        Console.WriteLine(animals(2, 3, 5));
                        break;
                    case 6:
                        static string successful(string user, string pass)
                        {
                            string userone = "mohammad";
                            string passone = "1234321";
                            string usertwo = "rahma";
                            string passtwo = "R@hm@315";
                            return ("us");
                        }
                        break;
                    case 7:
                        static void powers (int number)
                        {
                            Console.WriteLine(number*number);
                        }
                        powers(12);
                        break;
                    case 8:
                        static string leapYear (int year)
                        {
                            if (year <=1900 && year >= 2024 && year%400==0)
                            {
                                return "is a leap year";
                            }
                            else
                            {
                                return "not a leap year";
                            }
                        }
                        break;
                    case 9:
                        static bool IsPrime(int n)
                        {
                             if (n <= 1) return false;
                             for (int i = 2; i < n; i++)
                             {
                                if (n % i == 0) return false;
                             }
                            return true;
                         }
                      break;
                    case 10:
                        static int retWord(string word)
                        {
                            string[] splitted = word.Split(' ');
                            return(splitted.Length);
                        }
                        Console.WriteLine(retWord("Hello how are you"));
                        break;
                }
                
            }
        }
    }
}
