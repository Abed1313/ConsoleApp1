using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Class1
    {
        public static void NumParser(string input)
        {
            bool sucsess = Int32.TryParse(input, out var output);

            if (sucsess == true)
            {
                Console.WriteLine($"Susessfuly Parsed {input} to {output}");
            }
            else
            {
                Console.WriteLine($"Uneble Parsed {input}");
            }
        }
    }
}
