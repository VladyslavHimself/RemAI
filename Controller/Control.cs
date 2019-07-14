using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Controller
{
    public class Control
    {

        // Shown winrate per cycle

        public static float GetWinrateByInfo(int probes) // Winrate calculator
        {

            const int MaxSpins = 33; // realize the constant 33
            int resultWinrate; // initialize the result

            resultWinrate = 100 * probes / MaxSpins; // percentage formula 

            Console.WriteLine($"Your winrate = {resultWinrate}% per cycle"); // show the info


            return resultWinrate; // return result
        }

        // Check Developer Permission for currently session

        public static string CheckPermission()
        {

            // #TODO Utility checker permission in session.
            return "unknown";
        }

        // Clear the console

        public static void ClearConsole()
        {

            Console.WriteLine("Clear the console...");
            Thread.Sleep(100);
            Console.Clear();
                   
        }

        // Give user chance to change permission

        public static bool PermissionChoise(bool isDeveloper, string devkey)
        {

            if (isDeveloper == true)
            {

                Console.WriteLine("You are developer in this session!");
                return true;

            }
            else if (isDeveloper == false)
            {

                Console.WriteLine("Enter developer key: ");
                devkey = Console.ReadLine();
                if (devkey == "1699")
                {
                    Console.WriteLine("Set developer permission to this session...");
                    try
                    {
                        isDeveloper = true;

                        Console.WriteLine("Complete! You a developer now!");

                        return true;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Something went wrong! Try on another session.");

                    }

                }
                else
                {
                    isDeveloper = false;
                    Console.WriteLine("Wrong key!");
                }
            }
            return false;
        }



        

    }
}
