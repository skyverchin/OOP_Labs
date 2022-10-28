using System;
using System.Linq;
using System.Drawing;
using System.Drawing.Design;
using System.Diagnostics;

namespace Lab_4
{
    internal class Program
    {
        public class PolarSystem
        {
            public double x, y; //Decart
            public double r, f; //Polar

            Random rnd = new Random();

            public void TransformPolarIntoDecart(out double X, out double Y)
            {
                X = r*Math.Cos(f);
                Y = r*Math.Sin(f);
            }

            public void TransformDecartIntoPolar(out double R, out double F)
            {
                R = Math.Sqrt(Math.Pow(x, 2)+Math.Pow(y, 2));
                F = 0; //---

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
            }
        }

        public class CylinderSystem : PolarSystem
        {
            public double z; //Decart
            public double p, fi; //Cylinder

            public void TransformCylinderIntoDecart(out double X, out double Y, out double Z)
            {
                X = p*Math.Cos(fi);
                Y = p*Math.Sin(fi);
                Z = z;
            }

            public void TransformDecartIntoCylinder(out double P, out double F, out double Z)
            {
                P = Math.Sqrt(Math.Pow(x, 2)+Math.Pow(y, 2));
                F = Math.Atan(y/x);
                F = F * (Math.PI/180);
                Z = z;
            }
        }
 
        class MainClass{
            static void Main(string[] args)
            {
                PolarSystem PolarSystem = new PolarSystem();
                CylinderSystem CylinderSystem = new CylinderSystem();

                PolarSystem.x = -3;
                PolarSystem.y = 4;
                PolarSystem.r = 4;
                PolarSystem.f = 30;

                CylinderSystem.x = PolarSystem.x; //---
                CylinderSystem.y = PolarSystem.y; //---

                CylinderSystem.z = 3;
                CylinderSystem.p = 3;
                CylinderSystem.fi = 60;

                double OutFirst, OutSecond, OutThird;
                PolarSystem.TransformPolarIntoDecart(out OutFirst, out OutSecond);
                Console.WriteLine("Polar to Decart result x = " + OutFirst + " y = " + OutSecond);

                PolarSystem.TransformDecartIntoPolar(out OutFirst, out OutSecond);
                Console.WriteLine("Decart to Polar result r = " + OutFirst + " fi = " + OutSecond);

                CylinderSystem.TransformCylinderIntoDecart(out OutFirst, out OutSecond, out OutThird);
                Console.WriteLine("Cylinder to Decart result x = " + OutFirst + " y = " + OutSecond + " z = " + OutThird);

                CylinderSystem.TransformDecartIntoCylinder(out OutFirst, out OutSecond, out OutThird);
                Console.WriteLine("Decart to Cylinder result p = " + OutFirst + " f = " + OutSecond + " z = " + OutThird);
            }
        }
    }
}
