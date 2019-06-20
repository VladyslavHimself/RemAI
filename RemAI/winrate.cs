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

            const int MaxSpins = 33;
            int resultWinrate;

            resultWinrate = 100 * probes / MaxSpins;

            Console.WriteLine($"Your winrate = {resultWinrate}% per cycle");


            return resultWinrate;
        }

    }
}
