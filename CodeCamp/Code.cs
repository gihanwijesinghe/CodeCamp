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
            Console.WriteLine("Execute");
            var value = 20;

            var array = new int[value-1];

            var allFactors = new Dictionary<int, int>();
            for (var i = 0; i <array.Length; i++)
            {
                array[i] = i+1;
            }

            var algo = new Alogorithms();
            var lcm = algo.GetLeastCommonMultiple(array);

            Console.WriteLine("Result "+lcm);
        }
    }
}
