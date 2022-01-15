using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComputation
{
    public class LineDistance
    {

        public static void CompareLine(double dis1, double dis2, double dis3)
        {
            /*
            if (dis1.CompareTo(dis2) > 0)
            {
                Console.WriteLine("line one is greater than line two and three");
            }
            else if (dis1.CompareTo(dis2) > 0 )
            {
                Console.WriteLine("Both Lines are Equals");
            }
            else if (dis2.CompareTo(dis3) > 0)
            {
                Console.WriteLine("Both Lines are Equals");
            }
            else
            {
                Console.WriteLine("Line one is less than line two");
            }
            */


            if (dis1 > dis2 && dis1 > dis3)
            {
                Console.WriteLine("line one is greater than line two and three");
            }
            else if (dis2>dis3)
            {
                Console.WriteLine("line two is greater than three");
            }
            else
            {
                Console.WriteLine("Line three is greter than two");
            }


            if (dis1 < dis2 && dis1 < dis3)
            {
                Console.WriteLine("line one is lesser than line two and three");
            }
            else if (dis2 < dis3)
            {
                Console.WriteLine("line two is lesser than three ");
            }
            else
            {
                Console.WriteLine("Line three is lesser two");
            }



        }
    }
}
