using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


/*
 * 
 * Programm oriented only for CSGO500
 * If you have some questions, please leave it here: vladyslavhimself@gmail.com
 * 
 */



namespace RemAI
{

    class RemAI
    {

    
      private static void Main(string[] args)
        {

            string answer; bool isDeveloper = false; // initialize variables

            Console.WriteLine("Welcome to the RemAI. I want to help you earn some money :)");
            start: // back to the start
            Console.WriteLine($"Enter command: {Environment.NewLine}");

            answer = Console.ReadLine(); // read the answer

            switch(answer)
            {

                case "-mfunc":

                    MartengeilAlgorithm.CalculateTries(); // call the Martengeil function

                    break;

                case "-drfunc":

                    // #TODO Realize Daily Reward System ( Waiting for Keef code to push )

                    Console.WriteLine("This function isn't realized yet! Maybe in next patch!"); // show warning message

                    goto start;

                case "-help":

                    HelpCallers.ShowHelpMenu(); // show list of commands
                    
                    goto start;

                case "-MFT":

                    HelpCallers.ShowMartengeilTutorial(); // Show Tutorial by Martengeil function

                    goto start;

                case "-DRFT":

                    HelpCallers.ShowDailyRewardTutorial(); // Show Daily Reward Tutorial

                    goto start;

                case "-info": 

                    HelpCallers.ShowInfoAboutProgram(); // Show info about program and developers

                    goto start;

                case "-download":

                    HelpCallers.DownloadRelease(); // Open download link

                    goto start;


                case "-clear":

                    HelpCallers.ClearConsole(); // Clear the console

                    goto start;

                case "!AnalyzeMode":               
                                                     // #TODO Realize developer mode in other function. 
                                                    // #TODO Build logic for developer mode for the future plans!

                    if (isDeveloper == true)
                    {
                        HelpCallers.SwitchToAnalyze(isDeveloper);
                    }
                    Console.WriteLine("Enter developer key:");
                   string key = Console.ReadLine();
              
                    if (key == "1699") 
                    {

                        Console.WriteLine("Set developer permission for this session...");
                        try
                        {

                            isDeveloper = true;
                            Console.WriteLine("Done! Open Analyzer!");
                            HelpCallers.SwitchToAnalyze(isDeveloper);
                        } 

                        catch (Exception)
                        {

                            Console.WriteLine("Error! redirecting back!");
                            goto start;
                        }
                         


                    } else {

                        HelpCallers.SwitchToAnalyze(isDeveloper);
                    }

                    

                    goto start;


                case "-exit":

                    break; // exit the program
                    
                default:

                    Console.WriteLine($"Something went wrong! Enter -help to find commands! {Environment.NewLine}"); // show exception program

                    goto start;

            }

        }

    }

}