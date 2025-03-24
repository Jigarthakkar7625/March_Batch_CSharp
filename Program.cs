using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Program
    {
        readonly string acccc; // in  contructor change, Variable declare 
        const double PI = 3.14; // Never change, Variable declare>> init


        public Program(string a)
        {
            acccc = a;
        }

        static void Main(string[] args)
        {

            int? abccccc = null;
            string myClassNonStatic = null;

            var abcccvvc = Convert.ToString(myClassNonStatic);
            var abcccvvcfsdfsdfs = myClassNonStatic.ToString();



            //MyClassNonStatic myClassNonStatic = new MyClassNonStatic();

            MyClassNonStatic myClassNonStatic12 = new MyClassNonStatic();

            MyClassNonStatic myClassNonStatic1233 = new MyClassNonStatic();



            //MyClassNonStatic myClassNonStatic1 = new MyClassNonStatic("Hello "); //
            //var aaa = myClassNonStatic1.Name;

            //MyClassNonStatic myClassNonStatic2 = new MyClassNonStatic("fsdfsfsfds "); //
            //var aaasa = myClassNonStatic2.Name;

            //MyClassNonStatic myClassNonStatic3 = new MyClassNonStatic("dsfdsfdsfdsfssf "); //
            //var aaasasdf = myClassNonStatic3.Name;

            //MyClassNonStatic myClassNonStatic44 = new MyClassNonStatic(myClassNonStatic3);





            //MyClass myClass = new MyClass(); // Object
            //myClass.Description = "Hello";

            //String.Join(" ", args);

            //MyClass.Description = "fdf";
            //MyClass.GetData();


            //MyClass myClass1 = new MyClass(); // Object

            //MyClass myClass3 = new MyClass(); // Object


            // Data types : 
            // Primitive data types
            //
            // Non-Primitive DT

            //Class and Object
            //Constructor



            //acccc = "fdsfdsfsdfsfsfsfsfs"


            // Read only and const


            //string
            // Immutable


            //            String
            //            string

            //String system.string




            //Char a = 'A';


            string myString = "jigar#sdffg#fggfgf#fdgd";
            string myString123 = "JIGAR123";
            var newString = myString123.PadLeft(10, '*');
            var newStringdssddsds = myString123.PadRight(10, '*');

            //padLeft
            // PadRiht


            var indexfdsfsd = myString.Remove(2);

            var index = myString.ToUpper();
            var index12 = myString.ToLower();

            var indexdfsfsfsd = myString.IndexOf("g", StringComparison.OrdinalIgnoreCase); //2
            var LastIndexOf = myString.LastIndexOf("g", StringComparison.OrdinalIgnoreCase); //21

            bool abbccc = myString.EndsWith("FDGD", StringComparison.OrdinalIgnoreCase);

            var abcdfsdfsf = myString.Trim();
            //myString.TrimEnd();
            //myString.TrimStart();
            var abccccsdsd = myString.Replace(" ", "");
            //var abc = "1,2,5,6,8"

            //var abcccc = myString.Substring(1, 10);

            var abcccc = myString.Replace("jigar", "Nidhi");

            string myString1 = " Hitaxi ";

            // Split
            var newSplitString = myString.Split('#');

            foreach (var item in newSplitString)
            {
                Console.WriteLine(item);
            }


            ////Length
            //var strLength = myString.Length;

            //myString.Concat(myString1);
            //myString = myString + myString1;
            //myString += myString1;

            //myString.Equals(myString1);
            //var bbb = myString == myString1;

            //string myString122 = " jigar "; // jigar "hitaxi"

            //myString122 = "jigar \"Nidhi\"";

            //myString122 = "jigar \'Nidhi\' \n Thakkar fjsdfklj \n sdjfdsfj";




            Console.ReadLine();

            //a = "Hardik";



            // Function 
            // Recursion :
            // //{{}}

            //int aaaa = 10;

            //Console.WriteLine($"This is my value : {aaaa * aaaa}"); //EXP

            //Console.WriteLine("This is my value : " + aaaa * aaaa +"gfgdd"+ "gfdg" +); // fresher

            //var resultFact = MyCustomFun(5); //120

            //Console.ReadKey();

            //// Call by value and Call by referece :




            //int abcccc = 15;

            //GetData(ref abcccc); // Function Pass karau ene Pointer kehvay

            //var getData = GetData2(10, 10);


            //int? result = null;

            //var result123 = result ?? 2; // Only nullable

            //var result1234 = result == 123 ? 2 : result;

            //if (result == null)
            //{
            //    result1234 = 2;
            //}
            //else
            //{
            //    result1234 = result;
            //}



            //Post increment and Pre increment
            // ++ (1),--(1), 
            // 
            // C# : Case sen
            // SQL : NO CASE Case 
            // Javascript : Case sen
            var b = 10;
            var d = true;
            //Console.WriteLine(b--);
            //int c = true;
            int a = 10;

            int sw = 5;

            // looping
            int abc = 10;
            for (int i = 0; i < abc; i++) // Memory, slower
            {
                // 0 - 9
                Console.WriteLine(abc);
                if (abc == 5)
                {
                    break;
                }

            }


            for (int i = 0; i < abc; i++) // Memory, slower
            {
                // 0 - 9
                if (abc == 5)
                {
                    continue;
                }
                Console.WriteLine(abc);
            }



            // FOr


            List<int> abcc = new List<int>() { 1, 2, 3, 5, 6, 8 };

            foreach (var item in abcc)
            {
                Console.WriteLine(item);
                //item = 10;
            }


            while (abc <= 5) // 
            {
                Console.WriteLine(abc);
                abc++;
            }

            do
            { // 1 Var to jase j ani andar
                Console.WriteLine(abc);
                abc++;

            } while (abc <= 5); // Last


            // While
            // Do while
            // Foreach


            //switch (sw)
            //{
            //    case 1:
            //        Console.WriteLine("1");
            //        break;
            //    case 2:
            //        Console.WriteLine("1");
            //        break;
            //    case 3: // OR_
            //    case 5:
            //        Console.WriteLine("1");
            //        break;
            //    default:
            //        break;
            //}


            //1 True
            //0 False

            //public int MyProperty { get; set; }
            // = // Assignment
            // == // Comparision

            //if (true) Console.WriteLine(a++);
            //else Console.WriteLine(a++);

            //var c = (b == a || b == a) ? "Jigar" : "Himani";

            //if (false)
            //{
            //    Console.WriteLine(a++);
            //}
            //else if (true)
            //{
            //    Console.WriteLine(a++);
            //}
            //else if (true)
            //{
            //    Console.WriteLine(a++);
            //}
            //else if (true)
            //{
            //    Console.WriteLine(a++);
            //}
            //else
            //{
            //    Console.WriteLine(a++);

            //}

            //if (b == a && b == a)
            //{
            // Console.WriteLine(a++);


            //}
            //else
            //{
            //Console.WriteLine(a++);
            //}

            //for (int i = 0; i < length; i++)
            //{

            //}

            //foreach (var item in collection)
            //{

            //}


            //1 && 1 && 1 >> 1 
            //1 && 0 && 1 >> 0 
            //1 && 1 && 0 >> 0
            //0 && 1 && 1 >> 0

            //1 || 1 || 1 >> 1 
            //1 || 0 || 1 >> 1 
            //1 || 1 || 0 >> 1
            //0 || 1 || 1 >> 1




            // Post incremnt
            //Pre increment

            //Post decremtn
            //Pre Decrement
            //Console.WriteLine(a++); //10
            //Console.WriteLine("<br />"); //10
            //Console.WriteLine(a); //11


            //Console.WriteLine(++a); //11
            //Console.WriteLine("<br />"); 
            //Console.WriteLine(a); //11


            //Console.WriteLine(a--); //10
            //Console.WriteLine("<br />");
            //Console.WriteLine(a); //9






            Console.ReadLine(); // 

            //Console.WriteLine(a);
        }

        // 5!
        // 0 1 1 2 3 6

        //void
        //
        public static void GetData(ref int a)
        {

            a = 5 * 10;

        }

        public static string GetData1() //MO
        {

            return "jigar";


        }

        public static int GetData2(int b, int a) //Default value
        {
            return a * b;

        }
        //5! : 
        public static int MyCustomFun(int n)
        {
            //1 2 3 4 5 6



            if (n == 0)
            {
                return n;
                //Console.WriteLine(n);

            }
            else if (n == 1)
            {
                return 1;
                //Console.WriteLine(n);

            }
            else
            {
                return (n * MyCustomFun(n - 1));
            }

        }

    }
}
