using System;
using System.Collections.Generic;

namespace _8_LoopsChallenge
{
  public class Program
  {
    public static void Main(string[] args)
    {
      List<int> x = new List<int>();
      UseFor(x);
      /* Your code here */
      List<object> x1 = new List<object>();
      UseForEach(x1);

      UseWhile(x);
    }

    /// <summary>
    /// Return the number of elements in the List<int> that are odd.
    /// </summary>
    /// <param name="x"></param>
    /// <returns></returns>
    public static int UseFor(List<int> x)
    {
      // Instantiate the odd variable;

      //throw new NotImplementedException("UseFor() is not implemented yet.");
      int n = 0;
      // For each element of y in the list of x, check to see if the remainder of each is an odd integer;
      foreach (var y in x)
      {
        if (y % 2 == 1)
        {
          n++;
        }
      }
      return n;
    }

    /// <summary>
    /// This method counts the even entries from the provided List<object> 
    /// and returns the total number found.
    /// </summary>
    /// <param name="x"></param>
    /// <returns></returns>
    public static int UseForEach(List<object> x)
    {
      // throw new NotImplementedException("UseForEach() is not implemented yet.");
      // int evenEntries = 0;
      // foreach (object entry in x)
      // {
      //   if (Convert.ToInt32(entry) % 2 == 0)
      //   {
      //     evenEntries++;
      //   }
      // }
      // return evenEntries;

      // Credit goes to austin towler for this block of code
      // variable counter is set to zero
      int counter = 0;
      foreach(object v in x)
      {
        if(v is int)
        {
          if((int) v % 2 == 0)
          {
            counter++;
          }
        }
        if(v is long)
        {
          if((long) v % 2 == 0)
          {
            counter++;
          }
        }
        if(v is byte)
        {
          if((byte) v % 2 == 0)
          {
            counter++;
          }
        }
        if(v is uint)
        {
          if((uint) v % 2 == 0)
          {
            counter++;
          }
        }
        if(v is ulong)
        {
          if((ulong) v % 2 == 0)
          {
            counter++;
          }
        }
        
      }
      return counter;

    }

    /// <summary>
    /// This method counts the multiples of 4 from the provided List<int>. 
    /// Exit the loop when the integer 1234 is found.
    /// Return the total number of multiples of 4.
    /// </summary>
    /// <param name="x"></param>
    public static int UseWhile(List<int> x)
    {
      //throw new NotImplementedException("UseFor() is not implemented yet.");
      int i = 0;
      int count = 0;
      bool flag = true;
      while (flag)
      {
        if(x[i] == 1234 || i == x.Count)
        {
          break;
        }
        if (x[i] % 4 == 0)
        {
          count++;
        }
        i++;
      }
      return count;
    }

    /// <summary>
    /// This method will evaluate the Int Array provided and return how many of its 
    /// values are multiples of 3 and 4.
    /// </summary>
    /// <param name="x"></param>
    /// <returns></returns>
    public static int UseForThreeFour(int[] x)
    {
      counter = 0;
      index = 0;
      //throw new NotImplementedException("UseForThreeFour() is not implemented yet.");
      for(int i = 0; i < x.Count; counter++)
      {
        if(x[index] % 3 && x[index] % 4 == 0)
        {
          index++;
        }
        counter++;
      }
      return counter;
    }

    /// <summary>
    /// This method takes an array of List<string>'s. 
    /// It concatenates all the strings, with a space between each, in the Lists and returns the resulting string.
    /// </summary>
    /// <param name="stringListArray"></param>
    /// <returns></returns>
    public static string LoopdyLoop(List<string>[] stringListArray)
    {
      //throw new NotImplementedException("LoopdyLoop() is not implemented yet.");
      string things ="";

      foreach(var outer in stringListArray)
      {
        foreach(var inner in outer)
        {
          things += inner + " ";
        }
      }
      return things;
    }
  }
}