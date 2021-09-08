using System;

namespace _6_FlowControl
{
  public class Program
  {

    public static string username { get; set; }
    public static string password { get; set; }
    static void Main(string[] args)
    {

      int temp = GetValidTemperature();
      Console.WriteLine(temp);
      GiveActivityAdvice(temp);

      Register();
      if (Login())
      {
        Console.WriteLine("Correct input");
      }

      GetTemperatureTernary(temp);


    }

    /// <summary>
    /// This method gets a valid temperature between -40 asnd 135 inclusive 
    /// and returns the valid int. 
    /// </summary>
    /// <returns></returns>
    public static int GetValidTemperature()
    {
      // throw new NotImplementedException($"GetValidTemperature() has not been implemented.");
      int temp = 136;
      bool unsuccessful;
      do
      {
        Console.WriteLine("Enter a valid number between -40 and 135: ");
        string v = Console.ReadLine();
        unsuccessful = int.TryParse(v, out temp);
      } while (!unsuccessful || temp < -40 || temp > 135);

      Console.WriteLine("Correct!");
      return temp;
    }

    /// <summary>
    /// This method has one int parameter
    /// It prints outdoor activity advice and temperature opinion to the console 
    /// based on 20 degree increments starting at -20 and ending at 135 
    /// n < -20, Console.Write("hella cold");
    /// -20 <= n < 0, Console.Write("pretty cold");
    ///  0 <= n < 20, Console.Write("cold");
    /// 20 <= n < 40, Console.Write("thawed out");
    /// 40 <= n < 60, Console.Write("feels like Autumn");
    /// 60 <= n < 80, Console.Write("perfect outdoor workout temperature");
    /// 80 <= n < 90, Console.Write("niiice");
    /// 90 <= n < 100, Console.Write("hella hot");
    /// 100 <= n < 135, Console.Write("hottest");
    /// </summary>
    /// <param name="temp"></param>
    public static void GiveActivityAdvice(int temp)
    {
      //throw new NotImplementedException($"GiveActivityAdvice() has not been implemented.");
      if (temp < -20)
      {
        Console.Write("hella cold\n");
      }
      else if (temp >= -20 && temp < 0)
      {
        Console.Write("pretty cold\n");
      }
      else if (temp >= 0 && temp < 20)
      {
        Console.Write("cold\n");
      }
      else if (temp >= 20 && temp < 40)
      {
        Console.Write("thawed out\n");
      }
      else if (temp >= 40 && temp < 60)
      {
        Console.Write("feels like Autumn\n");
      }
      else if (temp >= 60 && temp < 80)
      {
        Console.Write("perfect outdoor workout temperature\n");
      }
      else if (temp >= 80 && temp < 90)
      {
        Console.Write("niiice\n");
      }
      else if (temp >= 90 && temp < 100)
      {
        Console.Write("hella hot\n");
      }
      else if (temp >= 100 && temp < 135)
      {
        Console.Write("hottest\n");
      }
    }

    /// <summary>
    /// This method gets a username and password from the user
    /// and stores that data in the global variables of the 
    /// names in the method.
    /// </summary>
    public static void Register()
    {
      // throw new NotImplementedException($"Register() has not been implemented.");
      Console.WriteLine("Enter you username: ");
      username = Console.ReadLine();
      Console.WriteLine("Enter your password: ");
      password = Console.ReadLine();


    }

    /// <summary>
    /// This method gets username and password from the user and
    /// compares them with the username and password names provided in Register().
    /// If the password and username match, the method returns true. 
    /// If they do not match, the user is reprompted for the username and password
    /// until the exact matches are inputted.
    /// </summary>
    /// <returns></returns>
    public static bool Login()
    {
      // throw new NotImplementedException($"Login() has not been implemented.");
      string inputUsername;
      string InputPassword;

      Console.WriteLine("Please enter the username and password that you created: ");
      do
      {
        Console.WriteLine("Enter you username: ");
        inputUsername = Console.ReadLine();
        Console.WriteLine("Enter your password: ");
        InputPassword = Console.ReadLine();

      }

      while (!Equals(inputUsername, username) || !Equals(InputPassword, password));

      return true;
    }

    /// <summary>
    /// This method has one int parameter.
    /// It checks if the int is , Console.WriteLine($"{temp} is too cold!");
    /// between 43 and 78 inclusive, Console.WriteLine($"{temp} is an ok temperature");
    /// or > 78, Console.WriteLine($"{temp} is too hot!");
    /// For each temperature range, a different advice is given. 
    /// </summary>
    /// <param name="temp"></param>
    public static void GetTemperatureTernary(int temp)
    {
      //throw new NotImplementedException($"GetTemperatureTernary() has not been implemented.");
      var result2 = temp <= 42 ? $"{temp} is too cold!" :
        temp >= 43 && temp <= 78 ? $"{temp} is an ok temperature" : $"{temp} is too hot!";

      Console.WriteLine(result2);

    }
  }//EoP
}//EoN
