using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass o;
            o = new DerivedClass();
            o.Display1();
            o.Display2();
            o.Display3();
            Console.WriteLine();

            o = new SubDerivedClass();
            o.Display3();

            Console.WriteLine();
            //o = new SubSubDerivedClass();
            //o.Display3();

            Console.ReadLine();
        }
    }
    public class BaseClass
    {
        public void Display1()
        {
            Console.WriteLine("Base Display1");
        }
        public void Display2()
        {
            Console.WriteLine("Base Display2");
        }
        public  virtual void Display3()
        {
            Console.WriteLine("Base Display3");
        }
    }
    public class DerivedClass : BaseClass
    {
        //Method Overloading
        public void Display1(string a)
        {
            Console.WriteLine("Derived Display1");
        }

        //Method hidding
        public new void Display2()
        {
            Console.WriteLine("Derived Display2");
            this.Display1();
        }
        //method overriding
        public  override void Display3()
        {
            Console.WriteLine("Derived Display3");
        }
    }
    //we can give class also sealed but it can not inherited
    public sealed class SubDerivedClass : DerivedClass
    {
        public sealed override void Display3()
        {
            Console.WriteLine("subDerived Display3");
        }
    }
    //public class SubSubDerivedClass : SubDerivedClass
    //{
    //    public  new void Display3()
    //    {
    //        Console.WriteLine("SubSubDerived Display3");
    //    }
    //}
}
