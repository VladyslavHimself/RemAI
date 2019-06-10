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
    class Program
    {
        static void Main(string[] args)
        {
start:
              bool isHaveMoney, isLimitReached = false;   string temp, answr;  int bux, bet, probes = 0, lim; // Initialize all variables

            Console.WriteLine("Welcome to the RemAI. I want to help you earn some money :)");
            Console.WriteLine("Enter your amount of bux: ");

            temp = Console.ReadLine(); // to receive information from operator
            bux = Convert.ToInt32(temp); // convert information to int type

            if (bux < 10) // if received less than 10 bux -> deny next steps!
            {
                Console.WriteLine("You haven't enough bux!");
                Console.WriteLine("Want to restart programm? (y/n)");

                answr = Console.ReadLine(); // retry or exit 

                if (answr == "y" || answr == "Y") // if answer from user will be y or Y -> clear the console and back to the start
                {
                    Console.Clear(); // clear the console
                    goto start; // back to the start
                }
                else if (answr == "n" || answr == "N") // if answer from user was n or N -> close the program
                {
                    Environment.Exit(0); // Close program
                }
       
            } else {
retry:
                isHaveMoney = true; // if all of last conditions was done

                    Console.WriteLine("Enter your bet ( recommended 10 bux ) ");

                       temp = Console.ReadLine();
                       bet = Convert.ToInt32(temp);

                if (bet < 10) // CSGO500 accept only 10 or more bux to play
                {

                    // Message and delay of 2 seconds for read informaiton. then clear console and back to the "control point" ;)

                    Console.WriteLine("Need at least 10 bux to play"); // message
                    Thread.Sleep(2000);  // delay
                    Console.Clear(); // Clear the console
                    goto retry; // back 
                } else {

 // "Genius" algorithm by me. While we have money, they calculating streak of all possible loss. If they done -> show how many attempts you have

                    Console.WriteLine("============ LOG ============" + Environment.NewLine);

                    

                    while (isHaveMoney == true) // if all conditions are true
                    {

 // #TODO Bug with limit and triess

                        if (bux >= 10)
                        {
                            if (bet > 500000)
                            {

                                Console.ForegroundColor = ConsoleColor.Red;
                                if (isLimitReached == false)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    isLimitReached = true;

                                    probes -= 1;

                                    

                                    Console.WriteLine(Environment.NewLine + "Limit reached!");
                                    Console.WriteLine("You can bet " + probes + " on line with the limit!" + Environment.NewLine);

                                    probes += 1;

                                Console.ForegroundColor = ConsoleColor.Red;
                                }
                            }

                            bux = bux - (bet * 2); // Calculating formula for CSGO500
                            bet *= 2;
                            probes += 1;

                     
                            Console.WriteLine( probes + " try = " + bet);


                        }
                        
                        else { // after calculating turn off bool and show message with info
                            Console.ResetColor();
                        isHaveMoney = false; // set bool to false, end cycle
                            Console.WriteLine(Environment.NewLine + "=============================");
                            Console.WriteLine("You can bet " + probes + " times on line without limit ;)");
                        }
                    }
                }
            }
        Console.ReadKey(); // "Please press any key to continue" :)
        }
    }
}
