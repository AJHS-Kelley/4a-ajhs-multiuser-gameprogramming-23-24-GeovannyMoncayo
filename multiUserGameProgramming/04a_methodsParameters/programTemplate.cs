// Geovanny Moncayo, Methods and Parameters, v0.2

using System;

namespace MethodsParameters
{
    class MethodsParameters
    {   
        // METHOD -- name block of code, can be used over and over.
        // All methods have a SIGNATURE that defines their name, parameters, and ************************************
        // Example Signature
        static void MyMethod()
        {
            Console.WriteLine("I like mine with lettuce and tomatoes, Heinz 57, and french fried potatoes.\n");
        }
        // static -- This method belongs to the current class, it is NOT an object ************************************
        // void -- This method has no return value.
        
        static int DoubleUp()
        {
            int sum = 0;
            Console.WriteLine("This method will double a number and return it.\n");
            Console.WriteLine("Please enter a number on the next line.\n");
            sum = System.Convert.ToInt32(Console.ReadLine());
            //sum *= 2;
            //Console.WriteLine(sum);
            return sum *= 2;
        }
        static void Main(string[] args)
        {
            //MyMethod();
            DoubleUp();
        }
    }
}