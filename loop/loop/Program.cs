using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop
{
    class Program
    {
        static void Main(string[] args)
        {


            /*

           */


            //  for (variable initialization; condition; steps)
            //  {
            //       execute this code block as long as condition is satisfied
            //   }
            
            int x = 5;
            Console.WriteLine(x > 3 && x < 1);


            //while loop
            
            int i = 0;

            while (i < 10)
            {
                Console.WriteLine("Value of i: {0}", i);

                i++;
            }
            int a = 10;

            /* while loop execution */
            while (a < 20)
            {
                Console.WriteLine("value of a: {0}", a);
                a++;
            }
            Console.ReadLine();

        }
    }
}
