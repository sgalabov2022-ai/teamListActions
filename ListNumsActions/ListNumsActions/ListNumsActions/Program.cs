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
                        break;

                    case "add":
                        break;

                    case "large":
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
