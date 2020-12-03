using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces2
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 o1 = new Class1();
            //Method 1
            o1.Insert();
            o1.Display();
            Console.WriteLine();
            Class2 o2 = new Class2();
            o2.Insert();
            o2.Show();
            Console.WriteLine();

            IDbFunction oIDb;
            oIDb = o1;
            oIDb.Insert();

            oIDb = o2;
            oIDb.Insert();
            Console.WriteLine();
            
            //Method 3
            InsertMethod(o1);
            InsertMethod(o2);
            Console.ReadLine();
        }
        public static void InsertMethod(IDbFunction oIDb)
        {
            oIDb.Insert();
        }
    }
    public interface IDbFunction{
        void Insert();
        void Delete();
        void Update();

    }
    public class Class1 : IDbFunction
    {
        public void Delete()
        {
            Console.WriteLine("Class1 - IDb.Delete");
        }
        public void Display()
        {
            Console.WriteLine("Class1 - Display");
        }
        public void Insert()
        {
            Console.WriteLine("Class1 - IDb.Insert");
        }

        public void Update()
        {
            Console.WriteLine("Class1 - IDb.Update"); ;
        }
    }
    public class Class2 : IDbFunction
    {
        //implemented method always public
        public void Delete()
        {
            Console.WriteLine("Class2 - IDb.Delete");
        }
        protected internal void Show()
        {
            Console.WriteLine("Class2 - Show");
        }
        public void Insert()
        {
            Console.WriteLine("Class2 - IDb.Insert");
        }

        public void Update()
        {
            Console.WriteLine("Class2 - IDb.Update"); ;
        }
       
    }
}
