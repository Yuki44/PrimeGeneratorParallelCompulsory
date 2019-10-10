using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeGenerator
{
    public class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PrimeNumbersGenerator());
        }

        private Boolean IsPrime(long number)
        {
            if ((int)number == 1 || (int)number == 0) return false;
            for (int i = 2; i <= number / 2; i++)
            {
                if (((int)number % i) == 0) return false;
            }
            return true;
        }

        public List<long> GetPrimesSequential(long first, long last)
        {
            List<long> primeNumbers = new List<long>();
            for (long i = first; i < last; i++)
            {
                if (IsPrime(i)) primeNumbers.Add(i);
            }
           return primeNumbers;
        }

        public List<long> GetPrimesParallel(long first, long last)
        {
            List<long> primeNumbers = new List<long>();
            Parallel.ForEach(
                Partitioner.Create(first, last),
                () => new List<long>(),
                (Tuple<long, long> range, ParallelLoopState state, List<long> localPrimes) =>
                {
                    for (int i = (int)range.Item1; i < range.Item2; i++)
                    {
                        if (IsPrime(i)) localPrimes.Add(i);
                    }
                    return localPrimes;
                },
                (localPrimes) =>
                {
                    lock (primeNumbers)
                    {
                        primeNumbers.AddRange(localPrimes);
                    }
                });
            primeNumbers.Sort();
            return primeNumbers;
        }
    }
}
