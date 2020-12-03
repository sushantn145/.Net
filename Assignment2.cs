using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee m = new Manager();
            Employee m1 = new Manager("Sushant",10,26000,"Devloper");
            Employee m2 = new GeneralManager("Sus", 10, 50000);
            Employee m3 = new CEO("Tushar", 20, 600000);
            //Console.WriteLine(m1.EmpNo+" "+ m1.Name +" "+ m1.Basic+" "+m1.Dept);
            //Console.WriteLine(m2.EmpNo + " " + m2.Name + " " + m2.Basic + " " + m2.Dept);
            //Console.WriteLine();
            //Console.WriteLine(m2.EmpNo + " " + m2.Name + " " + m2.Basic + " " + m2.Dept);
            //Console.WriteLine(m1.EmpNo + " " + m1.Name + " " + m1.Basic + " " + m1.Dept);
            m1.show();
            m2.show();
            m3.show();
            Console.ReadLine();

        }
    }

    public interface IDbFunction
    {
        void show();
    }
    public abstract class Employee : IDbFunction
    {
        private string name;
        private  int empNo;
        private short dept;
        protected decimal basic;
        private static int var;
        public Employee()
        {
            Console.WriteLine("No param employee contr");
        }
        public Employee(string name="noname", short dept=10)
        {
            Console.WriteLine("parm contr");
            this.Name = name;
            this.Dept = dept;
            this.empNo= ++var;
           
        }
        public abstract decimal Basic
        {
            set;
            get;
        }
        public String Name
        {
            set
            {
                if (!String.IsNullOrWhiteSpace(value)) { 
                    name = value;
                }
                else
                {
                    Console.WriteLine("Name should not blank");
                }
            }
            get
            {
                return name;
            }
        }
        public int EmpNo
        {
            get
            {
                return empNo;
            }
        }
        public short Dept
        {
            set {
                if (value > 0)
                {
                    Console.WriteLine("in dept");
                    dept = value;
                }
                else
                    Console.WriteLine("Enter valid Dept no");
                }
            get
            {
                return dept;
            }
        }

        public abstract decimal CalcNetSalary();
        public void show()
        {
            Console.WriteLine("manager");
            Console.WriteLine("empNo : " + EmpNo);
            Console.WriteLine("empName : " + Name);
            Console.WriteLine("dept no : " + Dept);
            Console.WriteLine("basic : " + Basic);
        }
    }

    public class Manager : Employee,IDbFunction
    {
        private string designation;
        public Manager()
        {
            Console.WriteLine("no para Manager construct......");
        }
        public Manager(string name,short deptNo,decimal basic,string designation) : base(name,deptNo)
        {
            this.designation = designation;
            Basic = basic;
          
        }
        
        public String Designation
        {
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                    designation = value;
                else
                    Console.WriteLine("Enter designation");
            }
            get
            {
                return designation;
            }
        }
        public override decimal Basic 
        {
            set
            {
                if (value > 25000)
                    basic = value;
            }
            get 
            {
                return basic;
            }
        }

        public override decimal CalcNetSalary()
        {
            decimal sal;
            sal = this.Basic + 1200;
            return sal;
        }
        public new void show()
        {
            Console.WriteLine("manager");
            Console.WriteLine("empNo : " + EmpNo);
            Console.WriteLine("empName : " + Name);
            Console.WriteLine("dept no : " + Dept);
            Console.WriteLine("basic : " + Basic);
            Console.WriteLine("designation : " + Designation);
        }
    }

    public class GeneralManager : Manager,IDbFunction
    { 
        public GeneralManager()
        {
            Console.WriteLine("generalManager no para construct........");
        }
        private string perks;
        public string Perks
        {
            set;
            get;
        }

        public GeneralManager(string name, short dept, decimal basic = 26000, string designation = "none", string perks = "none") : base(name, dept, basic, designation)
        {
            Perks = perks;
        }
        public new void show()
        {
            Console.WriteLine("general manager");
            Console.WriteLine("empNo : " + EmpNo);
            Console.WriteLine("empName : " + Name);
            Console.WriteLine("dept no : " + Dept);
            Console.WriteLine("basic : " + Basic);
            Console.WriteLine("perks : " + Perks);
        }
    }
    public class CEO : Employee,IDbFunction
    {
        public override decimal Basic
        {
            get
            {
                return basic;
            }
            set
            {
                if (value > 25000)
                    basic = value;
                else
                    Console.WriteLine("enter valid basic salary.....");
            }
        }

        public override sealed decimal CalcNetSalary()
        {
            return Basic + 10000;
        }

        public CEO()
        {
            Console.WriteLine("no param construct");
        }

        public CEO(string name = "none", short dept = 10, decimal basic = 26000) : base(name, dept)
        {
            Basic = basic;
        }
        public new void show()
        {
            Console.WriteLine("ceo");
            Console.WriteLine("empNo : " + EmpNo);
            Console.WriteLine("empName : " + Name);
            Console.WriteLine("dept no : " + Dept);
            Console.WriteLine("basic : " + Basic);

        }
    }
}
