// Name: Gazi Shafqat Mahmud
// Date: Oct 6, 2021
// Title: 
// Purpose:

// Comment:None
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2Q1ChangeGM
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variable Declaration 

            int changeInCents = 212;
            // Type your username and press enter
            Console.WriteLine("Enter the change in cents: ");

            // Create a int variable and get user input from the keyboard and store it in the variable
            changeInCents = Convert.ToInt32(Console.ReadLine());

            changeMaker(changeInCents);


        }

        static void changeMaker(int change)
        {
            int quarters = change / 25;
            int remainder = change - quarters * 25;
            int dimes = remainder / 10;
            remainder = remainder - dimes * 10;
            int nickels = remainder / 5;
            int pennies = remainder - nickels * 5;

            Console.Write("The minimum number of coins is: \n");
            Console.Write("Quarters: " + quarters + "\n");
            Console.Write("Dimes: " + dimes + "\n");
            Console.Write("Nickels: " + nickels + "\n");
            Console.Write("Pennies: " + pennies + "\n");

            Console.ReadKey();
        }


    }
}
