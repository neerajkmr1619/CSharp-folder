using System;

namespace C_InterviewPrepration
{
   class Class1
    {
        public void display()
        {
            Console.WriteLine("Super class display method");
        }
    }
    class Class2 : Class1
    {
        public new void display()
        {
            Console.WriteLine("Sub class display method");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Class1 obj = new Class2();
            obj.display();
            Console.ReadKey();
        }
    }
}
