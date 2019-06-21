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

            string answer;

            Console.WriteLine("Welcome to the RemAI. I want to help you earn some money :)");
            start:
            Console.WriteLine($"Enter command: {Environment.NewLine}");

            answer = Console.ReadLine();

            switch(answer)
            {

                case "Martengeil":

                    MartengeilAlgorithm.ToCalculateTries();

                    break;

                case "DailyReward":

                    // #TODO Realize Daily Reward System ( Waiting for Keef code to push )

                    Console.WriteLine("This function don't realized yet!");

                    goto start;

                case "--help":
                    
                    // #TODO Realize communication with command line and user ( Waiting for Avir0n code to push )

                    Console.WriteLine("This function don't realized yet!");
                     
                    goto start;

                default:

                    Console.WriteLine($"Something went wrong! Enter --help to get more functions! {Environment.NewLine}");

                    goto start;

            }

            

        }

    }
}