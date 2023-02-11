using System;

namespace MethodOverloading
{

    class Program
    {

        static void Main(string[] args)
        {
            MethodOverloading obj = new MethodOverloading();
            int a = obj.Add(5, 10);
            int b = obj.Add(5, 10, 15);
            double c = obj.Add(1.5, 5.5, 10);
            double d = obj.Add(1.5, 5, 10.5);
            Console.WriteLine("a: " + a + "b: " + b + "c: " + c + "d: " + d);
        }
        public class MethodOverloading
        {

            public int Add(int a, int b)
            {
                return a + b;
            }

            public int Add(int a, int b, int c)
            {
                return a + b + c;
            }

            public double Add(double a, double b, int c)
            {
                return a + b + c;
            }

            public double Add(double a, int c, double b)
            {
                return a + b + c;
            }
        }
    }
}