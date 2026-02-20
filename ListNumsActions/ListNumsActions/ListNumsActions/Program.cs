using System;
using System.Collections.Generic;
using System.Linq;

namespace ListNumsActions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (true)
            {
                string[] cmd = Console.ReadLine().Split().ToArray();
                string command = cmd[0];
                if (command.ToLower() == "finish")
                {
                    break;
                }
                switch (command)
                {
                    case "ins":
                        Console.Write("Enter num: ");
                        int insNum = int.Parse(Console.ReadLine());
                        Console.Write("Enter index: ");
                        int insIndex = int.Parse(Console.ReadLine());
                        nums.Insert(insNum, insIndex);
                        break;

                    case "del":
                        Console.Write("Element: ");
                        int element = int.Parse(Console.ReadLine());
                        nums.Remove(element);
                        break;

                    case "contains":
                        Console.Write("Element: ");
                        int contains = int.Parse(Console.ReadLine());
                        if (nums.Contains(contains))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No");
                        }
                        break;
                    //devA



                    case "remove":
                        Console.Write("Index: ");
                        int index = int.Parse(Console.ReadLine());
                        nums.RemoveAt(index);
                        break;

                    case "add":
                        Console.Write("Num1: ");
                        int addNum1 = int.Parse(Console.ReadLine());
                        Console.Write("Num2: ");
                        int addNum2 = int.Parse(Console.ReadLine());
                        nums.Add(addNum1 + addNum2);
                        break;

                    case "large":
                        if (nums.Count > 0)
                        {
                            int largest = nums[0];

                            for (int i = 1; i < nums.Count; i++)
                            {
                                if (nums[i] > largest)
                                {
                                    largest = nums[i];
                                }
                            }
                            Console.WriteLine("Largest number is: " + largest);
                        }
                        else
                        {
                            Console.WriteLine("List is empty.");
                        }
                        break;
                    //devB



                    case "countl":
                        break;

                    case "cut":
                        break;

                    case "peint":
                        break;
                    //devC

                    default:
                        break;
                }
            }
        }
    }
}
