using System;

    
namespace DotNet_Day6
{
    interface ICustomer
    {
        //string Name { get; set; }
        void PrintCustRating();//only declaration and no implementation
    }

    //one interface can implement other interfaces
    interface ICustomer1 : ICustomer
    {
        int getRating();
    }
    //A class can inherit from multiple interfaces
    class Customer : ICustomer//One class can implement more than one interface
    {
        //public int getRating()
        //{
        //    return 0;
        //}

        public void PrintCustRating()
        {
            Console.WriteLine("Hii let me get execute");
        }

        //public string Name { get; set; } = "ARYAN";
    }

    class InterfaceTester : ICustomer1
    {
        public void PrintCustRating()
        {
            Console.WriteLine("Rating");
        }

        public int getRating()
        {
            return 0;
        }
        public static void Main()
        {
            //ICustomer ic; //creating an interface object
            //ic=new ICustomer(); //cannot instantiate an interface

            Customer c = new Customer();
            c.PrintCustRating();

            InterfaceTester itester = new InterfaceTester();
            itester.getRating();
            itester.PrintCustRating();
            //Console.WriteLine(c.Name);
            Console.Read();
        }
    }

}
