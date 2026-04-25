using System.Linq;

namespace C__Tasks____Methods_List_LINQ_LinkedList_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int[] arr1 = [1, 2, 3, 6, 0, -2, -1];
            int[] arr2 = [1, 1, 5, 4, 2, 6, 1, -1, 3];
            List<int> list1 = new List<int> { 1, 2, 2000, 3, 6, 0, -2, -1, 1, 2, 4, 1001};
            List<int> list2 = new List<int> { 1001, 2,4, 55, 10, 2302, -1, -1, 0, 2};
            Dictionary<string, int> students = new Dictionary<string, int>{
    { "Ali", 75 },
    { "Sara", 40 },
    { "Omar", 85 },
    { "Lina", 60 },
    { "Noor", 95 },
    {"Mohammad", 101 }
};
            int switchcase = int.Parse(Console.ReadLine());

            switch (switchcase)
            {
                case 1:

                    List<int> evenNumbers = list1.Where(n => n % 2 == 0).ToList();

                    break;
                case 2:
                    List<int> noDuplicates = list1.Distinct().ToList();
                    break;
                case 3:
                    int maxList3 = list1.Max(n => n);
                    break;
                case 4:
                    list1.Reverse();
                    break;
                case 5:
                    int greaterThanX = list1.Where(n => n > 1).Count();
                    Console.WriteLine(greaterThanX);
                    break;

                case 6:
                    foreach (var item in students)
                    {
                        var success = item.Value;
                        if (success > 80)
                        {
                            Console.WriteLine(item.Key);
                        }
                    }
                    break;

                case 7:  //    TEST
                    string nameSearch = Console.ReadLine();
                    if (students.ContainsKey(nameSearch)) {
                        Console.WriteLine(nameSearch);
                    } else
                    {
                        Console.WriteLine("No result found");
                    }
                    break;

                case 8:
                    int valuesSum = list1.Sum(n => n);
                    Console.WriteLine(valuesSum);
                    break;

                case 9:
                    foreach (var item in students)
                    {
                        var success = item.Value;
                        if (success < 50)
                        {
                            students.Remove(item.Key);
                        }
                    }
                    foreach (var item in students)
                    {
                        Console.WriteLine($"{item.Key}");
                    }
                    break;

                case 10:
                    var highest = students.MaxBy(n => n.Value);
                    Console.WriteLine(highest.Key);
                    break;

                case 11:
                    LinkedList<string> navigation11 = new LinkedList<string>(new[] { "Entry" });
                    navigation11.AddFirst("First Entry");
                    navigation11.AddLast("Second Entry");
                    navigation11.ToArray();
                    Console.WriteLine(String.Join(", ", navigation11.ToArray()));
                    break;

                case 12:
                    LinkedList<string> navigation12 = new LinkedList<string>(new[] { "First Entry", "Entry", "Second Entry" });
                    navigation12.Remove("Entry");
                    navigation12.ToArray();
                    Console.WriteLine(String.Join(", ", navigation12.ToArray()));
                    break;

                case 13:
                    LinkedList<string> navigation13 = new LinkedList<string>(new[] { "First Entry", "Entry", "Second Entry" });
                    var node13 = navigation13.Find("Entry");
                    navigation13.AddAfter(node13, "AddedAfter");
                    navigation13.AddBefore(node13, "AddedBefore");
                    navigation13.ToArray();
                    Console.WriteLine(String.Join(", ", navigation13.ToArray()));
                    break;

                case 14:
                    LinkedList<string> navigation14 = new LinkedList<string>(new[] { "First Entry", "Entry", "Second Entry" });
                    foreach (var item in navigation14)
                    {
                        Console.WriteLine(item);
                    }
                    break;

                case 15:
                    LinkedList<string> navigation15 = new LinkedList<string>(new[] { "First Entry", "Entry", "Second Entry" });
                    string First15 = navigation15.First();
                    string Last15 = navigation15.Last();
                    Console.WriteLine($"the first element is {First15}, and the last is {Last15}");
                    break;

                case 16:
                    List<int> list16 = new List<int> { 1, 2, 3, 4, };
                    List<int> odd16 = list16.Where(n => n % 2 != 0).ToList();

                    break;

                case 17:
                    List<int> list17 = list1.Select(n => n * 2).ToList();
                    break;

                case 18:
                    List<int> list18 = list1.OrderDescending().ToList();
                    Console.WriteLine(String.Join(", ", list18.ToArray()));
                    break;

                case 19:
                    int max19 = list1.First(n => n > 100);
                    Console.WriteLine(max19);
                    break;

                case 20:
                    var avg20 = (list1.Average(n => n));
                    Console.WriteLine(avg20);
                    break;

                case 21:
                    List<int> commons = list1.Intersect(list2).ToList();
                    Console.WriteLine();
                    break;

                case 22:
                    list1.AddRange(list2);
                    List<int> merged22 = list1;
                    Console.WriteLine(String.Join(", ", merged22.ToArray()));
                    break;

                case 23:
                    List<int> uniques = list1.Distinct().ToList();
                    break;

                case 24:
                    List<int> grades24 = new List<int>();
                    foreach (var item in students)
                    {
                        grades24.Add(item.Value);
                    }
                    Console.WriteLine(String.Join(", ", grades24.ToArray()));
                    break;

                case 25:

                    foreach (var item in students)
                    {
                        if (item.Value > 100)
                        {
                            students.Remove(item.Key);
                        }
                    }
                    Console.WriteLine(String.Join(", ", students.ToArray()));
                    break;

                case 26:
                    int search26 = 1;
                    for (int i = 0; i < arr2.Length; i++)
                    {
                        if (arr2[i] == search26)
                        {
                            Console.WriteLine($"Found {search26} at {i}");
                        }
                    }
                    break;

                case 27:
                    int evens27 = 0;
                    for (int i = 0; i < arr2.Length; i++)
                    {
                        if (arr2[i] % 2 == 0)
                        {
                            evens27++;
                        }
                    }
                    Console.WriteLine(evens27);
                    break;

                case 28:
                    for (int i = list1.Count - 1; i >= 0; i--)
                    {
                        if (list1[i] > 2)
                        {
                            list1.RemoveAt(i);
                        }
                    }
                    Console.WriteLine(String.Join(", ", list1.ToArray()));
                    break;

                case 29:
                    int max1st29 = 0;
                    int max2nd29 = 0;
                    for (int i = 0; i < arr1.Length; i++)
                    {
                        if (arr1[i] > max1st29)
                        {
                            max1st29 = arr1[i];
                        }
                    }
                    for (int j = 0; j < arr1.Length; j++)
                    {
                        if (max1st29 > arr1[j] && arr1[j] > max2nd29)
                        {
                            max2nd29 = arr1[j]; //int[] arr1 = [1, 2, 3, 6, 0, -2, -1];
                        }
                    }

                    Console.WriteLine(max2nd29);
                    break;

                case 30:
                    List<int> nums30 = new List<int> { 1, 3, 2, 3, 4, 3, 5, 2 };

                    Dictionary<int, int> count30 = new Dictionary<int, int>();

                    int maxCount30 = 0;
                    int mostFrequent30 = nums30[0];

                    foreach (int num in nums30)
                    {
                        if (count30.ContainsKey(num))
                            count30[num]++;
                        else
                            count30[num] = 1;

                        // track max manually
                        if (count30[num] > maxCount30)
                        {
                            maxCount30 = count30[num];
                            mostFrequent30 = num;
                        }
                    }

                    Console.WriteLine($"Most frequent: {mostFrequent30} (Count: {maxCount30})");
                    break;

                case 31:
                    int k = 3;
                    int[] arr = arr1;
                    int n = arr.Length;
                    k = k % n;

                    // --- Reverse whole array ---
                    for (int left = 0, right = n - 1; left < right; left++, right--)
                    {
                        int temp = arr[left];
                        arr[left] = arr[right];
                        arr[right] = temp;
                    }

                    // --- Reverse first k elements ---
                    for (int left = 0, right = k - 1; left < right; left++, right--)
                    {
                        int temp = arr[left];
                        arr[left] = arr[right];
                        arr[right] = temp;
                    }

                    // --- Reverse remaining elements ---
                    for (int left = k, right = n - 1; left < right; left++, right--)
                    {
                        int temp = arr[left];
                        arr[left] = arr[right];
                        arr[right] = temp;
                    }
                    Console.WriteLine(string.Join(",", arr));
                    break;

                case 32:
                    int[] arr3 = [1, 2, 3, 4, 3, 2, 1];
                    int[] arr4 = [1, 2, 3, 3, 2, 1];

                    for (int left = 0, right = arr4.Length - 1; left <= right; left++, right--)
                    {
                        if (arr4[left] != arr4[right])
                        {
                            Console.WriteLine("not a palindrome");
                            break;
                        } else if (arr4[left] == arr4.Length / 2 || arr4[right] == arr4.Length / 2)
                        {
                            Console.WriteLine("Is palindrome");
                        }

                    }
                    break;
                case 33:
                    int[] arr5 = [1, 2, 4, 5, 6];
                    int start33 = arr5[0];
                    for (int i = 1; i < arr5.Length; i++)
                    {
                        if (arr5[i] != start33 + 1)
                        {
                            Console.WriteLine($"The missing number is {start33 + 1}");
                            break;
                        }
                        start33++;
                    }
                    break;

                case 34:
                    List<int> nums34 = new List<int> { 1, 2, 3, 4, 5 };

                    int totalSum34 = 0;
                    foreach (int n34 in nums34)
                    {
                        totalSum34 += n34;
                    }

                    int leftSum34 = 0;
                    int minDiff34 = int.MaxValue;
                    int bestIndex34 = -1;

                    for (int i = 0; i < nums34.Count - 1; i++)
                    {
                        leftSum34 += nums34[i];
                        int rightSum34 = totalSum34 - leftSum34;

                        int diff34 = Math.Abs(leftSum34 - rightSum34);

                        if (diff34 < minDiff34)
                        {
                            minDiff34 = diff34;
                            bestIndex34 = i;
                        }
                    }

                    Console.WriteLine($"Best split at index: {bestIndex34}");
                    Console.WriteLine($"Minimum difference: {minDiff34}");
                    break;

                case 35: //// recheck
                    List<int> arr6 = new List<int> { 1, 2, 2, 3, 4, 1, 2, 3, 4, 5, 6 };
                    int start = 0;
                    int end = 0;
                    int length = 1;
                    int bestlength = 1;
                    for (int i = 1; i < arr6.Count; i++)
                    {
                        if (arr6[i] >= arr6[i - 1])
                        {
                            length++;
                            continue;
                        }

                        if (length > bestlength)
                        {
                            bestlength = length;
                            end = i;
                        }
                        else
                        {
                            start = 0;
                        }
                    }
                    // extract sequence
                    var result = arr6.GetRange(start, bestlength);

                    Console.WriteLine(string.Join(", ", result));
                    break;


                case 36:
                    List<int> nums = new List<int> { 1, 2, 3, 1, 4, 2, 1 };

                    Dictionary<int, int> lastSeen = new Dictionary<int, int>();

                    int minDistance = int.MaxValue;

                    for (int i = 0; i < nums.Count; i++)
                    {
                        if (lastSeen.ContainsKey(nums[i]))
                        {
                            int distance = i - lastSeen[nums[i]];
                            minDistance = Math.Min(minDistance, distance);
                        }

                        lastSeen[nums[i]] = i;
                    }

                    Console.WriteLine(minDistance == int.MaxValue ? -1 : minDistance);
                    break;

                case 37:
                    List<int> oddeven = new List<int> { 3, 1, 2, 4, 7, 6 };

                    var oddevenfinal = oddeven
                        .Where(n => n % 2 == 0)
                        .Concat(oddeven.Where(n => n % 2 != 0))
                        .ToList();

                    Console.WriteLine(string.Join(", ", oddevenfinal));
                    break;

                case 38:
                    List<int> values = new List<int> { 1, 3, 2, 5, 4, 6, 3 };

                    List<int> peaks = new List<int>();

                    for (int i = 1; i < values.Count - 1; i++)
                    {
                        if (values[i] > values[i - 1] && values[i] > values[i + 1])
                        {
                            peaks.Add(values[i]);
                        }
                    }

                    Console.WriteLine(string.Join(", ", peaks));
                    break;

                case 39:
                    List<int> sumarr = new List<int> { 2, 7, 11, 15 };
                    int target = 9;

                    Dictionary<int, int> map = new Dictionary<int, int>();

                    for (int i = 0; i < sumarr.Count; i++)
                    {
                        int complement = target - sumarr[i];

                        if (map.ContainsKey(complement))
                        {
                            Console.WriteLine($"Indices: {map[complement]}, {i}");
                            Console.WriteLine($"Values: {complement}, {sumarr[i]}");
                            break;
                        }

                        map[sumarr[i]] = i;
                    }
                    break;

                case 40:
                    List<int> nums40 = new List<int> { 0, 1, 0, 3, 12 };

                    int k40 = 0;

                    // Move non-zeros forward
                    for (int i = 0; i < nums40.Count; i++)
                    {
                        if (nums40[i] != 0)
                        {
                            nums40[k40++] = nums40[i];
                        }
                    }

                    // Fill remaining with zeros
                    for (int i = k40; i < nums40.Count; i++)
                    {
                        nums40[i] = 0;
                    }

                    Console.WriteLine(string.Join(", ", nums40));
                    break;

                case 41: // handle different length arrays
                    int[] arr11 = [1, 2, 3, 6, 7, 8];
                    int[] arr12 = [-1, -2, -3, -4, 0, 1];
                    int range40;
                    List<int> merged = new List<int>();
                    if (arr11.Length < arr12.Length)
                    {
                        range40 = arr11.Length;
                    } else
                    {
                        range40 = arr12.Length;
                    }

                    for (int i = 0; i<range40; i++)
                    {
                        merged.Add(arr11[i]);
                        merged.Add(arr12[i]);
                    }
                    Console.WriteLine(string.Join(",", merged));
                    break;
                case 42:
                    //arr2
                    int freq41 = 0;
                    List<int> checked41 = new List<int>(); 
                    for (int i=0; i < arr2.Length; i++)
                    {
                        if (checked41.Contains(arr2[i]) == true)
                        {
                            continue;
                        } else
                        {
                            checked41.Add(arr2[i]);
                            for (int j = 0; j < arr2.Length; j++)
                            {
                                if (arr2[i] == arr2[j]){
                                    freq41++;
                                }
                            }
                            Console.WriteLine($"{arr2[i]} appeared {freq41} times");
                            freq41= 0;
                        }
                    }
                    break;

                case 43: //merge in one loop
                    int max42A = arr2[0];
                    int max42B = arr2[0];
                    for (int i = 1; i < arr2.Length; i++) //int[] arr2 = [1, 1, 5, 4, 2, 6, 1, -1, 3];
                    {

                        int val = arr2[i];

                        if (val > max42A)
                        {
                            max42B = max42A; // old max becomes second max
                            max42A = val;
                        }
                        else if (val > max42B && val < max42A)
                        {
                            max42B = val;
                        }
                    }
                    Console.WriteLine(max42B);
                    break;

                case 44:
                    int[] arr44 = { 1, 2, 3, 7, 5 };
                    int target44 = 12;

                    int sum44 = 0;
                    int start44 = 0;

                    for (int end44 = 0; end44 < arr44.Length; end44++)
                    {
                        sum44 += arr44[end44];

                        while (sum44 > target44)
                        {
                            sum44 -= arr44[start44];
                            start44++;
                        }

                        if (sum44 == target44)
                        {
                            Console.WriteLine($"Found from index {start44} to {end44}");
                            break;
                        }
                    }
                    break;


                case 45:
                    // reverse from index 1 to 3 → [2,3,4]
                    for (int left45 = 1, right45 = 3; left45 < right45; left45++, right45--)
                    {
                        int temp = arr1[left45];
                        arr1[left45] = arr1[right45];
                        arr1[right45] = temp;
                    }
                    Console.Write(string.Join(",", arr1));
                    break;

                case 46:
                    int[] nums46 = { 4, 3, 2, 1 };

                    var arrPos46 = nums46
                        .Select((val, idx) => new { val, idx })
                        .OrderBy(x => x.val)
                        .ToArray();

                    bool[] visited46 = new bool[nums46.Length];
                    int swaps46 = 0;

                    for (int i = 0; i < nums46.Length; i++)
                    {
                        if (visited46[i] || arrPos46[i].idx == i)
                            continue;

                        int cycleSize46 = 0;
                        int j = i;

                        while (!visited46[j])
                        {
                            visited46[j] = true;
                            j = arrPos46[j].idx;
                            cycleSize46++;
                        }

                        if (cycleSize46 > 1)
                            swaps46 += cycleSize46 - 1;
                    }

                    Console.WriteLine(swaps46);
                    break;

                case 47:

                    int max47A = arr2[0];
                    int max47B = arr2[0];
                    int min47A = arr2[0];
                    int min47B = arr2[0];
                    List<int> arranged47 = new List<int>();
                    for (int i = 1; i < arr2.Length; i++) //int[] arr2 = [1, 1, 5, 4, 2, 6, 1, -1, 3];
                    {
                        int val = arr2[i];

                        if (val > max47A)
                        {
                            max47B = max47A; // old max becomes second max
                            max47A = val;
                        }
                        else if (val > max47B && val < max47A)
                        {
                            max47B = val;
                        }

                        if (val < min47A)
                        {
                         min47B = min47A;
                            min47A = val;
                        }
                        else if (val < min47B && val > min47A)
                        {
                            min47B =val;
                        }
                    }
                    arranged47.Add(max47A);
                    arranged47.Add(max47B);
                    arranged47.Add(min47A);
                    arranged47.Add(min47B);
                    Console.WriteLine(string.Join(",", arranged47));
                        break;

                case 48:
                    int[] nums48 = { 1, 2, 1, 2, 1, 2, 3 };

                    string result48 = "No pattern";

                    for (int len48 = nums48.Length / 2; len48 >= 1; len48--)
                    {
                        var patterns48 = nums48
                            .Select((_, i) => i)
                            .Where(i => i <= nums48.Length - len48)
                            .Select(i => string.Join(",", nums48.Skip(i).Take(len48)))
                            .ToList();

                        var duplicates48 = patterns48
                            .GroupBy(p => p)
                            .FirstOrDefault(g => g.Count() > 1);

                        if (duplicates48 != null)
                        {
                            result48 = duplicates48.Key;
                            break;
                        }
                    }

                    Console.WriteLine(result48);
                    break;
                case 49: //int[] arr2 = [1, 1, 5, 4, 2, 6, 1, -1, 3];
                    int toremove = 1;
                    List<int> newarr = new List<int>();
                    for(int i = 0; i < arr2.Length; i++)
                    {
                        if (arr2[i] != toremove)
                        {
                            newarr.Add(arr2[i]);
                        }
                    }
                    Console.WriteLine(string.Join(",", newarr));
                    break;


            }
        }
    }
}
