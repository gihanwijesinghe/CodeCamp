using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCamp
{
    public class Helper
    {
        public int[] GetIntArrayFromString(string s)
        {
            var items = s.Split(' ');
            var array = new int[items.Length];

            for(int i = 0; i < items.Length; i++)
            {
                array[i] = Convert.ToInt32(items[i]);
            }
            return array;
        }

        public int[][] GetInt2DArrayFromStringArray(string[] sa)
        {
            var array = new int[sa.Length][];
            for(int i = 0; i < sa.Length; i++)
            {
                array[i] = GetIntArrayFromString(sa[i]);
            }

            return array;
        }
    }
}
