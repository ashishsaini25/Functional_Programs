using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    public class QuadraticRoots
    {
        public void Find()
        {
            Console.WriteLine("Enter the a,b,c from ax^2+bx+c=0 ");
            double  a, b, c;
            string  input=Console.ReadLine();
            string[] inp=input.Split(' ');
            a = int.Parse(inp[0]);
            b=int.Parse(inp[1]);
            c = int.Parse(inp[2]);
            Double Discriminant = Math.Sqrt(b * b - 4*a*c);
            if(Discriminant < 0)
            {
                Console.WriteLine("Roots are Imaginary\n");
            }
            else
            {
                double alpha = (-b + Discriminant) / 2 * a;
                double beta = (-b - Discriminant) / 2 * a;
                Console.WriteLine("The roots are :" + alpha + " " + beta + "\n");
            }
        }
    }
}
