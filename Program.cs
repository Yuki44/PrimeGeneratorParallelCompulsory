using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeGenerator
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        private static List<long> GetPrimesSequential(long first, long last)
        {
            List<long> primes = new List<long>();

            for (long num = first; num <= last; num++)
            {
                var ctr = 0;

                for (long i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        ctr++;
                        break;
                    }
                }
                if(ctr==0 && num!= 1)
                    primes.Add(num);
            }
            return primes;
        }
    }
}
