using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Controller;
namespace RemAI
{
   internal class HelpCallers : RemAI
    {

        public static void ShowMartengeilTutorial() // called by "-MFT"
        {

            Console.WriteLine("Martengeil tutorial for newbies\n");
            Console.WriteLine("At first you need a normal amount (I recommend start from 10k buxes, your winrate with it = ~24% per cycle(cycle = 33 tries ) ");
            Console.WriteLine("Next activate the Martengeil function by \"-mfunc\" and eneter your amount of buxes.");
            Console.WriteLine("Next you need to enter bet, that you want to place. I recommend to bet the minimum that you can, because when you bet higher - you winrate goes down");
            Console.WriteLine("Example: if you took 10 buxes with 10k amount - your winrate been 24%, but if you took 100 buxes with 10k amount - your winrate was been 15%");
            Console.WriteLine("But if you want to risk, you can bet higher");
            Console.WriteLine("Next you can see a log with your tries and sum of tries. In csgo500 your maximum bet was 50k and this give you less chance to beat cycle, but this percentage is high. ");
            Console.WriteLine("If your amount can assume >50k bet after losses, you will seen a WARNING RED sums that you can't bet in CSGO500, but can bet in other sites with other rules");
            Console.WriteLine("Good Luck!\n");

        }

        public static void ShowDailyRewardTutorial() // called by "-DRFT"
        {
            
            Console.WriteLine("Not realized yet!");
            // Realize tutorial for DailyRewardFunction  
            
        }

        public static void ShowInfoAboutProgram() // called by "-info"
        {

            Console.WriteLine("--- Information about program ---\n");
            Console.WriteLine(" Name: RemAI (bot) ");
            Console.WriteLine(" Type: Legacy ");
            Console.WriteLine(" Permission: " + Control.CheckPermission() );
            Console.WriteLine(" Version: 1.2p");
            Console.WriteLine(" You can check updates on -> https://github.com/VladyslavHimself/RemAI/releases or use command '-download' to open!");

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
            Console.WriteLine("-exit - exit program\n");

        }

        

        
    }
}