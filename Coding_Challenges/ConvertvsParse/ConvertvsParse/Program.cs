using System;

namespace ConvertvsParse
{
    class Program
    {
        static void Main(string[] args)
        {
          ///Casting:  tables showing implicit and explicit cast from numeric data types to other numeric data types
          //        can be viewed at the following webpage.
         //          https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/numeric-conversions
          
          //Implicit conversion can be made when the value to be stored can fit into the variable
            int iData = 5;
            float fdata = iData;
            Console.WriteLine($"this data: {fdata} is this data: {iData}");

            //Explicit
            float floatData = 4.44f;
            int integerData = (int)floatData;
            Console.WriteLine($"Explicit cast {integerData}");

            //conversion: has built in methods for numeric data types. 
            //converts every base data type to other base data type.
            string someData = "1999";
            int dataData = Convert.ToInt32(someData);
            Console.WriteLine($"Convert string to int using Convert: this is the number {dataData}");

            //Parse: You convert a string to a number by calling the Parse or TryParse method 
            // found on numeric types
            // Use: You use Parse or TryParse methods on the numeric type you expect the string contains
            string input1 = "myString";
            string input2 = "43.3";
            float parsedInput1;

            Console.WriteLine($"Try and parse input1 {input1} to float");
            if(float.TryParse(input1, out parsedInput1))
            {
              Console.WriteLine("Successful TryParse!");
            }
            else{
              Console.WriteLine("Could not convert myString to Float!");
            }
             Console.WriteLine($"Try and parse input1{input2} to float");
            float parsedInput2;
            if(float.TryParse(input2, out parsedInput2))
            {
              Console.WriteLine("Successful TryParse!");
            }
            else{
              Console.WriteLine("Unsuccessful TryParse!");
            }

        }
    }
}
