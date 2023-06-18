using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace RickandMorty
{
    public class Riddle
    {
        static bool IsPrime(int number)
        {
            if (number < 2)
                return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }

        public static List<int> Answer()
        {

            List<int> primes = new List<int>();

            Parallel.For(2, 1001, i =>
            {
                if (IsPrime(i))
                    lock (primes)
                    {
                        primes.Add(i);
                    }
            });

            primes.Sort();
            return primes;
        }
    }
}