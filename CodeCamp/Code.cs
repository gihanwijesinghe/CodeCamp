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
            var threshold = 25;
            var bootingStringSeparated = "3 6 1 3 4 1 1 1 1 1";
            var processingStringSeparated = "2 1 3 4 5 1 1 1 1 1";

            //var threshold = 33;
            //var bootingStringSeparated = "8 8 10 9 12";
            //var processingStringSeparated = "4 1 4 5 3";

            //var threshold = 6;
            //var bootingStringSeparated = "10 8 7";
            //var processingStringSeparated = "11 12 11";


            var bootingPower = new List<int>();
            var processingPower = new List<int>();

            foreach (var item in bootingStringSeparated.Split(" "))
            {
                bootingPower.Add(int.Parse(item.ToString()));

            }
            foreach (var item in processingStringSeparated.Split(" "))
            {
                processingPower.Add(int.Parse(item.ToString()));

            }

            var maxProcessorsWithValueOne = (int)Math.Floor(Math.Sqrt(threshold - 1));

            var guessValue = (maxProcessorsWithValueOne+1) / 2;

            var minPivot = 0;
            var maxPivot = maxProcessorsWithValueOne;

            var exactValue = 0;

            while (maxPivot - minPivot > 0)
            {
                var bootingQueue = new Queue<int>();
                var processingQueue = new Queue<int>();

                var isClusterConsumable = false;

                for(int i = 0; i < bootingPower.Count(); i++)
                {
                    bootingQueue.Enqueue(bootingPower[i]);
                    processingQueue.Enqueue(processingPower[i]);

                    if(bootingQueue.Count() > guessValue)
                    {
                        bootingQueue.Dequeue();
                        processingQueue.Dequeue();
                    }

                    if(bootingQueue.Count() == guessValue)
                    {
                        var bootingMax = bootingQueue.Max();
                        var processingSum = processingQueue.Sum();

                        var newPower = bootingMax + (processingSum*guessValue);

                        if(newPower <= threshold)
                        {
                            isClusterConsumable = true;
                            exactValue = guessValue;
                            minPivot = guessValue;

                            if (maxPivot == minPivot)
                            {
                                break;
                            }

                            if (maxPivot - minPivot == 1)
                            {
                                if (maxPivot != maxProcessorsWithValueOne)
                                {
                                    minPivot = maxPivot;
                                    break;
                                }
                                
                            }
                            guessValue = minPivot + (((maxPivot + 1) - minPivot) / 2);
                            

                            break;
                        }
                        
                    }
                }

                if (!isClusterConsumable)
                {
                    maxPivot = guessValue;

                    if(maxPivot - minPivot == 1)
                    {
                        maxPivot = minPivot;
                    }
                    else
                    {
                        guessValue = minPivot + (((maxPivot + 1) - minPivot) / 2);
                        exactValue = guessValue;
                    }
                }
            }



            Console.WriteLine("Result  " + exactValue);

        }
    }
}
