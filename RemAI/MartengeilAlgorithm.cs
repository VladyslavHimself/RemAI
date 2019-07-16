using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Controller;
namespace RemAI
{
    class MartengeilAlgorithm
    {

        public static void CalculateTries()
        {

            start:
            
            bool isHaveMoney, isLimitReached = false; string temp, answer = null; double bux, bet, lim = 50000; int probes = 0;// Initialize all variables

            Console.WriteLine("Enter your amount of bux: ");

            temp = Console.ReadLine();// to receive information from operator

            try
            {
                bux = Convert.ToDouble(temp); // convert information to double type
            }
           
            catch(Exception)
            {
                Console.WriteLine("Catched exception! Check your input information and try again!");

                goto start;
            }

            if (bux < 10) // if received less than 10 bux -> deny next steps!
            {
                Console.WriteLine("You haven't enough bux!");
                Console.WriteLine("Want to restart programm? (y/n)");

                Control.CloseOrRestart(answer);
                
            }
            else
            {
            retry:
                isHaveMoney = true; // if all of last conditions was done
bet_try:
                Console.WriteLine("Enter your bet ( recommended 10 bux ) ");

                temp = Console.ReadLine();
                try
                {
                    bet = Convert.ToDouble(temp);
                }

                catch(Exception)
                {

                    Console.WriteLine("Catched exception! Check your input information and try again!");
                    goto bet_try;
                }


                if (bet < 10) // CSGO500 accept only 10 or more bux to play
                {

                    // Message and delay of 2 seconds for read informaiton. then clear console and back to the "control point" ;)

                    Console.WriteLine("Need at least 10 bux to play"); // message
                    Thread.Sleep(2000);  // delay
                    Console.Clear(); // Clear the console
                    goto retry; // back 
                }
                else
                {

                    // "Genius" algorithm by me. While we have money, they calculating streak of all possible loss. If they done -> show how many attempts you have

                    Console.WriteLine("============ LOG ============" + Environment.NewLine);

                    while (isHaveMoney == true) // if all conditions are true
                    {

                        if (bux > bet * 2) // if buxes less than minimum value -> break the cycle and shown information by your request
                        {
                            if (bet > lim) // if your bet break the limit, show information about this. Set high-limit values to red
                            {

                                Console.ForegroundColor = ConsoleColor.Red; // Change text color to red ( for nubmers )
                                if (isLimitReached == false) // realized for one time operation to detect 
                                {
                                    Console.ForegroundColor = ConsoleColor.Green; // Change color to green  ( for "Limit" information )
                                    isLimitReached = true;

                                    probes -= 1; // Safe-zone for the user

                                    // information about limit

                                    Console.WriteLine(Environment.NewLine + "Limit reached!");
                                    Console.WriteLine($"You can bet {probes} on line with the limit!" + Environment.NewLine);

                                    Control.GetWinrateByInfo(probes);

                                    // END information

                                    probes += 1; // back to the real values

                                    Console.ForegroundColor = ConsoleColor.Red; // back to the red color for numbers
                                }
                            }


                            // Martengeil Calculation formula

                            bet = Control.CalculateByMartengeil(bux, bet);
                            probes += 1; // add this try to 
                            Console.WriteLine(probes + " try = " + bet); // information about tries and bet that they need
                        }

                        else

                        {
                            // after calculating turn off bool and show message with info

                            Console.ResetColor(); // reset color to default 
                            isHaveMoney = false; // set bool to false, end cycle

                            // information about bets without limits

                            Console.WriteLine(Environment.NewLine + "=============================");
                            Console.WriteLine($"You can bet {probes} times on line without limit ;)");
                                Control.GetWinrateByInfo(probes);

                            // END information
                        }
                    }
                }
            }
            Console.ReadKey(); // "Please press any key to continue" :)

        }

    }
}
