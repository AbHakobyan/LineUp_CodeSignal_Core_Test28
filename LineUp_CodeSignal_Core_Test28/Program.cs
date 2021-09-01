using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineUp_CodeSignal_Core_Test28
{
    class Program
    {
        static void Main(string[] args)
        {
            string commands = "LLARL";
            int result = lineUp(commands);
            Console.WriteLine(result);
            
        }

        static int lineUp(string commands)
        {
            int count = 0;
            int result = 0;
            for (int i = 0; i < commands.Length; i++)
            {
                if (commands.ElementAt(i) == 'L' || commands.ElementAt(i) == 'R')
                {
                    count++;
                }
                if (count % 2 == 0)
                {
                    result++;
                }
            }
            return result;
        }
    }
}
