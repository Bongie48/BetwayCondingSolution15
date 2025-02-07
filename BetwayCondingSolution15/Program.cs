using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetwayCondingSolution15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] outcomes = { 123456, 234567, 123347, 456789, 567890, 678901, 789012, 890123, 901234, 112233, 223344, 334455, 789012, 222234, 123347 };
            int[] duplicates = FindDuplicates(outcomes);
            Console.WriteLine($"[{duplicates[0]}, {duplicates[1]}]");
            Console.ReadLine();
        }
        static int[] FindDuplicates(int[] outcomes)
        {
            HashSet<int> seen = new HashSet<int>();
            List<int> duplicates = new List<int>();

            foreach (var outcome in outcomes)
            {
                if (seen.Contains(outcome))
                {
                    duplicates.Add(outcome);
                }
                else
                {
                    seen.Add(outcome);
                }
            }

            return duplicates.ToArray();
        }
    }
}
