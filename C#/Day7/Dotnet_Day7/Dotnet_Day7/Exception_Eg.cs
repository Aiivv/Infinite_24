using System;
namespace Dotnet_Day7
{
    class Exception_Eg
    {
        public static void Main()
        {
            try
            {
                Console.WriteLine("Enter two Number: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Second Number :");
                int b = Convert.ToInt32(Console.ReadLine());
                int c = a / b;
                int[] arr = { 1, 2, 3, 4, 5, 6 };
                Console.WriteLine(arr[7]);
                Console.WriteLine(c);
                Console.ReadLine();
            }
            //catch (Exception ex)
            //{
            //    Console.WriteLine("jds");

            //}
            catch (FormatException ex1)
            {
                Console.WriteLine(ex1.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message + ex.StackTrace + ex.Source );
            }
            catch(IndexOutOfRangeException obj)
            {
                Console.WriteLine(obj.Message);
            }
            //when we are not particular to catch a specific exception 
            //then we can catch the base class exception(Exception Class)
            //this catch should be the last catch
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            finally
            {
                Console.ReadLine() ;
            }
        }
    }
}