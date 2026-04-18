using System;
using System.Globalization;

namespace C__Functions_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int cases = int.Parse(Console.ReadLine());
            switch (cases)
            {
                case 1:
                    static int GetDays(string date1, string date2)
                    {
                        DateTime d1 = DateTime.Parse(date1);
                        DateTime d2 = DateTime.Parse(date2);

                        return Math.Abs((d2 - d1).Days);
                    }
                    break;
                case 2:
                    static string[] stringnum(string[] arr)
                    {
                        return arr
                            .Where(s => s.Any(char.IsDigit))
                            .ToArray();
                    }
                    string[] testing = {"1a","2", "a", "b", "c"};
                    Console.WriteLine(string.Join(", ", stringnum(testing)));
                    break;
                case 3:
                    static string ReverseOddWords(string sentence)
                    {
                        return string.Join(" ",
                            sentence
                                .Split(' ')
                                .Select(word =>
                                    word.Length % 2 != 0
                                        ? new string(word.Reverse().ToArray())
                                        : word
                                )
                        );
                    }
                    string testing3 = "Hello dude how are you";
                    Console.WriteLine(ReverseOddWords(testing3));
                    break;
                case 4:
                    static bool IsPandigital(long num)
                    {
                        string s = num.ToString();

                        return "0123456789"
                            .All(d => s.Contains(d));
                    }
                    break;
            }
        }
    }
}
