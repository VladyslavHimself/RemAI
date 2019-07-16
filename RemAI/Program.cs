using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Controller;
/*
 * 
 * Programm oriented only for CSGO500
 * If you have some questions, please leave it here: vladyslavhimself@gmail.com
 * 
 */



namespace RemAI
{

    public class RemAI
    {

        private static void Main(string[] args)
        {
            string devkey = null;
            string answer; // initialize variables
            bool isDeveloper; // dev mode
            isDeveloper = false;
            Console.WriteLine("Welcome to the RemAI. I want to help you earn some money :)");
            start: // back to the start
            Console.WriteLine($"Enter command: {Environment.NewLine}");

            answer = Console.ReadLine(); // read the answer

            switch(answer)
            {

                case "-mfunc": case "-MartengeilFunction":

                    MartengeilAlgorithm.CalculateTries(); // call the Martengeil function

                    break;

                case "-drfunc": case "-DailyRewardFunction":

                    DailyRewardFoo.ToCalculateDailyPerDate();

                    goto start;

                case "-help": case "-list":

                    HelpCallers.ShowHelpMenu(); // show list of commands
                    
                    goto start;

                case "-MFT": case "-MartengeilFunctionTutorial":

                    HelpCallers.ShowMartengeilTutorial(); // Show Tutorial by Martengeil function

                    goto start;

                case "-DRFT": case "-DailyRewardFunctionTutorial":

                    HelpCallers.ShowDailyRewardTutorial(); // Show Daily Reward Tutorial

                    goto start;

                case "-info":
                   
                    HelpCallers.ShowInfoAboutProgram(); // Show info about program and developers

                    goto start;

                case "-download":

                    HelpCallers.DownloadRelease(); // Open download link

                    goto start;


                case "-clear":
                case "-cls":

                    Control.ClearConsole();

                    goto start;

                case "-devmode":

                    Console.WriteLine("Enter DevToolKit key");

                    if (Control.PermissionChoise(isDeveloper, devkey) == true)
                    {
                        isDeveloper = true;


                    }
               else if (Control.PermissionChoise(isDeveloper, devkey) == false)
                    {

                        isDeveloper = false;
                        Console.WriteLine("Wrong key!");

                    }
                    goto start;

                case "-AnalyzeMode": case "-AM":

                    Control.OpenAnalyzer(isDeveloper); 
                   
                   
                    Console.ReadKey();
                    goto start;

                case "-exit": case "-close":

                    break; // exit the program
                    
                default:

                    Console.WriteLine($"Something went wrong! Enter -help to find commands! {Environment.NewLine}"); // show exception program

                    goto start;

            }

        }

    }

}