using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void prime(int num) {
        for (int z = 2; z <= num/2; z++) {
            if (num <= 1) {
                return false;
            }
            else if (num % z == 0) {
                return false;
            }
            else {
              return true;  
            }
        }
    }
    
    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < t; a0++){
            long n = Convert.ToInt64(Console.ReadLine());
            long largestPrime = 0;
            for (int i = n/2; n >= 2; i--) {
                if (number % i == 0 && prime(i)) {
                    largestPrime = i;
                }
            }
            Console.WriteLine(largestPrime);
        }
    }
}
