
using System.Collections.Generic;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace C__Task____Loops_String_Array_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Choose the task number: ");
            int taskNo = int.Parse(Console.ReadLine());

            switch (taskNo)
            {
                // ================= PATTERNS =================

                case 1:
                    int n0 = int.Parse(Console.ReadLine());
                    for (int i = 1; i <= n0; i++)
                    {
                        if (i % 2 != 0)
                            for (int j = 1; j <= i; j++) Console.Write(j);
                        else
                            for (int j = i; j > 0; j--) Console.Write(j);

                        Console.WriteLine();
                    }
                    break;

                case 2:
                    int n1 = int.Parse(Console.ReadLine());
                    for (int i = 1; i <= n1; i++)
                    {
                        for (int j = 1; j <= i; j++) Console.Write(j);
                        for (int j = i; j > 0; j--) Console.Write(j);
                        Console.WriteLine();
                    }
                    break;

                case 3:
                    int n2 = int.Parse(Console.ReadLine());
                    int level = n2;

                    for (int i = 1; i <= n2; i++)
                    {
                        for (int s = 0; s < level; s++) Console.Write(" ");

                        for (int j = 1; j < i; j++) Console.Write(j);
                        for (int j = i; j > 0; j--) Console.Write(j);

                        level--;
                        Console.WriteLine();
                    }
                    break;

                case 4:
                    int n3 = int.Parse(Console.ReadLine());
                    for (int i = 1; i <= n3; i++)
                    {
                        for (int j = 0; j < i; j++)
                            Console.Write(2 * j + 1);
                        Console.WriteLine();
                    }
                    break;

                case 5:
                    int n4 = int.Parse(Console.ReadLine());
                    int value = 1;

                    for (int i = 1; i <= n4; i++)
                    {
                        for (int j = 0; j < i; j++)
                            Console.Write(value + " ");

                        Console.WriteLine();
                        value *= 2;
                    }
                    break;

                case 6:
                    int n5 = int.Parse(Console.ReadLine());
                    for (int i = 1; i <= n5; i++)
                    {
                        if (i % 2 != 0)
                            for (int j = 1; j <= i; j++) Console.Write(j);
                        else
                            for (int j = i; j > 0; j--) Console.Write(j);

                        Console.WriteLine();
                    }
                    break;

                case 7:
                    int n7 = int.Parse(Console.ReadLine()); //4 -> 9 -> 4 -> 3 5 -> 2 6 -> 1 7
                    int level7a = n7;
                    int level7b = n7;
                    for (int i = 1; i <= n7; i++)
                    {
                        for (int j = 0; j <= n7 * 2 - 1 ; j++)
                        {
                            if (i == n7)
                            {
                                for (int k = 0; k <= n7 * 2 ; k++)
                                {
                                    Console.Write(1);
                                }
                                break;
                            }
                            if (j == level7b || j == level7a)
                            {
                                Console.Write(1);
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                        }
                        level7a--;
                        level7b++;
                        Console.WriteLine();
                    }
                    break;
                case 8:
                    int n8 = int.Parse(Console.ReadLine()); //5 -> 5 -> 0 4 -> 1 3 -> 2 2 -> 3 1 -> 4 0 
                    int level8a = 1;
                    int level8b = n8;
                    for (int i = 1; i <= n8; i++)
                    {
                        for (int j = 1; j <= n8; j++)
                        {
                            if (j == level8a || j == level8b)
                            {
                                Console.Write(i);
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                        }
                        level8a++;
                        level8b--;
                        Console.WriteLine();
                    }
                    break;
                case 9:
                    int n9 = int.Parse(Console.ReadLine());
                    int k9 = 1;
                    for (int i = 1; i <= n9; i++)
                    {

                        {
                            for (int j = 1; j <= i; j++)
                            {
                                Console.Write(k9 + " ");
                                k9++;
                            }
                        }
                        Console.WriteLine();
                    }
                    break;
                case 10:
                    int n10 = int.Parse(Console.ReadLine()); //4 -> 5 -> 4 -> 1 4 -> 1 3 -> 1 2 -> 1 n
                    int level10a = 0;
                    int level10b = n10;
                    for (int i = 0; i <= n10; i++)
                    {
                        for (int j = 1; j <= n10 + 1; j++)
                        {
                            if (i == 0)
                            {
                                continue;
                            }
                            if (i == n10)
                            {
                                for (int k = 0; k < n10 + 1; k++)
                                {
                                    Console.Write(1);
                                }
                                break;
                            }
                            if (j == 1 || j == level10a + 1)
                            {
                                Console.Write(1);
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                        }
                        level10a++;

                        Console.WriteLine();
                    }
                    break;

                // ================= ARRAYS =================

                case 11:

                case 12:

                    int[] arr = { 1, 2, 2, 1, 3, 2, 1 };

                    Dictionary<int, List<int>> positions = new Dictionary<int, List<int>>();

                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (!positions.ContainsKey(arr[i]))
                            positions[arr[i]] = new List<int>();

                        positions[arr[i]].Add(i);
                    }

                    foreach (var pair in positions)
                    {
                        List<int> posList = pair.Value;

                        if (posList.Count < 2)
                            continue;

                        int distance = posList[1] - posList[0];
                        bool valid = true;

                        for (int i = 2; i < posList.Count; i++)
                        {
                            if (posList[i] - posList[i - 1] != distance)
                            {
                                valid = false;
                                break;
                            }
                        }

                        if (valid)
                            Console.WriteLine(pair.Key);
                    }
                    break;

                case 13:
                    int[] arr13 = [1, 2, 3, 3, 4, 1, 1, 5, 5, 5];
                    int prev = arr13[0];
                    List<int[]> biglist13 = new List<int[]>();
                    int start = 0;
                    for (int i = 0; i < arr13.Length; i++)
                    {
                        if (arr13[i] != prev)
                        {
                            int[] newarr = arr13[start..i];
                            biglist13.Add(newarr);
                            start = i;
                            prev = arr13[i];
                        }

                    }
                    int[] last = arr13[start..arr13.Length];
                    biglist13.AddRange(last);

                    foreach (var chunk in biglist13)
                    {
                        Console.WriteLine("[" + string.Join(", ", chunk) + "]");
                    }
                    break;

                case 14:
                    int[] arr14 = [1, 2, 4, 3];
                    int[] arr14a = [1, 3, 4, 2];
                    for (int i = 0; i <= arr14.Length; i++)
                    {

                    }
                    break;
                case 15:
                    int[] arr15 = [1, 2, 2, 3, 1, 2]; 
                    int[] arr15a = [1, 3, 3, 1 ,2, 2, 1];
                    
                    for (int i = 0; i < arr15.Length; i++) { }
                    break;
                case 16:
                    int[] arr16 = [1, 2, 3, 3, 2,1, 5,2, 3, 6];
                    List<int> result16b = new List<int>();

                    for (int i = 0; i < arr16.Length; i++)
                    {
                        List<int> result16a = new List<int>(); // reset window

                        for (int j = i; j < arr16.Length; j++)
                        {
                            result16a.Add(arr16[j]);

                            if (j != i && arr16[i] == arr16[j])
                            {
                                if (result16b.Count == 0 || result16a.Count < result16b.Count)
                                {
                                    result16b = new List<int>(result16a);
                                }
                                break;
                            }
                        }
                    }
                    foreach (int i in result16b)
                    {
                        Console.Write(i);
                    }

                    break;
                case 17:

                case 18:

                case 19:

                case 20:

                // ================= STRINGS =================

                case 21:
                    string str21 = "aAbBccddyuyy";
                    List<char> char21list = new List<char>();
                    char storage21;
                    char prev21 = 'a';
                    foreach (char c in str21)
                        if(c == str21[0])
                        {
                            prev21 = c;
                            continue;
                        } else
                        {//aA Aa AA aa
                            if (c == (prev21))
                            {
                                //remove
                                char21list.Add(c);
                            }
                            storage21 = c;
                        }
                    char21list.ToString();
                    break;

                case 22:
                    string word22 = "Banana";
                    Dictionary<char, int> freq22 = new Dictionary<char, int>();

                    foreach (char c in word22)
                    {
                        if (freq22.ContainsKey(c))
                            freq22[c]++;
                        else
                            freq22[c] = 1;
                    }

                    // Step 2: build result
                    string result22 = "";

                    foreach (var pair in freq22)
                    {
                        result22 += $"{pair.Key}{pair.Value}";
                    }

                    Console.WriteLine(result22);
                    break;

                case 23:

                    string str23 = "aabbBBBcc";
                    char[] result = new char[str23.Length];
                    for (int i = 0; i < str23.Length; i++)
                    {
                        char c = str23[i];

                        if (i % 2 == 0)
                            result[i] = char.ToLower(c);
                        else
                            result[i] = char.ToUpper(c);
                    }
                    string output = new string(result);
                    Console.WriteLine(output);
                    break;

                case 24:

                case 25:

                case 26:

                case 27:
                    string string27 = "abcd";
                    char[] arr27 = string27.ToCharArray();
                    for (int i = 0; i < arr27.Length; i++)
                    {
                        arr27[i]++;
                    }
                    string27 = new string(arr27);
                    Console.WriteLine(string27);

                    break;
                case 28:

                case 29:

                case 30:

                    break;

            }
            Console.WriteLine("Hello, World!");


        }
    }
}
