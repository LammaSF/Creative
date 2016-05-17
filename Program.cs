using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numto100string_SoftUni_SC_Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string[] tens = new string[] { "eleven","twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] chislo = new string[] { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine","ten" };
            string[] deset = new string[] { "twenty", "thirty", "fourty", "fifty", "sixty", "eighty", "ninety" };
           
            int leng = num.ToString().Length;
            if (leng<2)
            {
                Console.WriteLine(num.ToString(chislo));

            }
            
        }
    }
}
