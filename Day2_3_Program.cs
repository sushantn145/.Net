using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMembers
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Class1 o;
            o = new Class1(); // memory allocated for static constuctor and called
            Class1 o1 = new Class1();
            o.i = 100;
            o.i = 20;
        
            Class1.s_i = 1234; // static constructor called
            Console.WriteLine("static value = "+Class1.s_i);
            o.Display();
            Class1.s_Display();
            
           

            Class1.s_i = 500;
            Console.WriteLine("Static value = "+Class1.s_i);
            
            //o.P1 = 60; // static class can not called by object
            Class1.P1 = 60.2352;
            Console.WriteLine("Property Value = "+Class1.P1);

            //another namespace 
            // Access.Const a = new Access.Const();
            Access.Const.Display();

            //static class
            //Static_class1 sc = new Static_class1(); // can not create object of static class
            Static_class1.show();
            
                
            Console.ReadLine();
        }
    }
    public class Class1
    {
        static Class1() //bydeafault private
        {
            Console.WriteLine("Static constructore called");
        }
        //static constructor must be parameterless and access modifier also not allowed
        //public static Class1(int i)
        //{
        //    Console.WriteLine("Static constructore called");
        //}
        public Class1()
        {
            Console.WriteLine("Constructor called");
        }
        //// we have to make constructor publicc bcoz in class everything is bydefault private
        public Class1(int i)
        {
            Console.WriteLine("Param Constuctor " + i);
        }
        public int i;
        //static valiable - single copy for the class
        public static int s_i;

        private float k;
        public void Display()
        {
            Console.WriteLine("Non-static Display ");
            Console.WriteLine(i);
            Console.WriteLine(s_i);
            
        }
       
        public static void s_Display()
        {
            int p= 25;
            Console.WriteLine("Checking static = "+p);
            Console.WriteLine("static Display ");
            //Console.WriteLine(i); //can not call non static data member from static 
            Console.WriteLine(s_i);
            
            
            //show();
            //void show()
            //{
            //    Console.WriteLine("Method madhe method");
            //}
           
        }

        private static float s_p1;
        
        public static double P1
        {
            set
            {
                // Console.WriteLine("Check");
                if (value < 100) { 
                    s_p1 = (float)value;
        
                }
                else
                    Console.WriteLine("Inavlid");
            }
            get
            {
                //  Console.WriteLine("Default value  : ");
                return s_p1;
            }
        }
    }

    public static class Static_class1
    {
        //int a;
        static string  str = "Sushant";
       
        public static void show()
        {
            int str1;
            Console.WriteLine("static class");
            Console.WriteLine(str);
        }
    }
}
namespace Access
{
    public static class  Const
    {
          public static void Display()
            {
                StaticMembers.Class1.s_Display();
                Console.WriteLine("Another namespace");
            }
      
    }
}
