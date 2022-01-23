using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    public class SumZero
    {
        public bool Sum(int first,int second, int third)
        {
            if (first + second + third == 0) return true;
            else return false;
        }
        public int [] Inp()
        {
            string numbers = Console.ReadLine();

            string[] myNumbers = numbers.Split(' ');

            int[] myInts = new int[myNumbers.Length];

            for (int i = 0; i < myInts.Length; i++)
            {
                string myString = myNumbers[i].Trim();
                myInts[i] = int.Parse(myString);
            }
            return myInts;
        }
        public void SumofThreeZero()
        {
            Console.WriteLine("Enter the  first array");
            int [] firstarr = Inp();
            Console.WriteLine("Enter the second array");
            int[] Secondarr = Inp();
            Console.WriteLine("Enter the third array");
            int[] Thirdarr = Inp();
            int freq = 0;
            for (int i = 0; i < firstarr.Length; i++)
            {
                for(int j=0;j < Secondarr.Length; j++)
                {
                    for (int k = 0; k < Thirdarr.Length; k++)
                    {
                        if (Sum(firstarr[i], Secondarr[j], Thirdarr[k])) freq++;
                    }

                }
            }
            Console.WriteLine("The Distinct Triplets are :" + freq);

            for (int i = 0; i < firstarr.Length; i++)
            {
                for (int j = 0; j < Secondarr.Length; j++)
                {
                    for (int k = 0; k < Thirdarr.Length; k++)
                    {
                        if (Sum(firstarr[i], Secondarr[j], Thirdarr[k])) Console.WriteLine(firstarr[i]
                            + " " + Secondarr[j] + " " + Thirdarr[k]);
                    }

                }
            }

        }
    }
}
