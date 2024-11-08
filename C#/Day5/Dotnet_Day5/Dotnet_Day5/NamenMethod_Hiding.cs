using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Day5
{

    class Parent
    {
        public float data;
        public void Methodhide(string s)
        {
            Console.WriteLine("This is a message from parent class {0}", s);
        }

    }
    class Child : Parent
    {
        //name hiding
        new float data; //member float data here hides the parent float data

        public Child(float f1,float f2)
        {
            Console.WriteLine(base.data);
            base.data = f1;
            data = f2;
            Console.WriteLine(base.data+ " "+data);
        }
    }

    internal class NamenMethod_Hiding
    {
        static void Main()
        {
            Child child=new Child(2.2f,3.3f);
            
        }
    }
}
