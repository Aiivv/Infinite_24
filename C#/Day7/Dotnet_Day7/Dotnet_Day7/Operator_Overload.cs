using System;

namespace Dotnet_Day7
{

    class Travel
    {

        public int Dist { get; set; }

        public DateTime TravelDate { get; set; }

        //overload a + operator in order to add 2 distance
        //some rules to be followed

        public static Travel operator +(Travel tr1, Travel tr2)
        {
            Travel temp = new Travel();
            temp.Dist = tr1.Dist + tr2.Dist;
            return temp;
        }

        public static Travel operator ++(Travel tr14)
        {
            //Travel t = new Travel();
            tr14.Dist++;
            return tr14;
        }

        public static bool operator >=(Travel tr1, Travel tr2)
        {
            return tr1.Dist >= tr2.Dist;
        }

        public static bool operator <=(Travel tr1, Travel tr2)
        {
            return (tr1.Dist <= tr2.Dist);
        }
    }

    class Operator_Overload
    {
        public static void Main()
        {
            Travel t1 = new Travel();
            Travel t2 = new Travel();
            t1.Dist = 12;
            t2.Dist = 20;
            Travel t3 = t1 + t2;
            Console.WriteLine("The total distance to travel is " + t3.Dist);
            Travel t20 = new Travel();
            t20.Dist = 123;
            t20.Dist++;
            Console.WriteLine("The increment operator is  " + t20.Dist);
            Console.WriteLine("is T1  greater than or equal to T2 "+ ( t1>=t2));
            Console.WriteLine("is T1  less than or equal to T2 "+ ( t1<=t2));
            Console.Read();
        }
    }
}