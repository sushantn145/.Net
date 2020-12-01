using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClassConcepts
{
    class Program
    {
        static void Main()
        {
            //System.Console.WriteLine("Hello World");
            //System.Console.ReadLine();
            Console.WriteLine("Hello World");

            Class2 obj = new Class2();
            obj.Display();

            //optional parameter
            Console.WriteLine(obj.Add(10, 20, 30, 40));
            Console.WriteLine(obj.Add(10, 20, 30));
            Console.WriteLine(obj.Add(10, 20));
            Console.WriteLine(obj.Add(10));
            Console.WriteLine(obj.Add());


            //named parameter
            Console.WriteLine(obj.Add(d:40));
            Console.WriteLine(obj.Add(b: 10));
            Console.WriteLine(obj.Add(c: 30));
            Console.WriteLine(obj.Add(a: 20));


            //Console.WriteLine(obj.Add2(a: 20));
            //Console.WriteLine(obj.Add2(d: 20));
            Console.WriteLine(obj.Add2(d:30,c:50,b:30,a: 20));

            Console.WriteLine("Table");
            obj.table(2);

            //Calling second namespace static method 
            SecondNamespace.Program2.display();

            //calling third namespace method
            ThirdNamespace.Program3 sec = new ThirdNamespace.Program3();
            //ThirdNamespace.Program3.display th = new ThirdNamespace.Program3.display();
            sec.display();

            //Calling subnamespace 
           ThirdNamespace.ThirdNamespace.SubProg sub =  new ThirdNamespace.ThirdNamespace.SubProg();
            sub.display();

            //same namespace declaring outside namespace and calling method
            ThirdNamespace.Program4 third = new ThirdNamespace.Program4();
            third.display();
            Console.ReadLine();

        }
    }

    public class Class2
    {
        public void Display()
        {
            Console.WriteLine("In class2");
        }
        //optional parameter with default value
        public int Add(int a=0,int b=0,int c=0,int d=0)
        {
            return a + b + c + d;
        }

        public int Add2(int a, int b, int c, int d)
        {
            return a + b + c + d;
        }

        public void table(int a)
        {
            int sum = 0;
            for(int i = 1; i <= 10; i++)
            {
                sum = i * a;
                Console.WriteLine(sum);
                //Console.ReadLine();
            }
          
        }
        
    }
}

namespace SecondNamespace
{
    class Program2
    {
        public  static void display()
        {
            //ThirdNamespace.Program4 SecondNP = new ThirdNamespace.Program4();
            //SecondNP.Show();
            ThirdNamespace.Program4.show1();
            Console.WriteLine("Second namespace");

        }
    }
}

namespace ThirdNamespace
{
    class Program3
    {
        public void display()
        {
            Console.WriteLine("Third namespace");
      
        }
    }

    //same name can be given for namespace inside namesapce
    namespace ThirdNamespace
    {
        class SubProg
        {
            public void display()
            {
                Console.WriteLine("Inside ThirdNamesapce sub Thirdnamespace");
            }
        }
    }
}

namespace ThirdNamespace
{
    class Program4
    {
        public void display()
        {
            Console.WriteLine("same name for namespace outside namespace");
        }

        public void Show()
        {
            Console.WriteLine("called From Second namespace");
        }

        public static void show1()
        {
            Console.WriteLine("called From Second namespace static method");
        }
    }
}