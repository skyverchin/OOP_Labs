using System;
using System.Linq;

namespace Lab_3
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

            public Array[] MyArray = new Array[5];
            public Array[] MyArraySecond = new Array[5];

            /* public void ArrayFill()
             {
                 Console.WriteLine("Generated first array");
                 for (int i = 0; i < 5; i++)
                 {
                     MyArray[i] = new Array();
                     MyArray[i].X = 2+i;
                     Console.WriteLine(MyArray[i].X);
                 }

                 Console.WriteLine("Generated second array");
                 for (int i = 0; i < 5; i++)
                 {
                     MyArraySecond[i] = new Array();
                     MyArraySecond[i].X = 3+i;
                     Console.WriteLine(MyArraySecond[i].X);
                 }
             }*/

            public void ArrayChose()
            {
                int MaxNumber = MyArray.Max(p => p.X);
                Console.WriteLine("Most maximum number in first array " + MaxNumber);

                int MaxNumber2 = MyArraySecond.Max(p => p.X);
                Console.WriteLine("Most maximum number in second array " + MaxNumber2);

                if (MaxNumber < MaxNumber2)
                {
                    Console.WriteLine("Second Array have biggest less number" + MaxNumber2);
                }
                else
                {
                    Console.WriteLine("First Array have biggest less number" + MaxNumber);
                }
            }
        }
        class MainClass
        {
            static void Main(string[] args)
            {
                Array Array = new Array();
                //Array.ArrayFill();

                Console.WriteLine("Generated first array");
                for (int i = 0; i < 5; i++)
                {
                    Array.MyArray[i] = new Array();
                    Array.MyArray[i].X = 2+i;
                    Console.WriteLine(Array.MyArray[i].X);
                }

                Console.WriteLine("Generated second array");
                for (int i = 0; i < 5; i++)
                {
                    Array.MyArraySecond[i] = new Array();
                    Array.MyArraySecond[i].X = 3+i;
                    Console.WriteLine(Array.MyArraySecond[i].X);
                }

                Array.ArrayChose();
            }
        }
    }
}
