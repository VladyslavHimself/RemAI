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

        public static void ShowMartengeilTutorial()
        {

            Process.Start("https://github.com/VladyslavHimself/RemAI.git");


        }

        public static void ShowDailyRewardTutorial()
        {

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();



        }

        public static void ShowInfoAboutProgram()
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

        public static void DownloadRelease()
        {
            Console.WriteLine("Open Release page!");
            Process.Start("https://github.com/VladyslavHimself/RemAI/releases");

        }

    }
}
