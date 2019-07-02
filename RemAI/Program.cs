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

            string answer; // initialize variables

            Console.WriteLine("Welcome to the RemAI. I want to help you earn some money :)");
            start: // back to the start
            Console.WriteLine($"Enter command: {Environment.NewLine}");

            answer = Console.ReadLine(); // read the answer

            switch(answer)
            {

                case "-mfunc":

                    MartengeilAlgorithm.ToCalculateTries(); // call the Martengeil function

                    break;

                case "-drfunc":

                    // #TODO Realize Daily Reward System ( Waiting for Keef code to push )

                    Console.WriteLine("This function don't realized yet!");

                    goto start;

                case "-help":

                    Console.WriteLine("\n-mfunc - call the Martengeil function (MF)\n");
                    Console.WriteLine("-drfunc - call the daily reward function (DRF)\n");
                    Console.WriteLine("-MFT - call tutorial for MF\n");
                    Console.WriteLine("-DRFT - call tutorial for DRF\n");
                    Console.WriteLine("-info - show info version");
                    
                    goto start;

                case "-MFT":

                    HelpCallers.ShowMartengeilTutorial();

                    goto start;

                case "-DRFT":

                    Console.WriteLine("This function isn't realized yet! Maybe in next patch!");

                    goto start;

                case "-info":

                    HelpCallers.ShowInfoAboutProgram();

                    goto start;

                case "-download":

                    HelpCallers.DownloadRelease();

                    goto start;

                case "-exit":

                    Console.WriteLine("Bye!");

                    Thread.Sleep(200);

                    break;

                default:

                    Console.WriteLine($"Something went wrong! Enter -help to find commands! {Environment.NewLine}");

                    goto start;

            }

            

        }

    }
}