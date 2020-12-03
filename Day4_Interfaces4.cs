using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces4
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 o = new Class1();
     
            Console.WriteLine(" Inteface 1 Class 1");
            o.Insert();
            o.Update();

            Console.WriteLine("Inteface 2 Class 1 ");
            o.Delete();
            o.Create();
            

            Console.WriteLine("==========");
            Class2 o2 = new Class2();
            o2.Display();
            o2.Delete();
            o2.Insert();
            //o2.show(); //This method is from class 2 
            Console.WriteLine("Downcasting");
            
            // Doncasting done
            Class2 o3 = (Class2)o2;
            o3.Show();
            Console.ReadLine();
        }
    }
    public interface IDbFunctions
    {
        void Insert();
        void  Update();


    }
    public interface IDbFunction2 : IDbFunctions
    {
        void Create();
        void Delete();

    }

   
    public class Class1 : IDbFunction2
    {
        public void Delete()
        {
            Console.WriteLine("Class 1 : IDb2.Delete");
        }
        public void Create()
        {
            Console.WriteLine("Class 1 : IDb2.Create");
        }
        public void Display()
        {
            Console.WriteLine("Class 1 : Display");
        }

        public virtual void Insert()
        {
            Console.WriteLine("Class 1 : IDb1.Insert");
        }

        public void Update()
        {
            Console.WriteLine("Class 1 : IDb1.Update");
        }
    }
    public class Class2 : Class1
    {
        public void Show()
        {
            Console.WriteLine("Class 2 : Show");
        }
        public new void Delete()
        {
            Console.WriteLine("class 2 IDb2:Delete");
        }
        public override void Insert()
        {
            Console.WriteLine("class 2 IDb1:Insert");
        }
    }
}
