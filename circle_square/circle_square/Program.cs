using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circle_area
{
    class Program
    {
        static void Main(string[] args)
        {
             float pi= 3.1416f;
             Console.WriteLine("add your circle redius number");
             float r = float.Parse(Console.ReadLine());
             float R = r * r * pi;

             Console.WriteLine("Area of the circle is: " + (R)); 
           
            
            
        }
    }
}
