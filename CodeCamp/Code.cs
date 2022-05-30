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

            var threshold = 2000000;

            var  algo = new Algorithms();
            long sum = 0;

            for(int i = 2; i < threshold; i++)
            {
                var isPrimeNumber = algo.IsPrimeNumber(i);
                if (isPrimeNumber)
                {
                    sum += i;
                }
            }

            Console.WriteLine("Result  " + sum);
        }
    }
}
