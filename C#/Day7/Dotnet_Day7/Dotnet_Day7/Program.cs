using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Day7
{
    abstract class Shapes
    {
        
        //properties
         public int n = 12;
        //properties
        public int Sample {  get; set; }
        //abstract methods
        public abstract int Area();

        //Default Method
        public void Method1() {

            
        }
        
        //Virtual Method
        public virtual void DrawShape()
        {
            Console.WriteLine("It is the shape");
        }
        //So basically an abstract class can contain all an abstract method a non abstract method,a virtual method
        // and a default method.
    }
    class Square : Shapes
    {
        int side = 0;
        public Square(int n)
        {
            side = n;
        }
        public override int Area()
        {
            Console.WriteLine("Area of circle is " + side * side);
            return side * side;
            
        }

        public override void DrawShape()
        {
            base.DrawShape();
            Console.WriteLine("It is a square shape");
        }
    }
    class Program
    {
       
        public void Method14()
        {
            var myanonymous = new {Data1="Hello",
            Data2=92,
            Data3="Heya"};
            Console.WriteLine(myanonymous);
        }
        public static void Main()
        {
            Shapes sp = new Square(25);
            Console.WriteLine(sp.Area());
            sp.DrawShape();

            //anonymous type
            //var myvar = 100;
            var myanonymous = new {data1="CSharp",
            data2=2,
            data3=true};
            //Console.WriteLine(myanonymous);
            //Console.WriteLine(myanonymous.GetType());
            Console.WriteLine(myanonymous.GetType().ToString());
            Console.WriteLine(myanonymous.data1);
            Console.WriteLine(myanonymous.data2);
            Console.WriteLine(myanonymous.data3);
            Console.Read();
        }
    }
}