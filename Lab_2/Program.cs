using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_2
{
    internal class Program
    {
        class Array
        {
            int x;

            public int X
            {
                get { return x; }
                set { x = value; }
            }
        }

        class MainClass
        {
            static void Main(string[] args)
            {

                Array[] MyArray = new Array[5];

                for (int i = 0; i < 5; i++)
                {
                    MyArray[i] = new Array();
                    MyArray[i].X = 2+i;
                    Console.WriteLine("Firstly generated array " + MyArray[i].X);
                }
                int MinimalNumber = MyArray.Min(p => p.X);
                Console.WriteLine("Most less number in array " + MinimalNumber);
            }
        }
    }
}
