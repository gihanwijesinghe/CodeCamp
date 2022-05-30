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
            var stringSeparated = "4 3 2 1";
            var q = new List<int>();
            foreach (var item in stringSeparated.Split(" "))
            {
                q.Add(int.Parse(item.ToString()));

            }

            Console.WriteLine("Execute  ");

            var total = 0;

            var previou = q[0];
            var groupCount = 0;
            for(var i = 0; i < q.Count; i++)
            {
                if(previou-q[i]  == 1)
                {
                    groupCount++;
                }
                else 
                {
                    if(groupCount > 0)
                    {
                        var innerCout = ((groupCount + 1) * (groupCount + 2) / 2)-(groupCount+1);
                        total += innerCout;
                        groupCount = 0;
                    }
                    
                    
                }
                previou = q[i];
            }

            if (groupCount > 0)
            {
                var innerCout = ((groupCount + 1) * (groupCount + 2) / 2) - (groupCount + 1);
                total += innerCout;
            }

            total += q.Count();

            Console.WriteLine("total  "+total);
        }
    }
}
