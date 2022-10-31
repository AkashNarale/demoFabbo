using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabbonaci
{
    class Fabbonaci : Class1
    {
        public override void fibbo()
        {
            Console.WriteLine("enter the count");
            int count = Convert.ToInt32(Console.ReadLine());

            int n1 = 1, n2 = 2, n3;
            for (int i = 1; i < count; i++)
            {
                n3 = n1 + n2;
                Console.WriteLine(" " + n3);
                n1 = n2;
                n2 = n3;
            }
        }
    }
}
