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
            var algebra = new AlgebraFucntions();

            var val1 = algebra.GetSumOfArithmeticSeries(100);
            var val2 = algebra.GetSumOfSquareSeries(100);

            var result = (val1 * val1) - val2;
            Console.WriteLine("Result  "+ result);
        }
    }
}
