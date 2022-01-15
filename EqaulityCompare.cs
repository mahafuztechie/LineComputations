using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComputation
{
    class EqaulityCompare : LineDistance
    {
        double dis1, dis2, dis3;
        public void CheckEquals()
        {

            Input ip1 = new Input();
            dis1 = ip1.userIP();


            Input ip2 = new Input();
            dis2 = ip1.userIP();



            Input ip3 = new Input();
            dis3 = ip1.userIP();
            CompareEquals(dis1, dis2, dis3);
            CompareLine(dis1, dis2, dis3);
        }
        public  void CompareEquals(double dis1, double dis2, double dis3)
        {
            if (dis1.Equals(dis2))
            {
                Console.WriteLine("lines one and two are equal");
            }
            else if (dis2.Equals(dis3))
            {
                Console.WriteLine("lines two and three are equal");
            }
            else if (dis1.Equals(dis3))
            {
                Console.WriteLine("lines one and three are equal");
            }
            else
            {
                Console.WriteLine("Lines are not Equal");
            }
        }
       
    }
}
