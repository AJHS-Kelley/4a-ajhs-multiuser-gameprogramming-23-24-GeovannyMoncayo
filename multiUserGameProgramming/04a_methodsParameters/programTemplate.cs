// Geovanny Moncayo, Methods and Parameters, v0.5

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
        
        // Methods with Parameters
        static void MakePancake(int num)
        {
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("One golden, fluffy pancake coming up!\n");
            }
        }

        static void MakeEggs(int num, string style)
        {
            Console.WriteLine("You have ordered " + num + " eggs cooked " + style + ".\n");
        }

        static void MakeBurger(int num = 1)
        {
            Console.WriteLine("I am going to cook " + num + " hamburgers.\n");
        }
        static void Main(string[] args)
        {
            //MyMethod();
            //DoubleUp();
            //MakePancake(10);
            //MakeEggs(10, "sunny side up");
            MakeBurger();
            MakeBurger(10);
        }
    }
}