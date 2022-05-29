using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCamp
{
    public class Code
    {
        public void Execute()
        {
            Console.WriteLine("Execute  ");
            var algo = new Algorithms();
            
            var term = 2;
            var primeCount = 0;
            var maxTerm = 10001;

            //2,3,5,7,11,13
            while (primeCount < maxTerm)
            {
                var reslt = algo.IsPrimeNumber(term);
                if (reslt)
                {
                    primeCount++;
                }
                term++;
            }
            Console.WriteLine("Result  " +(term-1));
        }
    }
}
