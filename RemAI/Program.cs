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
            Console.WriteLine("Please select a function what you need: (Martengeil), (DailyReward) ");

            answer = Console.ReadLine();

            switch(answer)
            {

                case "Martengeil":

                    MartengeilAlgorithm.ToCalculateTries();

                    break;

                case "DailyReward":

                    // #TODO Realize Daily Reward System ( Waiting for Keef code push )

                    Console.WriteLine("Don't realized yet!");

                    goto start;

                default:

                    Console.WriteLine("Something went wrong! Try again...");

                    break;

            }

            

        }

    }
}