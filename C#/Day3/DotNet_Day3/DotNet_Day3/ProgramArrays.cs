using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Day3
{
    class Arrays_Eg
    {
        public void SingleDimension()
        {
            int[] arr = new int[5] { 6, 23, 1, 45, 12 };
            Console.WriteLine("The length of the array is: " + arr.Length);
            Console.WriteLine("Before Sort");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("After Sorting");
            System.Array.Sort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
    internal class ProgramArrays
    {
        static void Main(string[] args)
        {
            //Arrays_Eg obj=new Arrays_Eg();
            //obj.SingleDimension();
            //int[,] array = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            //Console.WriteLine(array[1, 1]);
            //Console.WriteLine(array[0, 0]);
            ////1st loop to iterate rows
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write(array[i ,j]  + " ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.Read();
            //String obj = new String();
            //obj.Stringsd();
            //Console.ReadLine();
            //int a = 10;
            //a = 20;
            //int b = a;
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //b = 59;
            //Console.WriteLine(b);
            //Console.WriteLine(a);

            //Console.WriteLine(a);
            //Console.ReadLine();
            MethodsnParameters obj=new MethodsnParameters();
            int number = 10;
            obj.CallByValue(number);//Caller Function
            Console.WriteLine($"The value of Number is {number}");
            obj.CallByRef(ref number);
            Console.WriteLine($"The value of number is {number}");
            //MethodsnParameters obj2=new MethodsnParameters();
            int total = 0, prod, difference, division;
            total=obj.Calculate_Function(14,25,out difference,out prod,out division);
            Console.WriteLine($"Sum of 14 and 25 is {total},Product is {prod},difference is {difference},division is {division}");
            Console.Read();
            

            Console.WriteLine("**********Params Example************");
            int total1=obj.AddElements();
            Console.WriteLine("The total is {0}", total1);
            int total2=obj.AddElements(14);
            Console.WriteLine("The total is {0} ",total2);  
             total = obj.AddElements(12, 23, 45, 212, 124, 6);
            Console.WriteLine("The total is {0}",total);
            //Console.ReadKey();

            Console.WriteLine("-------------Second Params Example output------------");
            int[] test_Array = new int[] { 12, 23, 12 };
            obj.Params_method2(test_Array);
            obj.Params_method2(2, 4, 34, 5, 4, 1, 3, 45);

            Console.WriteLine("----------------Third Params Example output------------");
            obj.Params_3(12,32);
            obj.Params_3(12, 23.3f, 12, 24, 20, 56, 23.65);
            Console.ReadKey();
        }
    }
}
