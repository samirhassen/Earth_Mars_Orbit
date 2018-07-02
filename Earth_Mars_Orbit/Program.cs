using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Earth_Mars_Orbit
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please input Earth's and Mars' current orbit day (ex: 364 686)");
            string inp;
            int currentItr = 1;
            string printResult = "";
            while (!string.IsNullOrWhiteSpace(inp = Console.ReadLine()) && currentItr < 10)
            {
                string[] tokens = inp.Split(' ');
                int earth = 0;
                int mars = 0;
                Int32.TryParse(tokens[0], out earth);
                Int32.TryParse(tokens[1], out mars);

                int diff = 0;
                while (earth != 0 || mars != 0)
                {
                    diff += 1;
                    earth = (earth + 1) % 365;
                    mars = (mars + 1) % 687;
                }

                printResult = printResult + "Case " + currentItr + ": " + diff + Environment.NewLine;

                currentItr++;
            }

            Console.WriteLine(printResult);
            Console.ReadLine();
        }
    }
}
