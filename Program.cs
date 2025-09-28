using System;

namespace QuadraticSlover
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("enter coffient:");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            int delta = b * b - 4 * a * c;
            double sqrtDelta=Math.Sqrt(delta);
            if (sqrtDelta > 0)
            {
                double x1 = (-b + sqrtDelta) / (2 * a);
                double x2= (-b - sqrtDelta) / (2 * a);

                Console.WriteLine("root 1 is {0} and root 2 is {1}",x1,x2);

            }
            else
            {
                Console.WriteLine("no real root");
            }

        }
    }
    
}