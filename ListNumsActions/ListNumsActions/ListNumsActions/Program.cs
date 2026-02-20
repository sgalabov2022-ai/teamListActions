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
                        break;

                    case "del":
                        break;

                    case "contains":
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
                        Console.Write("Number: ");
                        int number = int.Parse(Console.ReadLine());
                        int count = 0;
                        foreach (int num in nums)
                        {
                            if (num > number)
                            {
                                count++;
                            }
                        }
                        Console.WriteLine(count);
                        break;

                    case "cut":
                        Console.Write("Index: ");
                        int index = int.Parse(Console.ReadLine());
                        nums.RemoveAt(index);
                        break;

                    case "peint":
                        Console.WriteLine(string.Join(" ", nums));
                        break;
                    //devC

                    default:
                        break;
                }
            }
        }
    }
}
