using BusinessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ManagerTest
{
  [TestClass]
  public class StringShiftTest
  {

    /// <summary>
    /// Test shift from right to left precisions less than value length.
    /// </summary>
    [TestMethod]
    public void ShiftFromRightToLeft()
    {
      //Arrange
      StringShift actual = new StringShift("Microsoft");
      int precision = 2;

      //Act
      actual = (actual << precision);

      //Assert
      Assert.AreEqual(actual.Value, "ftMicroso", "Error in shifting from right to left.");
      
    }

    /// <summary>
    /// Test shift from right to left precisions same as value length.
    /// </summary>
    [TestMethod]
    public void ShiftFromRightToLeftEdge()
    {
      //Arrange
      StringShift actual = new StringShift("Microsoft");
      int precision = 9;

      //Act
      actual = (actual << precision);

      //Assert
      Assert.AreEqual(actual.Value, "Microsoft", "Error in shifting from right to left.");

    }

    /// <summary>
    /// Test shift from left to right precisions less than value length.
    /// </summary>
    [TestMethod]
    public void ShiftFromLeftToRight()
    {
      //Arrange
      StringShift actual = new StringShift("Microsoft");
      int precision = 2;

      //Act
      actual = (actual >> precision);

      //Assert
      Assert.AreEqual(actual.Value, "crosoftMi", "Error in shifting from left to right.");

    }

    /// <summary>
    /// Test shift from left to right precisions same as value length.
    /// </summary>
    [TestMethod]
    public void ShiftFromLeftToRightEdge()
    {
      //Arrange
      StringShift actual = new StringShift("Microsoft");
      int precision = 9;

      //Act
      actual = (actual << precision);

      //Assert
      Assert.AreEqual(actual.Value, "Microsoft", "Error in shifting from left to right.");

    }

    /// <summary>
    /// Test shifting from left to right by 4 and then from right to left by 2.
    /// </summary>
    [TestMethod]
    public void ShiftFromLeftToRightThenFromRightToLeft()
    {
      //Arrange
      StringShift actual = new StringShift("Microsoft");
      int precisionRight = 4;
      int precisionLeft = 2;

      //Act
      actual = (actual << precisionRight);
      actual = (actual >> precisionLeft);

      //Assert
      Assert.AreEqual(actual.Value, "ftMicroso", "Error in shifting.");

    }

    /// <summary>
    /// Test equal overloading for non equal objects
    /// </summary>
    [TestMethod]
    public void EqualTestForNonEqualObject()
    {
      //Arrange
      StringShift first = new StringShift("Microsoft");
      StringShift second = new StringShift("microsoft");

      //Act
      bool isEqual = first == second;

      //Assert
      Assert.AreEqual(isEqual, false, "Error in equal overloading.");

    }

    /// <summary>
    /// Test equal overloading for equal objects
    /// </summary>
    [TestMethod]
    public void EqualTestForEqualObject()
    {
      //Arrange
      StringShift first = new StringShift("Microsoft");
      StringShift second = new StringShift("Microsoft");

      //Act
      bool isEqual = first == second;

      //Assert
      Assert.AreEqual(isEqual, true, "Error in equal overloading.");

    }
  }
}
