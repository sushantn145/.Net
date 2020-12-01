using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBasics
{
    class Program
    {
        static void Main1(string[] args)
        {
            Class1 o;
            o = new Class1(); // constructor called
            o.SetI(100);
            Console.WriteLine(o.GetI());



            //calling P1
            //o.P1 = 20;
            //Console.WriteLine("When i is Public = " + o.P1);
            o.P1 = 50;
            Console.WriteLine("P1 Output : " + o.P1);

            //Calling P2
            o.P2 = "Sushant";//set method called
            Console.WriteLine("P2 Output : "+o.P2);//get method called 

            Console.WriteLine("P3 Output : "+o.P3);
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Class1 o;
            o = new Class1(); // constructor called
            Console.WriteLine();
            Class1 o1;
            o1 = new Class1(10);
            Console.WriteLine(o.P1);
            Console.WriteLine(o1.P1);

           
            o = null; // ref unpointed
            o1 = null;// ref unpointed
            GC.Collect();  // destructor called 
            Console.ReadLine();
        }

    }

    public class Class1
    {

        #region Constructor
        public Class1()
        {
            Console.WriteLine("No param Custructor called");
            P1 = 5;
        }

        public Class1(int P1)
        {
            Console.WriteLine("1 Parameter constructor called");
            this.P1 = 50;
        }
        #endregion
        ~Class1()
        {
            Console.WriteLine("Destructor called");
        }
        #region properties 
        //public int i;
        private int i;
        public void SetI(int x)
        {
            if (x < 100)
                i = x;
        }
        public int GetI()
        {
            return i;
        }


        //Property
        private int p1;
        public int P1
        {
            set
            {
               // Console.WriteLine("Check");
                if (value < 100)
                    p1 = value;
                else
                    Console.WriteLine("Inavlid");
            }
            get
            {
              //  Console.WriteLine("Default value  : ");
                return p1;
            }
        }


        private string p2; //variable declare
        public string P2  
        {
            get
            {
                return p2;
            }
            set
            {
                p2 = value;
            }
        }


        // Read Only Property
        private string p3 = "Read only property";
        public string P3
        {
            //we can not use access modifire fro read only property
           get
            {
                return p3;
            }
        }
       
        //auto Properties
        public int P4
        {
            get;
            set;
        }
        #endregion
    }
}
