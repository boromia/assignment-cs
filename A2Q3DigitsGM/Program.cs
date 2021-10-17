// Name: Gazi Shafqat Mahmud
// Date: Oct 6, 2021
// Title:
// Purpose:

// Comment: None
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2Q3DigitsGM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a three digits number: ");
            int inputNumber = Convert.ToInt32(Console.ReadLine());


            int ones = (inputNumber / 1) % 10;
            int tens = (inputNumber / 10) % 10;
            int hundred = (inputNumber / 100) % 10;

            Console.WriteLine("The hundreds-place digit is: " + hundred);
            Console.WriteLine("The tens-place digit is: " + tens);
            Console.WriteLine("The ones-place digit is: " + ones);
            Console.ReadKey();
        }
    }
}
