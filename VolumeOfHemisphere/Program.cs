using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolumeOfHemisphere
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("Enter the radius of a hemisphere: " );
            //this is the code that gets the information that is needed for r
            double r = Double.Parse(Console.ReadLine());
            //r is the radius
            double r3 = r * r * r;
            //r3 is the radius squared
            double Volume = (2 / 3.0) * (Math.PI) * r3;
            // in (2/3.0) the 3.0 was to make the fraction a double otherwise it 2/3 = 0 and 0 * Math.Pi = 0 and then 0 * r3 = 0 so 
            // it always returned 0 unless you put the 2/3 after Math.PI because Math.PI is a double thus making 2/3 a double when you 
            //multiplied the two.

            Console.WriteLine($"The volume of this hemisphere is: {Volume}");

            Console.ReadLine();

        }
    }
}
