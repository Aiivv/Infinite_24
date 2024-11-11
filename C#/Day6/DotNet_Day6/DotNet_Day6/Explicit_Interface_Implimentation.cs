using System;
namespace DotNet_Day6
{
    interface IMyInterface1
    {
        void Show(string s);
    }
    interface IMyInterface2
    {
        void Show(string s);
    }

    class Explicit_Interface_Implimentation : IMyInterface1, IMyInterface2
    {
        void IMyInterface1.Show(string s)
        {
            Console.WriteLine("Heloo my name is " + s);
        }
        void IMyInterface2.Show(string s)
        {
            Console.WriteLine("Helloo  my name is 25" + s);
        }

        

        public static void Main()
        {
            Explicit_Interface_Implimentation EII =new Explicit_Interface_Implimentation();
            //option 1



            //option 2 COVARIANCE
            IMyInterface1 obj = new Explicit_Interface_Implimentation();
            IMyInterface2 obj2 =new Explicit_Interface_Implimentation();
            obj.Show("Ai");
            obj2.Show("AIIIIivvvvvv");
            Console.Read();
        }
    }
    public partial class Testing1
    {
        public void orderDeclaration()
        {

        }
    }
}
