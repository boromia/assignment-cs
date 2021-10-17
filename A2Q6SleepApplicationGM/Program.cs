// Name: Gazi Shafqat Mahmud
// Date: Oct 6, 2021
// Title:
// Purpose:

//Comment: None
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2Q6SleepApplicationGM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your birth year: ");
            Console.WriteLine("Year: ");

            int birthYear = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Month: ");
            int birthMonth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Day: ");
            int birthDay = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter today's Date: ");
            Console.WriteLine("Year: ");

            int todayYear = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Month: ");
            int todayMonth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Day: ");
            int todayDay = Convert.ToInt32(Console.ReadLine());

            String birthDate = birthYear + "-" + birthMonth + "-" + birthDay;
            String todaysDate = todayYear + "-" + todayMonth + "-" + todayDay;


            DateTime dtBirthDate;
            DateTime dtTodayDate;

            Console.WriteLine("Enter Date in this Format(YYYY-MM-DD): ");

            dtBirthDate = Convert.ToDateTime(birthDate);
            dtTodayDate = Convert.ToDateTime(todaysDate);

            double totalDaysAlive = (dtTodayDate - dtBirthDate).TotalDays;


            Console.WriteLine("You have been alive for : " + totalDaysAlive + " days");

            int numberOfSleepHours = 8;
            double totalSleepHours = numberOfSleepHours * totalDaysAlive;

            Console.WriteLine("you have slept for: " + totalSleepHours + " hours");

            Console.ReadKey();
        }
    }
}
