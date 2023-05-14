using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTaskClassLibrary
{
    public class Geometry
    {  
        public int RectangleArea(int a, int b)
        {
            return a * b;
        }

        public double CylinderVolume(double pi, int r, int h)
        {
            return (pi * Math.Pow(r,2) * h);
        }

        public double SquareRoot(double x)
        {
            return Math.Sqrt(x);
        }

        public static double[] Equation(double a, double b, double c)
        {
            double d = b * b - 4 * a * c;

            if (d == 0)
            {
                double x = -b / (2 * a);
                return new double[] { x };
            }

            if (d > 0)
            {
                double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                return new double[] { x1, x2 };
            }

            return null;
        }

        public double SquareOfNumbers()
        {
            int n;
            Console.WriteLine("Введите число:");
            n = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += i * i;
                if (sum > n)
                {
                    break;
                }
                Console.WriteLine(sum);

            }
            Console.ReadKey();
            return sum;
        }

    }
}
