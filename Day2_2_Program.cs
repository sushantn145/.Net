using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccessSpecifier;

namespace IneritanceExample
{
    class Program
    {
        static void Main1(string[] args)
        {
            BaseClass b = new BaseClass();
            DerivedClass d = new DerivedClass();
            
        }
    }
    public class BaseClass
    {
        public int a;
    }
    public class DerivedClass : BaseClass
    {
        public int b;
    }
}

namespace IneritanceExample1
{
    class Program
    {
        static void Main2(string[] args)
        {
            BaseClass b = new BaseClass();
            b.PUBLIC = "Main Base class Object";
            b.INTERNAL = "Main Base class Object";
            b.PROTECTED_INTERNAL = "Main Base class Object";
            
            
            DerivedClass d = new DerivedClass();
            d.PUBLIC = "Main Dervied class Object";
            d.INTERNAL = "Main Dervied class Object";
            d.PROTECTED_INTERNAL = "Main  Dervied class Object";
            
        }
    }
    // if we give static to base class it can not be inherited
    public class BaseClass
    {
        public string PUBLIC;
        private string PRIVATE;
        protected string PROTECTED;
        internal string INTERNAL;
        protected internal string PROTECTED_INTERNAL;
        
        public void display()
        {
            this.PUBLIC = "Same class";
            this.PRIVATE = "Same class";
            this.PROTECTED = "Same class";
            this.INTERNAL = "Same class";
            this.PROTECTED_INTERNAL = "Same class";
        }
    }
    public class DerivedClass : BaseClass
    {
        public int b;
        
        public void display()
        {
            this.PUBLIC = "Derived class";
            this.PROTECTED = "Derived class";
            this.INTERNAL = "Derived class";
            this.PROTECTED_INTERNAL = "Derived class";
        }
    }
}


#region When Baseclass is in Another Assembly
namespace IneritanceExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass b = new BaseClass();
            b.PUBLIC = "Main Base class Object";
            
            DerivedClass d = new DerivedClass();
            d.PUBLIC = "Main Dervied class Object";
            

        }
    }
    // if we give static to base class it can not be inherited
    
    public class DerivedClass : AccessSpecifier.BaseClass
    {
        public int b;

        public void display()
        {
            this.PUBLIC = "Derived class";
            this.PROTECTED = "Derived class";
            this.PROTECTED_INTERNAL = "Derived class"; 
        }
    }
}
#endregion
