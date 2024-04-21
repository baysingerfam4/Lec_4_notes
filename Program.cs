using System;
using System.Drawing;
using System.Dynamic;
using System.Runtime.Intrinsics.X86;
using System.Xml;

namespace Lec_4_notes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Carla Baysinger
            // Lecture 4 notes
            // 04/20/2024

            // April 12th Topics

            // Quick Followup 
            // Strings are weird
            // Pedmas
            FloatingPointTypeExample();

            MathManipulation();
            TryCatchExample();
            //HomeworkExamples();
            Question6();





        } // Main

        public static void FloatingPointTypeExample()
        {
            // ---------------------------
            // Floating Point Types ( float and double )
            // Precision and Memory
            // Decimal Type
            // ---------------------------
            // A floating point type is a number that has a decimal
            // float type single precision
            //we need to be explicit when we declare a float value, by putting f after our value
            float floatValue = 1.2f;

            //Double type - double precision
            double doubleValue = 1.2;

            //decimal type - has largest range, highest precision and highest memory cost(16 bit)
            decimal decimalValue = 1.234556m;

            //cannot work with x type please convert to string
            //to convert to string, you can call the .ToString() on any object

            Console.WriteLine(doubleValue);


        } // FloatingPointTypeExample()

        public static void MathManipulation()
        {
            
            // ---------------------------
            // Revisit Parsing
            //Console.Write("Enter number 1: ");
            //string userString1 = Console.ReadLine();

            //Console.Write("Enter number 2: ");
            //string userString2 = Console.ReadLine();
            ////parse the string into a number

            //try
            //{
            //    double userNumber1 = double.Parse(userString1);
            //    double userNumber2 = double.Parse(userString2);
            //    double sum = userNumber1 + userNumber2;
            //    Console.WriteLine(sum);
            //}
            //catch
            //{
            //    Console.WriteLine("The number was invalid");
            //}

            // Math with Doubles
            int number1 = 10;
            double number2 = 3;
            double result = 10/3.0;
            Console.WriteLine(result);


            //If we try to parse a string into different type, and the type is invalid, you will receive a FormatException Error
            //Runtime
            // try/catch
            // To use a try catch, you declare a try block, followed by a catch block.

            //casting
            //// Implicit casting
            //double number1 = 1;
            //// Explicitly cast
            //// We have to give permission to lose data
            ////we cast but putting the type we want to convert to in parentheses in front of our data
            //int number2 = (int) 1.054678;
            //Console.WriteLine(number2);

            // Rounding
            // Math Library with the keyword...Math
            double numberToRound = 1.6534512;
            double roundedNumber = Math.Round(numberToRound,2);
            Console.WriteLine(roundedNumber.ToString("c"));
            // .ToString() converts a value into a string
            // Pass in an argument that formats the value
            //"c" format will display the currency symbol and round the value to 2 decimal place (double check for precision)


        } //MathManipulation()

        public static void TryCatchExample()
        {
            //ctrl k,c to comment code
            //ctrl k,u to uncomment code
            // If you highlight a selection of code it will do a multi line comment
            // Try catch always has to be grouped together

            Console.Write("Enter a number: ");
            double userNumber = 0;
            try
            {
                userNumber = double.Parse(Console.ReadLine());
                Console.WriteLine($"The users number is (userNumber)");
            }

            catch (FormatException fex)
            {
                Console.WriteLine("The number you entered was invalid");
                Console.WriteLine(fex.StackTrace);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("After our try catch block");
        }

        public static void Question6()
        {
            //6.Write a program that prompts the user to input a length expressed in centimeters.The program should then convert the length to inches(to the nearest inch) and output the length expressed in yards, feet, and inches, in that order. For example, suppose the input for centimeters is 312.To the nearest inch, 312 centimeters is equal to 123 inches. 123 inches would thus be output as:

            // 1. Ask user for length in centimeters
            int centimeters = 0;
            try
            {
                Console.Write("Enter a length in centimeters");
                string userInput = Console.ReadLine();
                centimeters = int.Parse(userInput);
            }
            catch
            {
                Console.WriteLine("Your value was an invalid format");
            }


            // 1a. Parse user length to number
            // 1b. Wrap in a try / catch

            // 2. Convert users length to inches
            double convertedToInches = Math.Round( centimeters/ 2.54);
            Console.WriteLine(convertedToInches);
            // 2b. Get the conversion
            // 3. Convert to yards, feet, and inches
            int inchesInYard = 36;
            //Getting whole number of yards
            int yards = (int)convertedToInches / 36;
            //Getting remaining inches
            convertedToInches %= inchesInYard;

            // Getting the inches
            int inchesInFoot = 12;
            int feet = (int)convertedToInches /inchesInFoot;

            //Get remaining inches
            convertedToInches %= inchesInFoot;
            int inches = (int)convertedToInches;

            // 3 yards, 1 feet(foot), and 3 inch(es)
            Console.WriteLine($"{yards} yard(s), {feet} feet (foot), and {inches} inch(es)");
            // Display

        }

        public static void HomeworkExamples()
        {
            // ---------------------------
            // Question Examples
            // Homework
            // ----------------------------
          //1.What are the two primary floating - point types in C#? float and double

          //2.What is the difference between float and double in C#? double is larger than float

          //3.Why is it generally recommended to use double instead of float for floating - point arithmetic ? double can hold more numbers

          //4.How does C# represent floating-point numbers internally? placing an f next to the number

          //5.What are some common issues or considerations when performing arithmetic operations with floating - point numbers in C#? You can only provide 6 to 9 digits when using float and if you don't provide an f it automatically goes to double.

        }


    } // Class
} //namespace
