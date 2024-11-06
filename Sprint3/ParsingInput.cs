using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint3
{
    internal class ParsingInput
    {
        public static void ReadFromUserAndParse()
        {
            Console.WriteLine("Enter integer:");
            int userInt = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter decimal:");
            decimal userDecimal = decimal.Parse(Console.ReadLine());
            double convertedDivisionResult = userInt / (double) userDecimal;
            Console.WriteLine($"Result: {convertedDivisionResult}");


        }
    }
}
