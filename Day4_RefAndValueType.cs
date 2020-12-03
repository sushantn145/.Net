using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefAndValueType
{
    class Program
    {
        static void Main1()
        {
            Class1 o1 = new Class1();
            Class1 o2 = new Class1();
            o1.i = 100;
            o2.i = 200;
            o1 = o2;
            o2.i = 300;
            o1.i = 200;
            Class1 o3 = new Class1();
            o3 = o1;
            o3.i = 400;
           
            Console.WriteLine();
            Console.WriteLine("i = "+o1.i);
            Console.WriteLine("j = "+o2.i);
            
            Console.ReadLine();
        }
       
    }
    public class Class1
    {
        public int i;
    }
}

namespace RefAndValueType1
{
    class Program
    {
        static void Main2()
        {
            int o1, o2;
            o1 = 100;
            o2 = 200;
            o1 = o2;
            o2 = 300;


            Console.WriteLine();
            Console.WriteLine("i = " + o1);
            Console.WriteLine("j = " + o2);

            Console.ReadLine();
        }

    }
    public class Class1
    {
        public int i;
    }
}

namespace RefAndValueType2
{
    class Program
    {
        static void Main3()
        {
            string o1 = "100";
            string o2 = "200";
            o1 = o2;
            o2 = "300";

            Console.WriteLine();
            Console.WriteLine("i = " + o1);
            Console.WriteLine("j = " + o2);

            Console.ReadLine();
        }

    }
    public class Class1
    {
        public int i;
    }
}

namespace RefAndValueType4
{
    class Program
    {
        static void Main4()
        {
            int i = 10;
            int j = 20;
            Swap(ref i,ref j);
            Console.WriteLine();
            Console.WriteLine("i = " + i);
            Console.WriteLine("j = " + j);
            Console.ReadLine();
        }
        static void Swap(ref int i,ref int j)
        {
            int temp = i;
            i = j;
            j = temp;
            Console.WriteLine("In swap");
            Console.WriteLine("i = " + i);
            Console.WriteLine("j = " + j);
        }
    }
}

namespace RefAndValueType5
{
    class Program
    {
        static void Main()
        {
            int i ;
            int j ;
            Init(out i,out j);
            //Swap(ref i, ref j);
            Console.WriteLine();
            Console.WriteLine("i = " + i);
            Console.WriteLine("j = " + j);
            Console.ReadLine();
        }
        //out is just like ref diff is just it don't need to intialize before passing
        //here value should be discarded and initialized out variables
        //changes it in fun reflect back in calling mode
        static void Init(out int i, out int j)
        {
            Console.WriteLine("In Init");
            //Console.WriteLine("i = " + i); //it will show error bcoz it is discarded
            //Console.WriteLine("j = " + j);
            i = 200;
            j = 300;
            
        }
    }
}
