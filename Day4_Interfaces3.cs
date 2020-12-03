using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface3
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 o = new Class1();
           

            IFileFunctions oIFile;
            oIFile = o;
            oIFile.Delete();

            IDbFunction oIDb;
            oIDb = o;
            oIDb.Delete();
            Console.ReadLine();
        }
    }
    public interface IDbFunction
    {
        void Insert();
        void Delete();
        void Update();

    }
    public interface IFileFunctions
    {
        void Open();
        void Close();
        void Delete();
    }
    public class Class1 : IDbFunction, IFileFunctions
    {
        //implicitly private we can not give any modifier
        void IDbFunction.Delete()
        {
            Console.WriteLine("Class1 - IDb.Delete");
        }
        
        public void Display()
        {
            Console.WriteLine("Class1 - Display");
        }
        //implicitly public we can not give any modifier to implemented methods
        public void Insert()
        {
            Console.WriteLine("Class1 - IDb.Insert");
        }

        public void Update()
        {
            Console.WriteLine("Class1 - IDb.Update");
        }

        public void Close()
        {
            Console.WriteLine("Class1 - IFile.Close");
        }

        //implicitly private we can not give any modifier
        void IFileFunctions.Delete()
        {
            Console.WriteLine("Class1 - IFile.Delete");
        }
        public void Open()
        {
            Console.WriteLine("Class1 - IFile.Open");
        }
    }
}
