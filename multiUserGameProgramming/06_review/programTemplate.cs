// Geovanny Moncayo, Review Project, v0.1

using System;

namespace ReviewProject
{
    class ReviewProject
    {
        static void Main(string[] args)
        {
            // Declaring and Assigning Variables
            // Integer -- -2,147,483,648 to 2,147,483,647
            // Integer = 4 Bytes.
            int exaInt = 1;

            // Long -- -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
            // Long = 8 Bytes
            long myLong = 9223372036854775000;

            // Float -- Stores up to 6-7 decimal digits.
            // Float = 4 Bytes
            float exaFloat = 0.1f;

            // Double -- Stores up to 15 decimal digits.
            // Double = 8 Bytes
            double exaDouble = 17.12342134321243D;

            // Boolean -- true / false
            // Boolean = 1 bit
            bool exaBool = true;

            // String
            // 2-btes PER CHARACTER
            // Must be in DOUBLE QUOTES " "
            string exaString = " ";

            // Character (char)
            // Single character, in SINGLE QUOTES ' '
            // 2-bytes
            char myChar = 'C';

            // Type Casting -- change from one data type to another.
            // IMPLICIT -- happens automatically when going smaller -> larger
            // char -> int -> long -> float -> double

            int myInt = 9;
            double myDouble = myInt;
            Console.WriteLine(myDouble);

            // EXPLICIT -- Must be done manually when going larger -> smaller
            // double -> float -> long -> int -> char
            double exampleDouble = 9.1234567891D;
            int exampleInt = (int) exampleDouble;
            Console.WriteLine(exampleInt);
            
            // Conversion Methods

            string newString = Convert.ToString(myChar); // String
            double newDouble = Convert.ToDouble(exaFloat); // Double
            //int newInt = Convert.ToInt32(myLong); // Integer
            //long newLong = Convert.ToInt64(exaInt); // Long
            
            // Switch Statement
            int dayOfWeek = 9;
            switch (dayOfWeek)
            {
                case 1:
                    Console.WriteLine("The day is Sunday.\n");
                    break;
                case 2:
                    Console.WriteLine("The day is Monday.\n");
                    break;
                case 3:
                    Console.WriteLine("The day is Tuesday.\n");
                    break;
                case 4:
                    Console.WriteLine("The day is Wednesday.\n");
                    break;
                case 5:
                    Console.WriteLine("The day is Thursday.\n");
                    break;
                case 6:
                    Console.WriteLine("The day is Friday.\n");
                    break;
                case 7:
                    Console.WriteLine("The day is Saturday.\n");
                    break;
                default:
                    Console.WriteLine("No match found.\n");
                    break;
            }
        }
    }
}