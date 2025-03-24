using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    //public static class MyClass
    //{

    //    // Types of Constructor: 
    //    // Default (Parameter less)
    //    // Parameterize Constructor
    //    // Copy
    //    // Static
    //    // Private




    //    public static string Name { get; set; } // Properties
    //    public static string Description { get; set; }


    //    public static void GetData()
    //    {

    //    }

    //}
    public class MyClassNonStatic
    {

        public string Name { get; set; } // NON STATIC Properties
        public static string Name1 { get; set; } //STATIC // Properties

        public MyClassNonStatic() //Class name and method name are same
        {
            //this.Name = "ds";
            Name1 = "Here";
            Name = "fdfsf";
        }

        //private MyClassNonStatic()
        //{

        //}

        public MyClassNonStatic(string name) //Class name and method name are same
        {
            //this.Name = "ds";

            this.Name = name;
        }


        public MyClassNonStatic(MyClassNonStatic name) //Class name and method name are same
        {
            //this.Name = "ds";

            //this.Name = name;
        }

        static MyClassNonStatic()
        {
            //this.Name = "ds";
            Name1 = "Here";
            // Name = "fdfsf";
        }



        // Static and Default
        // FIrst Time Object >> Static and Default BOTH WILL BE CALLED
        // SECOND Time Object >>  Default WILL BE CALLED
        // 3rd Time Object >>  Default WILL BE CALLED
        // 4th Time Object >>  Default WILL BE CALLED





    }
}
