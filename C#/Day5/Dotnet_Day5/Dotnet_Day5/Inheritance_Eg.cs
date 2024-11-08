//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Dotnet_Day5
//{

//    internal class x
//    {
//        //float secret;
//        public int ID;
//        protected string XName;
//        internal DateTime DOJ;

//        public x(int id, string name, DateTime doj)
//        {
//            ID = id;
//            XName = name;
//            DOJ = doj;
//        }
//    }
//    class y : x
//    {
//        //base class being initialized through the child class constructor
//        public y(int idy, string namey, DateTime dojy) : base(idy, namey, dojy)
//        {
//            Console.WriteLine("Base class created with data");
//        }

//        public static void Main()
//        {
//            //y y1 = new y();//child class or derieved class
//            //y1.ID = 1;
//            //y1.XName = "Infinite";
//            //y1.DOJ = Convert.ToDateTime("01/01/2003");
//            //Derived derived=new Derived(5,19);
//            Inheritance_Eg obj = new Inheritance_Eg(4);

//            Console.Read();

//        }

//        internal class Inheritance_Eg
//        {
//            public int data1;
//            public Inheritance_Eg(int n)
//            {
//                data1 = n;
//                Console.WriteLine(data1);

//            }
//            public Inheritance_Eg()
//            {
//                Console.WriteLine(data1);
//            }
//        }
//        class Derived : Inheritance_Eg
//        {
//            public Derived(int mynum) : base(mynum)
//            {
//                data1 = mynum;
//                Console.WriteLine(data1);
//            }

//            //public Derived(int var) : base(var)
//            {

//            }
//        }
            
//    }
//}
