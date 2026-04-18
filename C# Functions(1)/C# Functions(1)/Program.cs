using System.Security.Cryptography;

namespace C__Functions_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int SwitchCase = int.Parse(Console.ReadLine());
            Console.WriteLine("Hello, World!");

            switch (SwitchCase)
            {
                case 1:
                    
                    static void toseconds(int minutes)
                    {
                        Console.WriteLine(minutes * 60);
                    }
                    int test1 = int.Parse(Console.ReadLine());
                    toseconds(test1);
                    break;

                case 2:
                    static int increment (int number)
                    {
                        return number + 1;
                    }
                    Console.WriteLine(increment(1));
                    break;

                case 3:
                    static int retfirst(int[] numbers)
                    {
                        return numbers[0];
                    }
                    int[] testarr3 = { 1, 2, 3, 2, 1 };
                    Console.WriteLine(retfirst(testarr3));
                    break;

                case 4:
                    static int area(int width, int height)
                    {
                        return width * height;
                    }
                    Console.WriteLine(area(2, 4));
                    break;

                case 5:
                    static int[] evenNumbersEvenIndex(int[] numbers)
                    {
                        List<int> numbers1 = new List<int>();
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            if(i%2==0 && numbers[i] % 2 == 0)
                            {
                                numbers1.Add(numbers[i]);
                            }
                        }
                        return (numbers1.ToArray());
                    }
                    
                    int [] nums = { 5, 2, 2, 1, 8, 66, 55, 77, 34, 9, 55, 1 };

                    Console.WriteLine(string.Join(", ", evenNumbersEvenIndex(nums)));
                    break;
                case 6:
                    static string[] evenIndexOddLength(string[] strings)
                    {
                        List<string> strings1 = new List<string>();
                        for (int i = 0; i < strings.Length; i++)
                        {
                            if (i % 2 == 0 && strings[i].Length%2 != 0)
                            {
                                strings1.Add(strings[i]);
                            }
                        }
                        return (strings.ToArray());
                    }

                    string[] strings = { "alex", "mercer", "madrasa", "rashed2", "emad", "hala" };

                    Console.WriteLine(string.Join(", ", evenIndexOddLength(strings)));
                    break;
                case 7:
                    static int[] powerElementIndex(int[] nums)//5 4 3 2 3
                    {
                        List<int> powers = new List<int>();
                        
                        for (int i = 0; i < nums.Length;i++)
                        {
                            int powered = 1;
                            for (int j = 0; j<i; j++)
                            {
                                powered*= nums[i];
                            }
                            if (i == 0)
                            {
                                powered = 1;
                            }
                            powers.Add(powered);
                        }

                        return ((powers.ToArray()));
                    }
                    int[] test7 = { 44, 5, 4, 3, 2, 10 };
                    Console.WriteLine(string.Join(", ", powerElementIndex(test7)));

                    break;
                case 8:
                    static int multiplication2(int[] nums)//5 4 3 2 3
                    {
                        int multiplied = nums[0];
                        for (int i = 1; i < nums[1]; i++)
                        {
                            multiplied += nums[0];
                        }
                        return (multiplied);
                    }

                    int[] test8 = { 2,6 };
                    Console.WriteLine((multiplication2(test8)));
                    break;
                case 9:
                    static int multi2(int[] nums)//2 5
                    {
                        int multiplied = nums[0];
                        for (int i = nums[0]; i < nums[1]; i++)
                        {
                            nums[0] += 1;
                            multiplied *= nums[0];
                            
                        }
                        return (multiplied);
                    }

                    int[] test9 = { 3,6 };
                    Console.WriteLine((multi2(test9)));
                    break;
                case 10:
                    static double aveArray(int[] nums)
                    {
                        return (nums.Average());
                    }
                    int[] testarr = { 1, 2, 3, 8, 9};
                    Console.WriteLine(aveArray(testarr));
                    break;
            }
        }
    }
}