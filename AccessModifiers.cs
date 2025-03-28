using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class AccessModifiers
    {
        public int MyProperty { get; set; }
        //private int MyPrivateProp { get; set; }

        //protected int myProtected { get; set; }



    }

    public class ChildAccessModifiers : AccessModifiers
    {

        //public void myMethod() {
        //    myProtected = 10;
        //    MyPrivateProp = 152;

        //}

        //public int MyProperty { get; set; }
        //private int MyPrivateProp { get; set; }


    }
}
