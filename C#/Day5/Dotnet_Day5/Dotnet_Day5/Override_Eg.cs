using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Day5
{
    internal class Shapes
    {
        protected float R, L, B;

        public virtual float Area()
        {
            return 3.14f * R * R; //area of circle
        }
    }

    class Rectangle : Shapes
    {
        public void GetLengthnBreadth()
        {
            Console.Write("Enter Length: ");
            L = Convert.ToSingle(Console.ReadLine());
            Console.Write("Enter Breadth: ");
            B = float.Parse(Console.ReadLine());
        }

        //overriding the area method of the parent

        public override float Area()
        {
            GetLengthnBreadth();
            return L * B;
        }
    }

    class Circle : Shapes
    {
        public void GetRadius()
        {
            Console.WriteLine("Enter Radius: ");
            R = Convert.ToSingle(Console.ReadLine());
        }
        public override float Area()
        {
            GetRadius();
            return 3.14f * R * R;
        }
    }

    class Final
    {
        public static void Main()
        {
            /* Rectangle obj1=new Rectangle();
             obj1.GetLengthnBreadth();
             Console.WriteLine("Are of rectangle is "+obj1.Area());
             Console.WriteLine("-------------------");
             Circle obj2=new Circle();
             obj2.GetRadius();
             Console.WriteLine("Area of Circle is "+obj2.Area());
             Console.Read();*/

            //Dynamic polymorphic or late binding behaviour of the object 's' using co-variance
            Shapes s = new Shapes();
            Console.WriteLine(s.Area());  //14
            s = new Rectangle();//co-variance
            Console.WriteLine(s.Area());  //32
            s=new Circle();  //co-variance
            Console.WriteLine(s.Area());  //46
            Console.Read();  
        }
    }
}

