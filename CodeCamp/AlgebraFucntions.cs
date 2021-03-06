using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCamp
{
    public class AlgebraFucntions
    {
        public int GetSumOfArithmeticSeries(int terms, int firstTerm = 1, int difference = 1)
        {
            //(n/2)*(2a +(n-1)d)
            return (terms * ((2 * firstTerm) + (difference * (terms - 1)))) / 2;
        }

        public int GetSumOfSquareSeries(int terms)
        {
            //(n/6)*(n+1)(2n+1)
            return (terms * (terms + 1) * ((terms * 2) + 1)) / 6;
        }

        public int GetSumOfGeometricSeries(int terms, int ratio, int firstTerm = 1)
        {
            //(a)*(1-r^n)/(1-r)
            return (firstTerm * (1 - (int)Math.Pow(ratio, terms))) / (1 - ratio);
        }

        public long GetProductOfArray(int [] array)
        {
            if(array == null || array.Length == 0)
            {
                return 0;
            }

            long result = 1;
            foreach (int i in array)
            {
                result *= i;
            }
            
            return result;
        }

        public long GetProductOfArray(string s)
        {
            if (s == null || s.Length == 0)
            {
                return 0;
            }

            long result = 1;
            foreach (var i in s)
            {
                var intValue = int.Parse(i.ToString());
                result *= intValue;
            }

            return result;
        }
    }
}
