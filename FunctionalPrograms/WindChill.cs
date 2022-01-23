using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
     public class WindChill
    {
      public void EffectiveTemp()
        {
            double v, t;
            Console.WriteLine("Enter the Temperature(in Fahrenheit)");
            v =Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Wind Speed(in miles per hour)");
            t = Convert.ToDouble(Console.ReadLine());
            double w = 35.74 + 0.6215 * t + (0.4275 * t - 35.75) * Math.Pow(v, 0.16);
            Console.WriteLine("The Effective Temperature :" + w + "\n");

        }
    }
}
