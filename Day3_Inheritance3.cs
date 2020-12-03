using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass o;
            o = new DerivedClass();
            o.Display();
            o.Show();

            //can not create object of base abstract class
            //AbstractClass1 a = new AbstractClass1();
            Class c = new Class();
            c.Display();
            c.Display1();
            c.Display2();
            c.Display3();


            //Class2 c2 = new Class2();
            //c2.Display();
            //c2.Display1();
            //c2.Display2();
            //c2.Display3();
            Console.ReadLine();
        }
    }

    //in abstract class constuct method also used
    public abstract class AbstractClass
    {
        public void Display()
        {
            Console.WriteLine("Display from abstract");
        }
    }
    public class DerivedClass : AbstractClass
    {
        public void Show()
        {
            Console.WriteLine("Display from Derived");
        }
    }

    public abstract class AbstractClass1
    {
        public abstract void Display();
        public abstract void Display1();
        public abstract void Display2();
        public abstract void Display3();
    }
    public class Class : AbstractClass1
    {
        public override void Display()
        {
            Console.WriteLine("Display from Display");
        }

        public override void Display1()
        {
            Console.WriteLine("Display from Display1");
        }

        public override void Display2()
        {
            Console.WriteLine("Display from Display2");
        }

        public override void Display3()
        {
            Console.WriteLine("Display from Display3");
        }

        public void Show()
        {
            Console.WriteLine("Display from Derived show");
        }
    }
    //if we give class abstract so its not compulsary to override all inherited abstract class method
    public abstract class Class2 : AbstractClass1
    {
        public override void Display()
        {
            Console.WriteLine("Display from Display class2");
        }

        public override void Display1()
        {
            Console.WriteLine("Display from Display1  class2");
        }

        
    }
}
