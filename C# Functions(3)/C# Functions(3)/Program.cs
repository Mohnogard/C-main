namespace C__Functions_3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int switchcase = int.Parse(Console.ReadLine());

            switch (switchcase)
            {
                case 1:
                    static int Add (int x, int y)
                    {
                        return x + y;
                    }
                    Console.WriteLine(Add(10, 20));
                    break;
                case 2:
                    static double TrailLead (float x)
                    {
                        return (double)(x);
                    }
                    Console.WriteLine(010.02010);
                    break;
                case 3:
                    static int secondLargest(int[] arr)
                    {
                        var ordered = arr.OrderByDescending(x => x).ToArray();
                        return (int)(ordered[1]);
                    }
                    int[] testing = { 1, 2, 4, 3, 5 };
                    Console.WriteLine(secondLargest(testing));
                    break;
                case 4: ///////////
                    static bool isRepdigit(int number)
                    {
                        if (number < 0)
                        {
                            return (false);
                        }
                        else
                        {
                            return (true);
                        }
                    }
                    break;
                case 5:
                    static string reverseWords(string words)
                    {
                        return string.Join(" ",
                         words.Split(' ').Reverse());
                    }
                    Console.WriteLine(reverseWords("The Sky is blue"));
                    break;

                case 6:  ////////////
                    static string findSeven(int[] nums)
                    {
                        bool hasSeven = nums.Any(x => x == 7);
                        if (hasSeven)
                        {
                            return ("Boom!");
                        } else
                        {
                            return "there is no 7 in the array";
                        }
                    }
                    int[] testing6 = { 1, 2, 3, 4, 7, 5 };
                    Console.WriteLine(findSeven(testing6));
                    break;

                //case 7: ///////////////
                //    static void insertWhiteSpace(string text)
                //    {
                //        text.ToArray();
                //        if 
                //    }
                case 8:
                    static int countTrue(bool[] test)
                    {
                        return test.Count(x => x==true);

                    }
                    bool[] testing8 = { true, false, true, true };
                    Console.WriteLine(countTrue(testing8));
                    break;
                case 9:
                    static string capToFront(string s)
                    {
                         s.Order();
                    }
                case 10:

                case 11:

                case 12:

                case 13:

                case 14:

                case 15:

                case 16:
                    break;
            }
        }
    }
}
