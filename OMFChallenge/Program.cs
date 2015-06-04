using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMFChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] keys = {8,4,8,9,16,1,14,7,19,3,0,5,2,11,6};
            //order by size and eliminate duplicates
            int[] orderedKeys = keys.OrderBy(x => x).Distinct().ToArray();

            for (int i = 1; i < orderedKeys.Length; i++)
            {
                //grab previous number and current
                int previousNum = orderedKeys[i - 1];
                int currentNum = orderedKeys[i];
                if (currentNum == previousNum + 1)
                {
                    
                }
                else
                {
                    Console.WriteLine(currentNum - 1);
                    Console.ReadKey();
                }
            }
        }
    }
}
