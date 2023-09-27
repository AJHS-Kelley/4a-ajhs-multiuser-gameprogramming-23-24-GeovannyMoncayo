// Geovanny Moncayo, Operators, v0.3
using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString1 = "string1";
            string myString2 = "string2";

            int myInt1 = 1;
            int myInt2 = 2;

            float myFloat1 = 1.0F;
            float myFloat2 = 2.0F;

            // Arithmetic Operators
            Console.WriteLine(myInt1 + myInt2);
            Console.WriteLine(myString1 + myString2);
            Console.WriteLine(myFloat1 + myFloat2);
            Console.WriteLine(myInt1 + myFloat2);

            Console.WriteLine(myInt1 - myInt2);
            // Console.WriteLine(myString1 - myString2); DOES NOT APPLY TO STRINGS
            Console.WriteLine(myFloat1 - myFloat2);
            Console.WriteLine(myInt1 - myFloat2);

            Console.WriteLine(myInt1 / myInt2);
            // Console.WriteLine(myString1 / myString2); DOES NOT APPLY TO STRINGS
            Console.WriteLine(myFloat1 / myFloat2);
            Console.WriteLine(myInt1 / myFloat2);

            Console.WriteLine(myInt1 * myInt2);
            // Console.WriteLine(myString1 * myString2); DOES NOT APPLY TO STRINGS
            Console.WriteLine(myFloat1 * myFloat2);
            Console.WriteLine(myInt1 * myFloat2);

            // Modulus
            Console.WriteLine(10 % 2);
            Console.WriteLine(9 % 4);

            // Increment
            int myInt3 = 1;
            myInt3++;
            Console.WriteLine(myInt3);

            // Decrement
            int myInt4 = 2;
            myInt4--;
            Console.WriteLine(myInt4);

            // Assignment Operators
            // =
            myInt1 = myInt2;
            // +=
            myInt1 += myInt2;
            // -=
            myInt1 -= myInt2;
            // *=
            myInt1 *= myInt2;
            // /=
            myInt1 /= myInt2;

            // Comparison Operators
            // Is Equal To
            Console.WriteLine(myInt1 == myInt2);
            // Greater Than
            Console.WriteLine(myInt1 > myInt2);
            // Greater Than or Equal To
            Console.WriteLine(myInt1 >= myInt2);
            // Less Than
            Console.WriteLine(myInt1 < myInt2);
            // Less Than or Equal To
            Console.WriteLine(myInt1 <= myInt2);
            // Not Equal To
            Console.WriteLine(myInt1 != myInt2);

            // Logical Operators
            // And
            Console.WriteLine(myInt1 == myInt2 && myFloat1 == myFloat2);
            // Or
            Console.WriteLine(myInt1 == myInt2 || myFloat1 == myFloat2);
            // Not
            Console.WriteLine(!(myInt1 == myInt2 || myFloat1 == myFloat2));
        }
    }
}