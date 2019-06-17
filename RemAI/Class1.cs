using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemAI
{
    class Daily
    {
        public static void toCollectDaily()
        {

            DateTime data_start = DateTime.Now, data_process;
            Console.WriteLine("Now is " + data_start);
            Console.WriteLine("Enter Data process ");
            string s1 = Console.ReadLine();
            data_process = Convert.ToDateTime(s1);
            System.TimeSpan result = data_process - data_start;

            Console.WriteLine("Осталось " + (data_process.Date - data_start.Date) + " Дней");
            Console.WriteLine("За это время вы получите " + (data_process.DayOfYear - data_start.DayOfYear) * 25 + " очков");
            Console.ReadKey();


        }

       
    }
}
