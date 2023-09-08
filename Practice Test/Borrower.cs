using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Test
{
    public class Borrower
    {
        public string name { get; set; }
        public int Dti { get; set; }
        public int properties { get; set; }

        public static string DivideNumber(string num1, string num2)
        {
            double numerator = 0;
            double denominator = 0;

            if (!double.TryParse(num1, out numerator) || !double.TryParse(num2, out denominator))
            {
                return "bad data";
            }

            try
            {
                return (numerator / denominator).ToString();
            }
            catch(DivideByZeroException) 
            {
                return "infinity";
            }
        }
    }
}
