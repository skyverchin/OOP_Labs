using System;
using System.Linq;
using System.Drawing;
using System.Drawing.Design;
using System.Diagnostics;

namespace Lab_4
{
    internal class Program
    {
        public class XYZ
        {
            public int x, y; //Decart
            public int r, f; //Polar
            public int p, fi; //Polar
            public double TmpR, TmpF, TmpP, TmpFi; //Temporary variables

            Random rnd = new Random(); //Random generator

            public void TransformPolarIntoDecart()
            {
                double TmpX = r*Math.Cos(f);
                double TmpY = r*Math.Sin(f);
                Console.WriteLine("Polar to Decart result " + "x = " + TmpX + " " + "y = " + TmpY);
            }

            public void TransformDecartIntoPolar()
            {
                TmpR = Math.Sqrt(Math.Pow(x, 2)+Math.Pow(y, 2));

                if (TmpR == 0)
                    TmpF = rnd.Next();
                else
                {
                    if (x>0 && y>=0)
                        TmpF = Math.Atan(y/x);
                    else if (x>0 && y<0)
                        TmpF = Math.Atan(y/x)+2*Math.PI;
                    else if (x<0)
                        TmpF = Math.Atan(y/x)+Math.PI;
                    else if (x==0 && y>0)
                        TmpF = Math.PI/2;
                    else if (x==0 && y<0)
                        TmpF = 3* Math.PI/2;
                }
                Console.WriteLine("Decart to Cyliner result r = " + TmpR + " fi = " + TmpF);  
            }

            public void TransformCylinderIntoPolar()
            {
                double TmpX = p*Math.Cos(fi);
                double TmpY = p*Math.Sin(fi);

                Console.WriteLine("Cylinder to Decart result " + "x = " + TmpX + " " + "y = " + TmpY);
            }

            public void TransformPolarIntoCylinder()
            {
                TmpP = Math.Sqrt(Math.Pow(x, 2)+Math.Pow(y, 2));

                if (x==0 && y==0)
                    TmpFi = 0;
                if (x>=0)
                    TmpFi = Math.Asin(y/TmpP);
                if (x>0)
                    TmpFi = Math.Atan(y/x);
                if (x<0)
                    TmpFi = -Math.Asin(y/TmpP)+Math.PI;

                Console.WriteLine("Decart to Polar result p = " + TmpP + " fi = " + TmpFi);
            }

        }
        class MainClass{
            static void Main(string[] args)
            {
                XYZ XYZ = new XYZ();
                XYZ.x = 1;
                XYZ.y = -2;
                XYZ.r = 4;
                XYZ.f = 30;
                XYZ.p = 3;
                XYZ.fi = 60;

                XYZ.TransformPolarIntoDecart();
                XYZ.TransformDecartIntoPolar();
                XYZ.TransformCylinderIntoPolar();
                XYZ.TransformPolarIntoCylinder();
            }
        }
    }
}
