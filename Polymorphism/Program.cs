using System;

namespace Polymorphism
{
    public class Polymorphism
    {

        public int Add(int a, int b)
        {
            return a + b;
        }

        public string Add(string str1, string str2)
        {
            return str1 + str2;
        }

        static void Main(string[] args)
        {
            Polymorphism obj = new Polymorphism();
            int i = obj.Add(50, 60);
            string str = obj.Add("Mehnaz", "Khan");
            Console.WriteLine(i + " - " + str);
            Console.ReadLine();
        }
    }
}
