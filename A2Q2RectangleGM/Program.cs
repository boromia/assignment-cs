// Name: Gazi Shafqat Mahmud
// Date: Oct 6,2021
// Title: 
// Purpose:

// Comment: None
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2Q2RectangleGM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the rectangle: ");
            int length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the width of the rectangle: ");
            int width = Convert.ToInt32(Console.ReadLine());

            //Area of the rectangle is length x width
            float area = length * width;

            //Perimeter of the rectangle is 2(length + width)
            float perimeter = 2 * (length * width);

            Console.WriteLine("Area of the rectangle is :" + area);
            Console.WriteLine("Perimeter of the rectangle is :" + area);

            Console.ReadKey();
        }
    }
}

