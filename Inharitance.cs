using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class A
    {
        public int AParentProperty { get; set; }
    }

    public class B : A // Single inharitance
    {
        public int BParentProperty { get; set; }
    }

    public class C : B // Multi level inharitance
    {
        public int CParentProperty { get; set; }
    }

    public class D : A // H inharitance
    {
        public int CParentProperty { get; set; }
    }

    public class E : A // H inharitance
    {
        public int CParentProperty { get; set; }
    }

    public class AParentClass
    {
        public int ParentProperty { get; set; }
    }

    public class BChildClass
    {
        public int ParentProperty { get; set; }
    }

  
    // Interface : Just method decration not implementation (without body)

    interface IA
    {
        // Constructor
        //public IA() {  Cannot use

        //} 

        //public int MyPropertyssd { get; set; }

        //int abc { get; set; }

        void GetDataA();

    }

    interface IB
    {
        void GetDataB();

    }

    public class CChildClass : IA, IB // Multiple inharitance
    {

        //public int ParentProperty { get; set; }
        public void GetDataA()
        {
            //throw new NotImplementedException();
        }

        public void GetDataB()
        {
           // throw new NotImplementedException();
        }
    }


}
