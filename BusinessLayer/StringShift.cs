/*
[Tamara] This class represent a solution for below question.
p.s = operator cannot be  overload

Implement a class that does string manipulation by overloading the following operators: <<, >>, = and
==.  For example consider the following code:
StrShift example;
example = “Microsoft”;
printf(“\”example << 2\” results in %s\n“, example << 2);
In the above code the output would be “ftMicroso” which shows the last two characters of the string 
“Microsoft” rotated to the left of the string.  Please note that state is maintained so two calls of example 
<< 1 would give the same end result as calling example << 2 once.  Consideration will be given to
correctness, design, code readability as well as any unit testing.  As part of a final solution please submit 
test cases you used to verify correctness in addition to any unit tests done.
*/

namespace BusinessLayer
{
  public class StringShift
  {
    public readonly string Value;

    /// <summary>
    /// Default constructor of String Shift class that take a string value parameter.
    /// </summary>
    /// <param name="value"> The value.</param>
    public StringShift(string value)
    {
      this.Value = value;
    }

    /// <summary>
    /// Overloading that shift the precisions value of instance from left to right
    /// </summary>
    /// <param name="instance"> Instance of object.</param>
    /// <param name="precisions"> Precisions value.</param>
    /// <returns> StringShift object with shifted value.</returns>
    public static StringShift operator << (StringShift instance, int precisions)
    {
     
      string firstPart = instance.Value.Substring(instance.Value.Length - precisions);
      
      string secondPart = instance.Value.Substring(0, instance.Value.Length - precisions);
      
      instance = new StringShift(firstPart + secondPart);

      return instance;
    }

    /// <summary>
    /// Overloading that shift the precisions value of instance from right to left.
    /// </summary>
    /// <param name="instance"> Instance of object.</param>
    /// <param name="precisions"> Precisions value.</param>
    /// <returns> StringShift object with shifted value.</returns>
    public static StringShift operator >>(StringShift instance, int precisions)
    {
   
      string firstPart = instance.Value.Substring(precisions, instance.Value.Length - precisions);

      string secondPart = instance.Value.Substring(0, precisions);
    
      instance = new StringShift(firstPart + secondPart);

      return instance;
    }

    /// <summary>
    ///  Overloading that check for entire objects equality.
    /// </summary>
    /// <param name="firstValue"> StringShoft first object.</param>
    /// <param name="secondValue"> StringShoft second object.</param>
    /// <returns>True or false based on equality result.</returns>
    public static bool operator ==(StringShift firstValue, StringShift secondValue)
    {
      if (System.Object.ReferenceEquals(firstValue, secondValue))
        return true;

      if (((object)firstValue == null) || ((object)secondValue == null))
      return false;

      return firstValue.Value == secondValue.Value;

    }

    /// <summary>
    ///  Overloading that check for entire objects none equality.
    /// </summary>
    /// <param name="firstValue"> StringShoft first object.</param>
    /// <param name="secondValue"> StringShoft second object.</param>
    /// <returns>True or false based on none equality result.</returns>
    public static bool operator !=(StringShift firstValue, StringShift secondValue)
    {
      if (((object)firstValue == null) || ((object)secondValue == null))
        return false;

      if (!System.Object.ReferenceEquals(firstValue, secondValue))
        return true;

      return firstValue.Value != secondValue.Value;
    }

    /// <summary>
    /// Override of equals method .
    /// </summary>
    /// <param name="obj"> The object value.</param>
    /// <returns>True or false based on equality result.</returns>
    public override bool Equals(object obj)
    {
      StringShift r = obj as StringShift;
      if (r != null)
      {
        return r == this;
      }
      return false;
    }

    /// <summary>
    /// Override of the GetHashCode method.
    /// </summary>
    /// <returns>The value hash code.</returns>
    public override int GetHashCode()
    {
      return Value.GetHashCode();
    }

  }
}
