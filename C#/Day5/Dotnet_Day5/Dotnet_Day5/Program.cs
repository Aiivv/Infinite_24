//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Dotnet_Day5
//{
//    internal class Program
//    {
//        public int x; // non-static member
//        static int y = 111; //static member (class level)
//        const float z = 23.23f;  //const variable(class level)
//        //readonly
//        public readonly int myvariable1; //just Declaration
//        public readonly int myvariable2 = 10; //decl And initialization


//        //constructor to initialize the readonly variables
//        public Program()
//        {
//            //myvariable1 = a;
//            //myvariable2 = b;
//            Console.WriteLine("Value of Myvariable1 : {0}, and value of Myvariable2 : {1}", myvariable1, myvariable2);
//            y = 13;
//        }

//        static void Main(string[] args)
//        {
//            //Program obj1=new Program(100,200);
//            Program obj1 = new Program();
//            //obj1.myvariable1 = 12;
//            Console.ReadLine();
//        }
//    }
//}
