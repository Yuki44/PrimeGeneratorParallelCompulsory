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

        public bool IsPrime(long number)
        {
            if (number % 2 == 0)
            {
                return false;
            }
            else
            {
                if (number == 1)
                {
                    return false;
                }
                for (int i = 3; i < number / 2; i += 2)
                {
                    if (number % i == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public List<long> GetPrimesSequential(long first, long last)
        {
            List<long> primeNumbers = new List<long>();
            for (long i = first; i < last; i++)
            {
                if (IsPrime(i))
                    primeNumbers.Add(i);
            }
            return primeNumbers;

        }

        public List<long> GetPrimesParallel(long first, long last)
        {
            var lockObject = new Object();
            IEnumerable<long> primeNumbers = new List<long>();
            Parallel.ForEach(
                Partitioner.Create(first, last),
                () => new List<long>(),
                (range, loopState, partialResult) =>
                {
                    for (long i = range.Item1; i < range.Item2; i++)
                    {
                        if (IsPrime(i))
                            partialResult.Add(i);
                    }
                    return partialResult;
                },
                (partialResult) =>
                {
                    lock (lockObject)
                    {
                        primeNumbers = primeNumbers.Concat(partialResult);
                    }
                }
                );
            return primeNumbers.OrderBy(s => s).ToList();
        }
    }
}
