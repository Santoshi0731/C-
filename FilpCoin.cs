using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class FlipCoin
    {
        public static void FlipTheCoin()
        {
            int tailcount = 0;
            int headcount = 0;


            Console.WriteLine("Enter the number of flips");
            int flip =Convert.ToInt32(Console.ReadLine());

            if (flip > 0)
            {
                for (int i = 0; i < flip; i++)
                {
                    Random num = new Random();
                    //Console.WriteLine(num.Next(0,2));
                    int result = num.Next(0, 2);

                    if (result == 0)
                    {
                        tailcount++;
                    }
                    else
                    {
                        headcount++;
                    }

                }
                Console.WriteLine("HeadCount is " + headcount);
                Console.WriteLine("TailCount is " + tailcount);

              
            }
            else
            {
                Console.WriteLine("Please Enter the correct value");
            }
            
        
        }

    }
}
