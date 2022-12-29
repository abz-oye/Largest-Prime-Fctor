using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static bool isPrime(long number)
    {
        if (number <= 1) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;

        var boundary = (long)Math.Floor(Math.Sqrt(number));

        for (long i = 3; i <= boundary; i += 2) {
            if (number % i == 0) {
                return false; 
            }
        }
        return true;
    }

    static void Main(String[] args)
    {
        long t = Convert.ToInt64(Console.ReadLine());
        for (long a0 = 0; a0 < t; a0++)
        {
            long n = Convert.ToInt64(Console.ReadLine());
            List<long> factors = new List<long>();
            List<long> primeFactors = new List<long>();
            long max = 0;

            for (long i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    factors.Add(i);
                }
            }
            foreach (long z in factors)
            {
                if (isPrime(z) == true)
                {
                    primeFactors.Add(z);
                }
                
            }
            max = primeFactors.OrderByDescending(t => t).First();
            Console.WriteLine(max);         
        }
    }
}
