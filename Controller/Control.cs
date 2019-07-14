﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Controller
{
    public class Control
    {

        // Shown winrate per cycle 

        public static float GetWinrateByInfo(int probes) // Winrate calculator
        {

            const int MaxSpins = 33; // realize the constant 33
            int resultWinrate; // initialize the result

            resultWinrate = 100 * probes / MaxSpins; // percentage formula 

            Console.WriteLine($"Your winrate = {resultWinrate}% per cycle"); // show the info


            return resultWinrate; // return result
        }

        // Check Developer Permission for currently session

        public static string CheckPermission()
        {

            // #TODO Utility checker permission in session.
            return "unknown";
        }

        public static void ClearConsole()
        {

            Console.WriteLine("Clear the console...");
            Thread.Sleep(100);
            Console.Clear();
                   
        }

    }
}
