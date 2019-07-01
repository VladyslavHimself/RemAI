using System;
using System.Collections.Generic;
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

            string answer; // initialize variables

            Console.WriteLine("Welcome to the RemAI. I want to help you earn some money :)");
            start: // back to the start
            Console.WriteLine($"Enter command: {Environment.NewLine}");

            answer = Console.ReadLine(); // read the answer

            switch(answer)
            {

                case "-Martengeil":

                    MartengeilAlgorithm.ToCalculateTries(); // call the Martengeil function

                    break;

                case "-DailyReward":

                    // #TODO Realize Daily Reward System ( Waiting for Keef code to push )

                    Console.WriteLine("This function don't realized yet!");

                    goto start;

                case "-help":

                    Console.WriteLine("\n-Martengeil - call the Martengeil function (MF)\n");
                    Console.WriteLine("-DailyReward - call the daily reward function (DRF)\n");
                    Console.WriteLine("-MartengeilTutorial - call tutorial for MF\n");
                    Console.WriteLine("-DailyRewardFunction - call tutorial for DRF\n");
                    Console.WriteLine("-info - show info version");
                    
                    goto start;

                case "-MartengeilTutorial":

                    HelpCallers.ShowMartengeilTutorial();

                    goto start;

                case "-DailyRewardTutorial":

                    Console.WriteLine("This function isn't realized yet! Maybe in next patch!");

                    goto start;

                case "-info":

                    HelpCallers.ShowInfoAboutProgram();

                    goto start;

                default:

                    Console.WriteLine($"Something went wrong! Enter -help to get more functions! {Environment.NewLine}");

                    goto start;

            }

            

        }

    }
}