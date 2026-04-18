namespace C__WordTasks_2_
{
    class compares
    {
        public void Compare(int x, int y)
        {
            if (x < y)
            {
                Console.WriteLine(y);
            }
            else
            {
                Console.WriteLine(x);
            }
        }
    }
    class kmtomph
    {
        public void toConvert(double x)
        {
            Console.WriteLine(x* 0.621371);
        }
    }
    class totalMinutes
    {
        public void sumTime(int x, int y)
        {
            Console.WriteLine(x * 60 + y);
        }
    }
    class totalTime
    {
        public void Time(int x)
        {
            int hours = x / 60;
            int minutes = x % 60;

            Console.WriteLine($"{hours} Hours, {minutes} Minutes");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            int switchcase = int.Parse(Console.ReadLine());

            switch (switchcase)
            {
                case 1:
                    compares obj = new compares();
                    obj.Compare(7, 5);
                    break;

                case 2:
                    int num = int.Parse(Console.ReadLine());

                    if (num > 0)
                        Console.WriteLine("The sign is +");
                    else if (num < 0)
                        Console.WriteLine("The sign is -");
                    else
                        Console.WriteLine("The number is 0");
                    break;
                case 3:
                    int a = 0, b = -1, c = 4;

                    int first, second, third;

                    if (a <= b && a <= c)
                    {
                        first = a;
                        if (b <= c) { second = b; third = c; }
                        else { second = c; third = b; }
                    }
                    else if (b <= a && b <= c)
                    {
                        first = b;
                        if (a <= c) { second = a; third = c; }
                        else { second = c; third = a; }
                    }
                    else
                    {
                        first = c;
                        if (a <= b) { second = a; third = b; }
                        else { second = b; third = a; }
                    }

                    Console.WriteLine($"{first}, {second}, {third}");
                    break;
                case 4:
                    int[] nums = { -5, -2, 0, 3, 1 };
                    int max = nums[0];
                    for (int i=0; i < nums.Length; i++)
                    {
                        if (nums[i] > max)
                        {
                            max= nums[i];
                        }
                    }
                    Console.WriteLine(max);
                    break;
                case 5:
                    kmtomph obj5 = new kmtomph();
                    obj5.toConvert(015);
                    break;
                case 6:
                    totalMinutes obj6 = new totalMinutes();
                    obj6.sumTime(5, 37);
                    break;
                case 7:
                    totalTime obj7 = new totalTime();
                    break;
                case 8:
                    string[] sentences ={ "Hello","this is a large one","C#",
                        "trying to fix","Hi"};

                    int fixedLength = 30;

                    foreach (string s in sentences)
                    {
                        Console.WriteLine(s.PadRight(fixedLength, '-'));
                    }
                    break;

                case 9:
                    string input = "One two three four";

                    string[] words = input.Split(' ');

                    for (int i = 0; i < words.Length; i++)
                    {
                        if (words[i].Length % 2 != 0)
                        {
                            char[] chars = words[i].ToCharArray();
                            Array.Reverse(chars);
                            words[i] = new string(chars);
                        }
                    }

                    string result = string.Join(" ", words);
                    Console.WriteLine(result);
                    break;

            }
        }
    }
}

