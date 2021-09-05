using System;


/*************Test_Enums_Program*******************
  This creates a small project to learn how enums
  can work and what are possible uses for them. If
  there is anything out of order or misunderstood
  please reach out and show me what could be done 
  differently thank you!
**************************************************/

//*****************Review*****************

// Whats a value type?
// A value type holds data within its own memory allocation; Or, a value type contains an instance of the type.

// What does integral refer too?
// Integral refers to integer types (i.e. whole numbers).

// What is a constant or const?
// A const gives the ability to declare a variable whose value is specified at compile time and cannot be changed at runtime.

// What is an Enumeration or enum?
// An enumeration type is a value-type defined by a set of named constants of the underlying integral numeric type.
// * An enum is used to group named constants; In C# enums are value-types.
// * Enum constants must be integral value-types


/// <summary>
/// This namespace uses information from Microsoft docs to help understand how enums work
/// </summary>
namespace Test_Projects.StudyEnums
{
  /// <summary>
  /// Creates a public class for enum testing and understanding
  /// </summary>
  class TestEnums
  {
    /// <summary>
    /// uses the enum keyword to specify an enum for Color constants; 
    /// By default, the associated constant values of enum members are of type int; they start with zero and increase by one.
    /// </summary>
    enum Color
    {
      Green,
      Blue,
      Red,
      Orange,
      Yellow,
      Vermillion
    }

    /// <summary>
    /// An enum can be explicitly specified any other integral-numeric-type as an underlying type of an enumeration type.
    //  Also, it can explicitly specify the associated constant values, 
    /// </summary>
    enum Color2 : ushort
    {
      Green = 20,
      Blue = 40,
      Red = 60,
      Orange = 80,
      Yellow = 95,
      Vermillion = 100
    }

    // You cannot define a method inside the definition of an enumeration type. To add functionality to an enumeration type, create an extension method.

    static void Main()
    {

      // Prints out choice message with possible colors
      Console.WriteLine("Possible color choices: ");
      // Uses an iteration to print the possible colors from enum Color
      foreach(string s in Enum.GetNames(typeof(Color)))
      {
        // basically states for each value=s inside the enum Color, Print those color values.
        Console.WriteLine(s);
      }

      // Instantiates the enum Color as favorite
      Color favorite = Color.Vermillion;

      // Prints the favorite color called as the favorite variable
      Console.WriteLine("\nFavorite color is {0}", favorite);

      // Does a similar thing as the above but casts it as the integral number assigned to the enum constant, i.e., if Red is index 0 print 0;
      Console.WriteLine("\nOur real favorite color is {0}", (int)favorite);

      // Instantiates enum constant vermillion from Color2 as favorite1.
      Color2 favorite1 = Color2.Vermillion;

      // Prints the results from enum Color 2 both the color and number.
      Console.WriteLine("\nNah the above is joking. Our most favorite color of all is {0}", favorite1);
      // Casts explicitly the ushort type to favorite1 for the variable numeric output.
      Console.WriteLine("\nWhen you thought I couldn't make up my mind, the real favorite is: {0}", (ushort)favorite1);
    }
  }
}