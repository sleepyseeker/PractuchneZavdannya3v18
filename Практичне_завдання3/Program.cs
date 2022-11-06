using System;
namespace Program

{
    class Program
    {
        public static double y(double x)
        {
            if (x < -2) return -2 - x;
            if (x < 0) return Math.Sqrt(-x * (x + 2));
            if (x < 4) return -Math.Sqrt(x * (4 - x));
            if (x < 6) return 2 - x * 0.5; return -1;
        }
        public static void Main()
        {
            double x; while (true)
            {
                Console.Write("x: ");
                x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("y(x) = " + y(x));
            }
        }
    }
}