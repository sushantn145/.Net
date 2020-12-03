using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefAndValueType1
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 o1 = new Class1();
            o1.i = 100;
            //DoSomething1(o1);
            //DoSomething2(o1);
            DoSomething3(ref o1);
            Console.WriteLine(o1.i);
            Console.ReadLine();
        }
        //referance type - changes made in function reflect back in calling mode
        public static void DoSomething1(Class1 obj)
        {
            obj.i = 200;
        }
        //referance type - if new object is created, the calling code(main) does not point to the new object
        public static void DoSomething2(Class1 obj)
        {
            obj = new Class1();
            obj.i = 200;
        }
        //referance type passed as ref - if new object is created,the calling code(main) points to the new object
        public static void DoSomething3(ref Class1 obj)
        {
            obj = new Class1();
            obj.i = 200;
        }
    }
    public class Class1
    {
        public int i;
    }
}
