using System;
using System.Linq;

namespace Lab_3
{
    internal class Program
    {
        class Array
        {
            public int[] MyArray;
            public int[] MyArraySecond;

            public void ArrayChose()
            {
                int MaxNumber = MyArray.Max(p => p);
                Console.WriteLine("Most maximum number in first array " + MaxNumber);

                int MaxNumber2 = MyArraySecond.Max(p => p);
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

                Array.MyArray = new int[5] { 1, 2, 3, 4, 5};
                Array.MyArraySecond = new int[5] { 1, 2, 3, 4, 8};

                Array.ArrayChose();
            }
        }
    }
}