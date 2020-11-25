using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condition
{
    class Program
    {
        static void Main(string[] args)
        {
            /*condiction dicleration*/ 
            Console.WriteLine("choose your fast integer number a ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("choose your second integer number b ");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a>b)
            {
                Console.WriteLine("{0} is bigger then {1} ",a);
            }
            else
            {
                Console.WriteLine("{1} is a bigger than {0} ",b);
            }


            Console.ReadKey();
        }
    }
}
