using System;

namespace MethodOverriding
{
    class Program
    {
        public class BaseClass
        {

            public virtual void Greetings()
            {
                Console.WriteLine("BaseClass Saying Hello");
            }
        }
        //Same method name but one is in base class and another is in derived class
        public class SubClass : BaseClass
        {

            public override void Greetings()
            {
                Console.WriteLine("SubClass Saying Hello");
            }
        }
        static void Main(string[] args)
        {
            //This will call subclass Greetings() method because of overriding.
            SubClass objSubClass = new SubClass();
            objSubClass.Greetings();
            Console.ReadLine();
        }
    }
}
//Output: SubClass Saying Hello!
