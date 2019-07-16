using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemAI
{
    class DailyRewardFoo
    {
        public static void ToCalculateDailyPerDate()
        {



            Console.WriteLine("Please enter first date");
            string sfirst;
            sfirst = Console.ReadLine();
            DateTime Sf1 = Convert.ToDateTime(sfirst);

            Console.WriteLine("Today is " + Sf1);
            Console.WriteLine("Please enter data process");

            string s1;
            s1 = Console.ReadLine();
            DateTime data_proc = Convert.ToDateTime(s1);
            DayOfWeek w1 = DayOfWeek.Sunday;
            DayOfWeek w2 = DayOfWeek.Saturday;
            Console.WriteLine(data_proc.DayOfYear - Sf1.DayOfYear);
            double w1k = Convert.ToDouble(w1);
            double w2k = Convert.ToDouble(w2);
            int n = (data_proc.DayOfYear - Sf1.DayOfYear);

            int[] nums = new int[100];
            int[] nums1 = new int[100];
            for (int i = 0; i <= n; i++)
            {
                int n1 = 1;
                if (Sf1.Date.AddDays(i).DayOfWeek == DayOfWeek.Saturday || Sf1.Date.AddDays(i).DayOfWeek == DayOfWeek.Sunday)
                {   //Console.WriteLine(Sf1.Date.AddDays(i));
                    // Console.WriteLine(Sf1.Date.AddDays(i).ToString("dddd"));
                    //Console.WriteLine(n1 * 50);
                    nums[n] += n1 * 50;
                }

                else
                {



                    //Console.WriteLine(Sf1.Date.AddDays(i).ToString("dddd"));
                    nums1[n] += n1 * 25;

                }

            }


            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Result is " + (nums[n] + nums1[n]));
            Console.ResetColor();
          
            Console.ReadKey();
        }
    }
}

