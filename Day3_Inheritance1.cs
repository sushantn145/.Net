using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass o;
            //o = new BaseClass();
            o = new DerivedClass();

            o = new DerivedClass(40, 50);

            o = new subDerivedClass();
            o = new subDerivedClass(100, 200, 300);
            Console.ReadLine();
        }
    }
    public class BaseClass
    {
        public int i;
        public BaseClass()
        {
            Console.WriteLine("No param Base class contr");
            //this.i = 10;
            //this.show();
            
        }
        public BaseClass(int i)
        {
            Console.WriteLine("Param Base class Contr");
            this.i = i;
        }
        public virtual void show() //virtual method can not be private
        {
            Console.WriteLine("show called from no param Base contr ");
        }
    }
    public class DerivedClass : BaseClass
    {
        private int j;
        public DerivedClass()
        {
            Console.WriteLine("No Param Derived class Contr");
            this.j = 20;
        }
        public DerivedClass(int i,int j) : base(i)
        {
            
            Console.WriteLine("Param Derived class Contr");
            //this.i = i;
            this.j = j;
            //Console.WriteLine(i +" "+j);
            
        }
        public override void show()
        {
            Console.WriteLine("Derived show called from no param Base contr ");
        }
    }

    public class subDerivedClass : DerivedClass
    {
        private int k;
        public subDerivedClass()
        {
            Console.WriteLine("No Param SubDerived class Contr");
            this.k = 20;
        }
        public subDerivedClass(int i,int j,int k) : base(i,j)
        {
            Console.WriteLine(" Param SubDerived class Contr");
            this.k = k;
        }
    }
}
