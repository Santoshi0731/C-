using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class LeapYear
    {
        public static void LeapYear1()
        {
           
            Console.WriteLine("Enter the Year");
            int year = Convert.ToInt32(Console.ReadLine());


            if ((year % 400 == 0) || (year % 4 == 0) && (year % 100 != 0))
            {
                Console.WriteLine("Its Leap Year");
            }
            else
            {
                Console.WriteLine("Its Not Leap Year");
                
            }
        }
    }
}
    