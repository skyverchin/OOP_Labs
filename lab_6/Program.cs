using System;
using System.Linq;
using System.Drawing;
using System.Drawing.Design;
using System.Diagnostics;

namespace Lab_6
{
    internal class Program
    {
        abstract class PolarSystem
        {
            public double x = 4, y = 5;
            public double r = 6, f = 5;

            public abstract void TransformPolarIntoDecart();
            public abstract void TransformDecartIntoPolar();

            public void sleep()
            {
                Console.WriteLine("test");
            }
        }

        class OverRider : PolarSystem
        {
            double R, F;

            Random rnd = new Random();

            public override void TransformPolarIntoDecart()
            {             
                Console.WriteLine("Polar to Decart result x = " + r * Math.Cos(f) + " y = " + r * Math.Sin(f));
            }

            public override void TransformDecartIntoPolar()
            {
                R = Math.Sqrt(Math.Pow(x, 2)+Math.Pow(y, 2));
                F = 0;

                if (R == 0)
                    F = rnd.Next();
                else
                {
                    if (x>0 && y>=0)
                        F = Math.Atan(y/x);
                    else if (x>0 && y<0)
                        F = Math.Atan(y/x)+2*Math.PI;
                    else if (x<0)
                        F = Math.Atan(y/x)+Math.PI;
                    else if (x==0 && y>0)
                        F = Math.PI/2;
                    else if (x==0 && y<0)
                        F = 3* Math.PI/2;
                }
                Console.WriteLine("Decart to Polar result r = " + R + " fi = " + F);
            }
        }

        class CylinderSystem : PolarSystem
        {
            public double z = 1; //Decart
            public double p = 2, fi = 3; //Cylinder
            double X, Y, Z, P, F;

            virtual public void TransformCylinderIntoDecart()
            {
                X = p*Math.Cos(fi);
                Y = p*Math.Sin(fi);
                Z = z;
                Console.WriteLine("Cylinder to Decart result x = " + X + " y = " + Y + " z = " + Z);
            }

            virtual public void TransformDecartIntoCylinder()
            {
                P = Math.Sqrt(Math.Pow(x, 2)+Math.Pow(y, 2));
                F = Math.Atan(y/x);
                F = F * (Math.PI/180);
                Z = z;
                Console.WriteLine("Decart to Cylinder result p = " + X + " f = " + Y + " z = " + Z);
            }

            public override void TransformDecartIntoPolar()
            {
                throw new NotImplementedException();
            }

            public override void TransformPolarIntoDecart()
            {
                throw new NotImplementedException();
            }
        }

        class MainClass
        {
            static void Main(string[] args)
            {
                OverRider MyFirst = new OverRider();
                MyFirst.TransformPolarIntoDecart();
                MyFirst.TransformDecartIntoPolar();

                CylinderSystem MySecond = new CylinderSystem();
                MySecond.TransformCylinderIntoDecart();
                MySecond.TransformDecartIntoCylinder();
            }
        }
    }
}
