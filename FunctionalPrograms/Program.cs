using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                flag = true;
                while (flag)
                {
                    Console.WriteLine("Enter 1 to enter for two dimensional array\n"
                        +"Enter 2 to Find Distinct triplet whose Sum is equal to zero\n"+
                        "Enter 3 to find the distance between two given points\n"+"Enter 4 to find the Quadratic roots\n"
                        +"Enter 5 to find the Effective Temperature\n"+"Enter 6 to Exit\n");
                    int n=Convert.ToInt32(Console.ReadLine());
                    switch (n)
                    {
                        case 1:
                            TwoDimesionalArray twoDimesionalArray = new TwoDimesionalArray();
                            twoDimesionalArray.Inp();
                            break;
                        case 2:
                            SumZero sumZero = new SumZero();
                            sumZero.SumofThreeZero();
                            break;
                        case 3:
                            Distance distance = new Distance();
                            distance.Calculate();
                            break;
                        case 4:
                            QuadraticRoots quadraticRoots = new QuadraticRoots();
                            quadraticRoots.Find();
                            break;
                        case 5:
                            WindChill windChill = new WindChill();
                            windChill.EffectiveTemp();
                            break;
                        case 6:
                            flag = false;
                            break;
                        default:
                            Console.WriteLine("Please enter the correct option\n");
                            break;

                    }

                }
            }
        }

    }
}
