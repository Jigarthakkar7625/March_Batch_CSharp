using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
    }
}
