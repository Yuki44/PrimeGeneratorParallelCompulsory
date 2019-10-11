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

        //public List<long> GetPrimesParallel(long first, long last)
        //{
        //    var lockObject = new Object();
        //    IEnumerable<long> primeNumbers = new List<long>();
        //    Parallel.ForEach(
        //        Partitioner.Create(first, last),
        //        () => new List<long>(),
        //        (range, loopState, partialResult) => {
        //            for (long i = range.Item1; i < range.Item2; i++)
        //            {
        //                if (IsPrime(i))
        //                    partialResult.Add(i);
        //            }
        //            return partialResult;
        //        },
        //        (partialResult) => {
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
