using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            class1 o = new class1();
            //method 1
            o.Delete();
            o.Insert();
            o.update();
            o.Display();
            Console.WriteLine();
            //Method 2 // Explicitly creating referance
            IDbFunctions oIDb;
            oIDb = o;
            Console.WriteLine(oIDb.GetType()); 
            oIDb.Insert();
            oIDb.update();

            Console.WriteLine();
            //Method 3 //Typecasting done It is implicitly creating referance
            Console.WriteLine( ((IDbFunctions)o).GetType());
            ((IDbFunctions)o).Insert();
            ((IDbFunctions)o).update();

            Console.ReadLine();
        }
    }
    public interface IDbFunctions{
        void Insert();
        void update();
        void Delete();
    }
    public class class1 : IDbFunctions
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

        public void update()
        {
            Console.WriteLine("Class1 - IDb.update");
        }
    }
}
