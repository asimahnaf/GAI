using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    class Program
    {
        //static void Main()
        //{
        //    sayhi();
        //    Console.ReadLine();
        //}

        static void sayhi()
        {
            Console.WriteLine("hello gay");
        }

        public int ahnaf(int a, int b)
        {

            int c = a + b;
            return c;
        }
        static void Main(string[] args)

        {


            Program n = new Program();
            int a = 10, b = 20, d;
            d = n.ahnaf(a, b);

            Console.WriteLine(d);



            Console.ReadKey();
        }

    }
}
