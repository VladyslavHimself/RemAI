using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemAI
{

    class Winrate
    {
       
        public static float toCalculateWinrate(int probes)
        {

            const int MaxSpins = 33; // realize the constant 33
            int resultWinrate; // initialize the result

            resultWinrate = 100 * probes / MaxSpins; // percentage formula 

            Console.WriteLine($"Your winrate = {resultWinrate}% per cycle"); // show the info


            return resultWinrate; // return result
        }

    }
}
