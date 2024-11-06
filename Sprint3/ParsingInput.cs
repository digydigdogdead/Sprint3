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

            // Checks if user wants a Char array:
            Console.WriteLine("Respond 'True' if you would like the answer in a character array, or 'false' if you wouldn't.");
            string charArrayQuestionResponse = Console.ReadLine();
            bool dump;
            while (!Boolean.TryParse(charArrayQuestionResponse, out dump))
            {
                Console.WriteLine("Not a valid answer, try again.");
                charArrayQuestionResponse = Console.ReadLine();
            }
            
            bool wantsCharArray = Convert.ToBoolean(charArrayQuestionResponse);

            if (wantsCharArray)
            {
                char[] resultArray = convertedDivisionResult.ToString().ToCharArray();
                foreach (char c in resultArray) { Console.WriteLine(c); }
            }
            else
            {
                Console.WriteLine($"Result: {convertedDivisionResult}");
            }


        }
    }
}
