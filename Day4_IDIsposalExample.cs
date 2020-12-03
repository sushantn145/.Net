using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDisposalExample
{
    class Program
    {
        static void Main2(string[] args)
        {
            class1 o = new class1();

            o.Display();

            o.Dispose();
            
            o.Display();
            Console.ReadLine();
        }
    }
    public class class1 : IDisposable
    {
        private void CheckForDisposed()
        {
            if (isDisposed)
                throw new ObjectDisposedException("Class1");
        }
        public void Display()
        {
           CheckForDisposed();
           Console.WriteLine("Display");
        }
        private bool isDisposed = false;
        public void Dispose()
        {
            Console.WriteLine("Disposal called . free resource called here");
            isDisposed = true;
        }
    }
}
namespace IDisposalExample2
{
    class Program
    {
        private int i;
        static void Main(string[] args)
        {
            using (class1 o = new class1())
            {
                o.Display();
            }
            Console.ReadLine();
        }
    }
    public class class1 : IDisposable
    {
        private void CheckForDisposed()
        {
            if (isDisposed)
                throw new ObjectDisposedException("Class1");
        }
        public void Display()
        {
            CheckForDisposed();
            Console.WriteLine("Display");
        }
        private bool isDisposed = false;
        private bool p =true ;
        public void Dispose()
        {
            Console.WriteLine("Disposal called . free resource called here");
            isDisposed = true;
        }
    }
}
