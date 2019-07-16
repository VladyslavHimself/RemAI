using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

/*                                          
 *                                          Control Library ToolBox
 *                                          
 *      Control Lib – universal library toolbox for casino-associated programs.In description below, you can get more information.
 *
 *                                                          Functions:
 * 
 *          GetWinrateByInfo(probes) –where probes are integer, you can get winrate of your tries in % by cycle (cycle is a 33 tries )
 *
 *          CheckPermission() – check permission in currently session(user or developer )
 *
 *          ClearConsole() – clear the console by one command.
 *           
 *          PermissionChoise(isDeveloper, devkey) – where isDeveloper is bool, devkey is string, gives operator chance to change permission from user to developer!
 *
 *          CalculateMartengeil(double bux, double bet) – where bux is double, bet is double, calculates Martengeil function by one command.
 *
 *          OpenAnalyzer(isDeveloper) – where isDeveloper is bool, opens Analyzer for analyze traffic in casino(works only, if you have existing Analyzer)
 *
 *          CloseOrRestart(answer) – where answer is string. One command, that doing your code shorter, if you’re using this type of algorithm many times.
 *
 * 
 */

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


        // Calculate tries by Martengeil formula


        public static double CalculateByMartengeil(double bux, double bet)
        {

            bux = bux - (bet * 2); // Calculating formula for CSGO500
            bet *= 2; // bet multiplies by 2

            return bet;
        }


        // Open site analyzer


        public static void OpenAnalyzer(bool isDeveloper)

        {

            if (isDeveloper == true)
            {
                try
                {
                    Process.Start("Analyzer.exe");
                }

                catch (Exception)
                {
                    Console.WriteLine("Not added on project this time.Maybe on version 1.3 or higher ;)");
                }
            }
            else if (isDeveloper == false) Console.WriteLine("Not found 404 ;)");
        }


        // Alternative variants "Yes" or "No"


        public static bool CloseOrRestart(string answer)
        {


            answer = Console.ReadLine(); // restart or exit 

            if (answer == "y" || answer == "Y") // if answer from user will be y or Y -> clear the console and back to the start
            {

                Process.Start("RemAI"); // to start new instance of application
                Environment.Exit(0); //to turn off current app

                return true;
            }
            else if (answer == "n" || answer == "N") // if answer from user was n or N -> close the program
            {
                Environment.Exit(0); // Close program

                return false;
            }
            
            return false;
        }


        
    }
}
