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

namespace A2Q4WeightsGM
{
    class Program
    {
        static void Main(string[] args)
        {

            // Variable Declaration 

            string strUserName, strUser;
            double dblUserWeight;
            double dblEarthWeight, dblMercuryWeight, dblVenusWeight;
            double dblMarsWeight, dblJupiterWeight, dblSaturnWeight;
            double dblUranusWeight, dblNeptuneWeight, dblPlutoWeight;


            // Input

            Console.WriteLine("Please Enter Your Name");
            strUser=Console.ReadLine();
            strUserName = strUser;
            Console.WriteLine("\n");

            Console.WriteLine("Please Enter Your Weight in Kg");
            dblUserWeight = Convert.ToDouble(Console.ReadLine());



            // Process 

            dblEarthWeight = dblUserWeight * 1;
            dblJupiterWeight = dblUserWeight * 2.6;
            dblMercuryWeight = dblUserWeight * 0.38;
            dblUranusWeight = dblUserWeight * 0.90;
            dblSaturnWeight = dblUserWeight * 1.1;
            dblNeptuneWeight = dblUserWeight * 1.1;
            dblMarsWeight = dblUserWeight * 0.38;
            dblPlutoWeight = dblUserWeight * 0.07;
            dblVenusWeight = dblUserWeight * 0.91;

            // Output

            Console.WriteLine("Earth is " + dblEarthWeight + "");
            Console.WriteLine("Jupiter will be " + dblJupiterWeight + "");
            Console.WriteLine("Mercury will be " + dblMercuryWeight + "");
            Console.WriteLine("Uranus will be " + dblUranusWeight + "");
            Console.WriteLine("Saturn will be " + dblSaturnWeight + "");
            Console.WriteLine("Neptune will be " + dblNeptuneWeight + "");
            Console.WriteLine("Mars will be " + dblMarsWeight + "");
            Console.WriteLine("Pluto will be " + dblPlutoWeight + "");
            Console.WriteLine("Venus will be " + dblVenusWeight + "");
            Console.ReadKey();


        }
    }
}
