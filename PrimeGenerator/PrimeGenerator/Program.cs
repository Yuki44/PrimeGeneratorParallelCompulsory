using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Documents;
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
        

        public List<long> GetPrimesSequential(long first, long last)
        {
            // Using a nearly optimal trial division sieve
            return Enumerable.Range(0, (int)Math.Floor(2.52 * Math.Sqrt((int)last) / Math.Log((int)last))).Aggregate(
                Enumerable.Range(2, (int)last - 1).ToList(),
                (result, index) =>
                {
                    var bp = result[index]; var sqr = bp * bp;
                    result.RemoveAll(i => i >= sqr && i % bp == 0);
                    return result;
                }
                ).ConvertAll(i => (long)i);
        }

        //Sieve of Eratosthenes
        public List<long> GetPrimesSieveOfEratosthenes(long start, long end)
        {
            List<long> primes = new List<long>();
            bool[] is_prime = new bool[end + 1];
            if (start <= 2)
            {
                for (long i = 2; i <= end; i++)
                {
                    is_prime[i] = true;
                }
                // Cross out multiples.
                for (long i = 2; i <= end; i++)
                {
                    // See if i is prime.
                    if (is_prime[i])
                    {
                        // Knock out multiples of i.
                        for (long j = i * 2; j <= end; j += i)
                            is_prime[j] = false;
                    }
                }
            }
            else
            {
                for (long i = start; i <= end; i++)
                {
                    is_prime[i] = true;
                }
                for (long i = start; i <= end; i++)
                {
                    if (is_prime[i])
                    {
                        for (long j = i * 2; j <= end; j += i)
                            is_prime[j] = false;
                    }
                }
            }
            
            return primes;
        }

        //public List<long> GetPrimesParallel(long first, long last)
        //{
        //    var lockObject = new Object();
        //    IEnumerable<long> primeNumbers = new List<long>();
        //    Parallel.ForEach(
        //        Partitioner.Create(first, last),
        //        () => new List<long>(),
        //        (range, loopState, partialResult) =>
        //        {
        //            for (long i = range.Item1; i < range.Item2; i++)
        //            {
        //                if (IsPrime(i))
        //                    partialResult.Add(i);
        //            }
        //            return partialResult;
        //        },
        //        (partialResult) =>
        //        {
        //            lock (lockObject)
        //            {
        //                primeNumbers = primeNumbers.Concat(partialResult);
        //            }
        //        }
        //        );
        //    return primeNumbers.OrderBy(s => s).ToList();
        //}
    }
}
