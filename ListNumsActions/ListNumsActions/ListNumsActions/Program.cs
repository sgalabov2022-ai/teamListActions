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
