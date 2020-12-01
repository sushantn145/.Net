using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {

           
            Employee e1 = new Employee("",26000,00);
            Employee e2 = new Employee("Sushant", 6000);
            Employee e3 = new Employee("Sushant");
            Employee e4 = new Employee();

            Console.WriteLine(e1.empNo);
            Console.WriteLine(e2.empNo);
            Console.WriteLine(e3.empNo);
            

            
            Console.WriteLine(e3.empNo);
            Console.WriteLine(e2.empNo);
            Console.WriteLine(e1.empNo);
            Console.ReadLine();

        }
    }
    class Employee
    {
        private string name;
        public int empNo;
        private decimal basic;
        private short dept_No;

        private static int var;
        public Employee()
        {
            
        }
        //1 param const
        public Employee(string name)
        {
            empNo = ++var;
            this.name = name;
        }
        public Employee(string name,decimal basic )
        {
            empNo = ++var;
            this.name = name;
            this.basic = basic;
        }
        public Employee(string name, decimal basic,short dept_No)
        {
            empNo = ++var;
            this.name = name;
            this.basic = basic;
            this.dept_No = dept_No;
        }
        public int EmpNo
        {
            get
            {
               return empNo;
            }
        }

        public string Name
        {
            set
            {
                if (value != null)
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("Name should not be Blank");
                }
            }
            get
            {
                return name;
            }
        }
        public decimal Basic
        {
            set
            {
                if(value >= 25000 && value <= 50000)
                    basic = value;
                else
                    Console.WriteLine("Invalid Basic");
            }
            get
            {
                return basic;
            }
        }
        public short DeptNo
        {
            set
            {
                if (value > 0)
                {
                    dept_No = value;
                }
                else
                {
                    Console.WriteLine("Dept should be in between 1 to 127");
                }
            }
            get
            {
                return dept_No;
            }
        }

        public decimal GetNetSalary()
        {
            decimal sal = basic + 4000 + 1000;//basic+ta+da
            return sal;
        }
    }
}
