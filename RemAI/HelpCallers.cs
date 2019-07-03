using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemAI
{
    class HelpCallers
    {

        public static void ShowMartengeilTutorial() // called by "-MFT"
        {

            Console.WriteLine("Don't realized yet!");

        }

        public static void ShowDailyRewardTutorial() // called by "-DRFT"
        {

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();



        }

        public static void ShowInfoAboutProgram() // called by "-info"
        {

            Console.WriteLine("--- Information about program ---\n");
            Console.WriteLine(" Name: RemAI (bot) ");
            Console.WriteLine(" Type: Legacy ");
            Console.WriteLine(" Version: 1.2p");
            Console.WriteLine(" You can check updates on -> https://github.com/VladyslavHimself/RemAI/releases");

            Console.WriteLine("\n\t--- CONTACTS ---");
            Console.WriteLine(" Program created by VladyslavHimself.");
            Console.WriteLine(" Contact info -> vladyslavhimself@gmail.com");


            
            Console.WriteLine("\n---------------------------------\n");


        }

        public static void DownloadRelease() // called by "-download"
        {
            Console.WriteLine("Open Release page!");
            Process.Start("https://github.com/VladyslavHimself/RemAI/releases");

        }
      
        public static void ShowHelpMenu() // called by "-download"
        {
            
            Console.WriteLine("\n-mfunc - call the Martengeil function (MF)\n");
            Console.WriteLine("-drfunc - call the daily reward function (DRF)\n");
            Console.WriteLine("-MFT - call tutorial for MF\n");
            Console.WriteLine("-DRFT - call tutorial for DRF\n");
            Console.WriteLine("-help - show command list\n");
            Console.WriteLine("-download - open the release page\n");
            Console.WriteLine("-info - show info version\n");
            

        }
    }
}