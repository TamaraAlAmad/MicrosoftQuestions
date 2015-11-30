/*
[Tamara] This class represent a solution for below question.

2. Write a method that takes a given string and replaces all occurrences of one string with another string,
returning the number of replaces made.  For instance given the string “Microsoft” if you were to replace 
all occurrences of “ic” with “MSFT” the result would be “MMSFTrosoft” with a return value of 1.  As part 
of a final solution please provide unit tests done as well as any test cases ran.  Please note that you may
not use String.Replace or string::replace depending upon the language you use; you must write this 
functionality yourself.
*/

using System.Collections.Generic;
using System.Globalization;

namespace BusinessLayer
{
  /// <summary>
  /// Handel curtom string replace.
  /// </summary>
  public class CustomReplace
  {
    /// <summary>
    /// Get or set the replaces input value.
    /// </summary>
    private string ReplacedInput { get; set; }
    /// <summary>
    /// This method takes a given string and replaces all occurrences of one string with another string,
    /// and return the number of replaces made.
    /// </summary>
    /// <param name="oldValue">Old string value to replace.</param>
    /// <param name="newValue">New string value to replace with.</param>
    /// <param name="input">Input given string </param>
    /// <returns>Number of replaces made.</returns>
    public int StringReplace(string oldValue, string newValue,ref string input)
    {
      // Initialize counter to count number of replacement made.
      int counter = 0;

      // Process the input replace operation
      foreach (var item in ProcessReplace(oldValue, newValue, input))
      {
        counter = item;
      }

      // Set the input to the replaced input value.
      input = ReplacedInput;

      // Return of replaces made.
      return counter;

    }

    /// <summary>
    /// This method process the replace operation which takes a given string and replaces all occurrences of one string with another string,
    /// and return the number of replaces made.
    /// </summary>
    /// <param name="oldValue"> Old string value to replace.</param>
    /// <param name="newValue"> New string value to replace with.</param>
    /// <param name="input"> Input given string </param>
    /// <returns> Number of replaces made.</returns>
    private IEnumerable<int> ProcessReplace(string oldValue, string newValue, string input)
    {
      // Initialize counter to count number of replacement made.
      int counter = 0;

      // Get the length of old value string.
      int oldValueLength = oldValue.Length;

      for (int index = 0; index < input.Length; index++)
      {
        // Check if the difference between input string length and old string value is less than or equal of the current index 
        // and the substring from current index with length of old value string is equal to old value.
        if (index <= (input.Length - oldValueLength) &&
            string.Compare(input.Substring(index, oldValueLength), oldValue, false, CultureInfo.InvariantCulture) == 0)
        {
          // Remove the old value.
          input = input.Remove(index, oldValueLength);

          // Insert the new value.
          input = input.Insert(index, newValue);

          //set the replaced input value with updated input.
          ReplacedInput = input;

          // Add the counter by one since one replace made.
          counter++;

          // Call StringReplace again to caluculate the  
          yield return counter;
        }
      }
    }
  }
}
