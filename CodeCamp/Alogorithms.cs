using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCamp
{
    public class Alogorithms
    {
        public Dictionary<int, int> GetPrimeFactors(int num)
        {
            var value = num;

            var divider = 2;
            var nextDivider = value / 2;
            var primefactors = new Dictionary<int, int>();

            while (divider <= nextDivider)
            {
                if (value % divider == 0)
                {
                    if (primefactors.ContainsKey(divider))
                    {
                        primefactors[divider] = primefactors[divider] + 1;
                    }
                    else
                    {
                        primefactors.Add(divider, 1);
                    }
                    value = value / divider;
                    nextDivider = value / divider;
                }
                else
                {
                    nextDivider = value / divider;
                    divider++;
                }
            }

            if (primefactors.ContainsKey(value))
            {
                primefactors[value] = primefactors[value] + 1;
            }
            else
            {
                primefactors.Add(value, 1);
            }

            return primefactors;
        }

        public int GetLeastCommonMultiple(int[] array)
        {
            var lcm = 1;

            var allFactors = new Dictionary<int, int>();

            foreach(var item in array)
            {
                var innerFactors = GetPrimeFactors(item);

                foreach (var ifa in innerFactors)
                {
                    if (allFactors.ContainsKey(ifa.Key))
                    {
                        if (allFactors[ifa.Key] < ifa.Value)
                        {
                            lcm = lcm * (int)Math.Pow(ifa.Key, (ifa.Value - allFactors[ifa.Key]));
                            allFactors[ifa.Key] = ifa.Value;

                        }

                    }
                    else
                    {
                        allFactors.Add(ifa.Key, ifa.Value);
                        lcm = lcm * (int)Math.Pow(ifa.Key, ifa.Value);
                    }

                }
            }

            return lcm;
        }
    }
}
