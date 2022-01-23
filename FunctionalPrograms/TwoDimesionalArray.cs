using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    public class TwoDimesionalArray
    {
        public  void Print(int [,] Input)
        {
            for(int i=0; i<Input.GetLength(0); i++)
            {
                for(int j=0; j<Input.GetLength(1); j++)
                {
                    Console.WriteLine("Element({0},{1})={2}", i, j, Input[i, j]);
                }
            }
        }

        public void Inp()
        {
            Console.WriteLine("Enter the number of rows & Coloumns repectively");
            int row, coloumn;
            row = Convert.ToInt32(Console.ReadLine());
            coloumn = Convert.ToInt32(Console.ReadLine());
            int [,]arr=new int[row,coloumn];
            Console.WriteLine("Enter the elements\n");
            for(int i=0; i < row; i++)
            {
                for(int j=0;j<coloumn; j++)
                {
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
               
            }

            Print(arr); 

        }

    }
}
