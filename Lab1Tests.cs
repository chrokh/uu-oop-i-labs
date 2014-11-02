using NUnit.Framework;
using System;
using System.Linq;

namespace OOP1Labs
{ 
  namespace L1_01_Arithmetic
  {
    [TestFixture]
    public class L1_01_01_Add
    {
      [Test]
      [TestCase(1, 0)]
      [TestCase(0, 1)]
      [TestCase(1, 1)]
      [TestCase(2, 4)]
      [TestCase(105,   200)]
      [TestCase(10480, 20020)]
      public void Add_PositiveNumbers_ReturnsSum(int x, int y)
      {
        Assert.AreEqual((x+y), LabFactory.Lab1().Add(x, y));
      }

      [Test]
      public void Add_Zeroes_ReturnsZero()
      {
        Assert.AreEqual (0, LabFactory.Lab1().Add(0, 0));
      }

      [Test]
      [TestCase(-1, 0)]
      [TestCase(-2, 2)]
      [TestCase(-5, 10)]
      [TestCase(-1040,  2135)]
      [TestCase(-32454, 23)]
      public void Add_NegativeX_ReturnsSum(int x, int y)
      {
        Assert.AreEqual((x+y), LabFactory.Lab1().Add(x, y));
      }

      [Test]
      [TestCase(0,  -1)]
      [TestCase(2,  -2)]
      [TestCase(10, -5)]
      [TestCase(2135, -1040)]
      [TestCase(23,   -32454)]
      public void Add_NegativeY_ReturnsSum(int x, int y)
      {
        Assert.AreEqual((x+y), LabFactory.Lab1().Add(x, y));
      }
    }
    
    [TestFixture]
    public class L1_01_02_Subtract
    {
      [TestCase(1, 0)]
      [TestCase(2, 1)]
      [TestCase(32, 12)] 
      [TestCase(2020, 1000)]
      public void Subtract_GreaterXPositive_ReturnsSum(int x, int y)
      {
        Assert.AreEqual((x-y), LabFactory.Lab1().Subtract(x, y));
      }

      [TestCase(1, 0)]
      [TestCase(2, 1)]
      [TestCase(32, 12)] 
      [TestCase(2020, 1000)]
      public void Subtract_GreaterYPositive_ReturnsSum(int x, int y)
      {
        Assert.AreEqual((x-y), LabFactory.Lab1().Subtract(x, y));
      }

      [TestCase(0, 0)]
      [TestCase(1, 1)]
      [TestCase(-1, -1)]
      [TestCase(152, 152)] 
      [TestCase(-1040, -1040)] 
      public void Subtract_EqualXandY_ReturnsZero(int x, int y)
      {
        Assert.AreEqual((x-y), LabFactory.Lab1().Subtract(x, y));
      }

      [TestCase(-1, 0)]
      [TestCase(-1, 1)]
      [TestCase(-32, 12)] 
      [TestCase(-2020, 1000)]
      public void Subtract_NegativeX_ReturnsSum(int x, int y)
      {
        Assert.AreEqual((x-y), LabFactory.Lab1().Subtract(x, y));
      }

      [TestCase(0, -1)]
      [TestCase(1, -1)]
      [TestCase(42, -14)] 
      [TestCase(4050, -2200)]
      public void Subtract_NegativeY_ReturnsSum(int x, int y)
      {
        Assert.AreEqual((x-y), LabFactory.Lab1().Subtract(x, y));
      }

      [TestCase(-1, -1)]
      [TestCase(-10, -2)]
      [TestCase(-2, -10)]
      [TestCase(-8090, -4050)]
      [TestCase(-4050, -8090)]
      public void Subtract_NegativeXandY_ReturnsSum(int x, int y)
      {
        Assert.AreEqual((x-y), LabFactory.Lab1().Subtract(x, y));
      }
    }

    [TestFixture]
    public class L1_01_03_Multiply
    {
      [Test]
      [TestCase(2,2)]
      [TestCase(2,12)]
      [TestCase(32,46)]
      public void Multiply_PositiveXandY_ReturnsProduct(int x, int y)
      {
        Assert.AreEqual((x*y), LabFactory.Lab1().Multiply(x, y));
      }

      [Test]
      [TestCase(-2,  2)]
      [TestCase( 2,  -2)]
      [TestCase(-4,  14)]
      [TestCase( 4, -14)]
      public void Multiply_NegativeXorY_ReturnsProduct(int x, int y)
      {
        Assert.AreEqual((x*y), LabFactory.Lab1().Multiply(x, y));
      }

      [Test]
      [TestCase(-2,-2)]
      [TestCase(-2,-12)]
      [TestCase(-32,-46)]
      public void Multiply_NegativeXandY_ReturnsProduct(int x, int y)
      {
        Assert.AreEqual((x*y), LabFactory.Lab1().Multiply(x, y));
      }

      [Test]
      [TestCase(   0, 2)]
      [TestCase(   0, 12)]
      [TestCase(   0, -123)]
      [TestCase(-123, 0)]
      [TestCase(  12, 0)]
      [TestCase(   2, 0)]
      public void Multiply_XOrYZero_ReturnsZero(int x, int y)
      {
        Assert.AreEqual((x*y), LabFactory.Lab1().Multiply(x, y));
      }

      [Test]
      [TestCase(   1,2)]
      [TestCase(   1,14)]
      [TestCase(   1,1878)]
      [TestCase(1878, 1)]
      [TestCase(  14, 1)]
      [TestCase(   2, 1)]
      public void Multiply_XOrYOne_ReturnsTheOtherNumber(int x, int y)
      {
        Assert.AreEqual((x*y), LabFactory.Lab1().Multiply(x, y));
      }
    }
  }

  namespace L1_02_Strings
  {
    [TestFixture]
    public class L1_02_01_Hello
    {
      [Test]
      public void Hello_SingleWord()
      {
        Assert.AreEqual("Hello, Superman.", LabFactory.Lab1().Hello("Superman"));
      }

      [Test]
      public void Hello_MultiWord()
      {
        Assert.AreEqual("Hello, Doktor Glas.", LabFactory.Lab1().Hello("Doktor Glas"));
      }

      [Test]
      public void Hello_Empty()
      {
        Assert.AreEqual("Hello, Anonymous.", LabFactory.Lab1().Hello(""));
      }

      [Test]
      public void Hello_Null()
      {
        Assert.AreEqual("Hello, Anonymous.", LabFactory.Lab1().Hello(null));
      }
    }
  }

  namespace L1_03_NumericDataTypes
  {
    [TestFixture]
    public class L1_03_01_DivideIntegers
    {
      [Test]
      [TestCase(1,1)]
      [TestCase(4,2)]
      [TestCase(424,8)]
      public void DivideIntegers_Even(int n, int d)
      {
        Assert.AreEqual((n/d), LabFactory.Lab1().DivideIntegers(n, d));
      }

      [Test]
      [TestCase(1,2)]
      [TestCase(5,3)]
      [TestCase(423,8)]
      public void DivideIntegers_Uneven(int n, int d)
      {
        Assert.AreEqual((n/d), LabFactory.Lab1().DivideIntegers(n, d));
      }

      [Test]
      [TestCase(8,-2)]
      [TestCase(16,-4)]
      public void DivideIntegers_SecondNegative(int n, int d)
      {
        Assert.AreEqual((n/d), LabFactory.Lab1().DivideIntegers(n, d));
      }

      [Test]
      [TestCase(-8,  2)]
      [TestCase(-16, 4)]
      public void DivideIntegers_FirstNegative(int n, int d)
      {
        Assert.AreEqual((n/d), LabFactory.Lab1().DivideIntegers(n, d));
      }

      [Test]
      [TestCase(8,  10)]
      [TestCase(-2, 4)]
      public void DivideIntegers_LargerDenominator(int n, int d)
      {
        Assert.AreEqual(0, LabFactory.Lab1().DivideIntegers(8, 10));
      }
    }

    [TestFixture]
    public class L1_03_02_DivideExact_DoublesToDouble
    {
      [Test]
      [TestCase(4,2)]
      [TestCase(9,3)]
      [TestCase(400.4,200.2)]
      [TestCase(360.8,180.4)]
      public void DivideExact_DoublesToDouble_Even(double n, double d)
      {
        Assert.AreEqual((double)n/(double)d, LabFactory.Lab1().DivideExact(n, d));
      }

      [Test]
      [TestCase(425.4, 8)]
      [TestCase(4.5,   2.4)]
      [TestCase(360.9, 180.4)]
      public void DivideExact_DoublesToDouble_Uneven(double n, double d)
      {
        Assert.AreEqual((double)n/(double)d, LabFactory.Lab1().DivideExact(n, d));
      }

      [Test]
      [TestCase(425.4, -8)]
      [TestCase(4.5,   -2.4)]
      [TestCase(360.9, -180.4)]
      public void DivideExact_DoublesToDouble_SecondNegativeAndUneven(double n, double d)
      {
        Assert.AreEqual((double)n/(double)d, LabFactory.Lab1().DivideExact(n, d));
      }

      [Test]
      [TestCase(-425.4, 8)]
      [TestCase(-4.5,   2.4)]
      [TestCase(-360.9, 180.4)]
      public void DivideExact_DoublesToDouble_FirstNegativeAndUneven(double n, double d)
      {
        Assert.AreEqual((double)n/(double)d, LabFactory.Lab1().DivideExact(n, d));
      }

      [Test]
      [TestCase(2.5,  8)]
      [TestCase(-2.5, 3)]
      [TestCase(150, 38090)]
      public void DivideExact_DoublesToDouble_LargerDenominatorUneven(double n, double d)
      {
        Assert.AreEqual((double)n/(double)d, LabFactory.Lab1().DivideExact(n, d));
      }
    }

    [TestFixture]
    public class L1_03_03_DivideExact_IntsToDouble
    {
      [Test]
      [TestCase(4,2)]
      [TestCase(32,16)]
      [TestCase(360,2)]
      public void DivideExact_IntsToDouble_Even(int n, int d)
      {
        Assert.AreEqual(((double)n/(double)d), LabFactory.Lab1().DivideExact(n, d));
      }

      [Test]
      [TestCase(5,2)]
      [TestCase(9,4)]
      [TestCase(360,7)]
      public void DivideExact_IntsToDouble_Uneven(int n, int d)
      {
        Assert.AreEqual(((double)n/(double)d), LabFactory.Lab1().DivideExact(n, d));
      }

      [Test]
      [TestCase(5,  -2)]
      [TestCase(9,  -4)]
      [TestCase(360,-7)]
      [TestCase( -2, 5)]
      [TestCase( -4, 9)]
      [TestCase( -7,360)]
      public void DivideExact_IntsToDouble_UnevenAndNegativeNorD(int n, int d)
      {
        Assert.AreEqual(((double)n/(double)d), LabFactory.Lab1().DivideExact(n, d));
      }

      [Test]
      [TestCase(1,2)]
      [TestCase(1,3)]
      [TestCase(50,102)]
      public void DivideExact_IntsToDouble_LargerDenominatorUneven(int n, int d)
      {
        Assert.AreEqual(((double)n/(double)d), LabFactory.Lab1().DivideExact(n, d));
      }
    }

    [TestFixture]
    public class L1_03_04_DivideAndTruncate
    {
      [Test]
      [TestCase(4,2)]
      [TestCase(432, 8)]
      public void DivideAndTruncate_Even(double n, double d)
      {
        Assert.AreEqual((int)(n/d), LabFactory.Lab1().DivideAndTruncate(n,d));
      }

      [Test]
      [TestCase(4.5, 2.4)]
      [TestCase(425.4, 8)]
      [TestCase(9.9, 2)]
      public void DivideAndTruncate_Uneven(double n, double d)
      {
        Assert.AreEqual((int)(n/d), LabFactory.Lab1().DivideAndTruncate(n,d));
      }

      [Test]
      [TestCase(9.25, -2.5)]
      [TestCase(9.25, -8.5)]
      public void DivideAndTruncate_SecondNegativeUneven(double n, double d)
      {
        Assert.AreEqual((int)(n/d), LabFactory.Lab1().DivideAndTruncate(n,d));
      }

      [Test]
      [TestCase(-1.5,  2.5)]
      [TestCase(-11.5, 2.5)]
      public void DivideAndTruncate_FirstNegativeUneven(double n, double d)
      {
        Assert.AreEqual((int)(n/d), LabFactory.Lab1().DivideAndTruncate(n,d));
      }

      [Test]
      [TestCase(2.5,  8.0)]
      [TestCase(-3,   12.0)]
      [TestCase(0.25, 0.26)]
      public void DivideAndTruncate_LargerDenominatorUneven(double n, double d)
      {
        Assert.AreEqual((int)(n/d), LabFactory.Lab1().DivideAndTruncate(n,d));
      }
    }

    [TestFixture]
    public class L1_03_05_DivideAndRound
    {
      [Test]
      [TestCase(4,   2)]
      [TestCase(100, 25)]
      [TestCase(9050, 5)]
      public void DivideAndRound_Even_DoesNotRound(double n, double d)
      {
        Assert.AreEqual((n/d), LabFactory.Lab1().DivideAndRound(n, d));
      }

      [Test]
      [TestCase(1,   1.9)]
      [TestCase(4.5, 2.4)]
      [TestCase(-1,  3)]
      public void DivideAndRound_QuotientAbovePointFive_RoundsUp(double n, double d)
      {
        Assert.AreEqual(Math.Ceiling(n/d), LabFactory.Lab1().DivideAndRound(n, d));
      }

      [Test]
      [TestCase(1,     2.5)]
      [TestCase(2.5,   8.0)]
      [TestCase(-1,    1.5)]
      public void DivideAndRound_QuotientBelowPointFive_RoundsDown(double n, double d)
      {
        Assert.AreEqual(Math.Floor(n/d), LabFactory.Lab1().DivideAndRound(n, d));
      }

      [Test]
      [TestCase(25,   10)]
      [TestCase(1086, 12)]
      [TestCase(1,    2)]
      [TestCase(-71, -2)]
      public void DivideAndRound_QuotientAtPointFive_RoundsUp(double n, double d)
      {
        Assert.AreEqual(Math.Ceiling(n/d), LabFactory.Lab1().DivideAndRound(n, d));
      }
    }

    [TestFixture]
    public class L1_04_06_DivideWithRemainder
    {
      [Test]
      public void DivideWithRemainder_Even()
      {
        Assert.AreEqual("4 divided by 2 gives 2, remainder 0.", LabFactory.Lab1().DivideWithRemainder(4, 2));
        Assert.AreEqual("424 divided by 8 gives 53, remainder 0.", LabFactory.Lab1().DivideWithRemainder(424, 8));
      }

      [Test]
      public void DivideWithRemainder_Uneven()
      {
        Assert.AreEqual("5 divided by 2 gives 2, remainder 1.", LabFactory.Lab1().DivideWithRemainder(5, 2));
        Assert.AreEqual("422 divided by 8 gives 52, remainder 6.", LabFactory.Lab1().DivideWithRemainder(422, 8));
      }

      [Test]
      public void DivideWithRemainder_SecondNegativeUneven()
      {
        Assert.AreEqual("9 divided by -2 gives -4, remainder 1.", LabFactory.Lab1().DivideWithRemainder(9, -2));
        Assert.AreEqual("150 divided by -4 gives -37, remainder 2.", LabFactory.Lab1().DivideWithRemainder(150, -4));
      }

      [Test]
      public void DivideWithRemainder_FirstNegativeUneven()
      {
        Assert.AreEqual("-11 divided by 3 gives -3, remainder -2.", LabFactory.Lab1().DivideWithRemainder(-11, 3));
        Assert.AreEqual("-160 divided by 3 gives -53, remainder -1.", LabFactory.Lab1().DivideWithRemainder(-160, 3));
      }

      [Test]
      public void DivideWithRemainder_LargerDenominatorUneven()
      {
        Assert.AreEqual("2 divided by 8 gives 0, remainder 2.", LabFactory.Lab1().DivideWithRemainder(2, 8));
        Assert.AreEqual("200 divided by 750 gives 0, remainder 200.", LabFactory.Lab1().DivideWithRemainder(200, 750));
        Assert.AreEqual("-10 divided by 3 gives -3, remainder -1.", LabFactory.Lab1().DivideWithRemainder(-10, 3));
      }
    }

    [TestFixture]
    public class L1_04_07_DivideWithAbsoluteRemainder
    {
      [Test]
      public void DivideWithAbsoluteRemainder_Even()
      {
        Assert.AreEqual("4 divided by 2 gives 2, remainder 0.", LabFactory.Lab1().DivideWithAbsoluteRemainder(4, 2));
        Assert.AreEqual("424 divided by 8 gives 53, remainder 0.", LabFactory.Lab1().DivideWithAbsoluteRemainder(424, 8));
      }

      [Test]
      public void DivideWithAbsoluteRemainder_Uneven()
      {
        Assert.AreEqual("5 divided by 2 gives 2, remainder 1.", LabFactory.Lab1().DivideWithAbsoluteRemainder(5, 2));
        Assert.AreEqual("434 divided by 8 gives 54, remainder 2.", LabFactory.Lab1().DivideWithAbsoluteRemainder(434, 8));
      }

      [Test]
      public void DivideWithAbsoluteRemainder_Uneven_RequiringAbsolute()
      {
        Assert.AreEqual("8 divided by 3 gives 3, remainder -1.", LabFactory.Lab1().DivideWithAbsoluteRemainder(8, 3));
        Assert.AreEqual("422 divided by 8 gives 53, remainder -2.", LabFactory.Lab1().DivideWithAbsoluteRemainder(422, 8));
      }

      [Test]
      public void DivideWithAbsoluteRemainder_SecondNegativeUneven()
      {
        Assert.AreEqual("9 divided by -2 gives -4, remainder 1.", LabFactory.Lab1().DivideWithAbsoluteRemainder(9, -2));
      }

      [Test]
      public void DivideWithAbsoluteRemainder_EqualDistanceBetweenNegativeAndPositiveRemainder_ReturnsPositive()
      {
        Assert.AreEqual("150 divided by -4 gives -37, remainder 2.", LabFactory.Lab1().DivideWithAbsoluteRemainder(150, -4));
      }

      [Test]
      public void DivideWithAbsoluteRemainder_SecondNegativeUneven_RequiringAbsolute()
      {
        Assert.AreEqual("13 divided by -5 gives -3, remainder -2.", LabFactory.Lab1().DivideWithAbsoluteRemainder(13, -5));
        Assert.AreEqual("151 divided by -4 gives -38, remainder -1.", LabFactory.Lab1().DivideWithAbsoluteRemainder(151, -4));
      }

      [Test]
      public void DivideWithAbsoluteRemainder_FirstNegativeUneven()
      {
        Assert.AreEqual("-10 divided by 3 gives -3, remainder -1.", LabFactory.Lab1().DivideWithAbsoluteRemainder(-10, 3));
        Assert.AreEqual("-160 divided by 3 gives -53, remainder -1.", LabFactory.Lab1().DivideWithAbsoluteRemainder(-160, 3));
      }

      [Test]
      public void DivideWithAbsoluteRemainder_FirstNegativeUneven_RequiringAbsolute()
      {
        Assert.AreEqual("-11 divided by 3 gives -4, remainder 1.", LabFactory.Lab1().DivideWithAbsoluteRemainder(-11, 3));
        Assert.AreEqual("-160 divided by 90 gives -2, remainder 20.", LabFactory.Lab1().DivideWithAbsoluteRemainder(-160, 90));
      }

      [Test]
      public void DivideWithAbsoluteRemainder_LargerDenominatorUneven()
      {
        Assert.AreEqual("2 divided by 8 gives 0, remainder 2.", LabFactory.Lab1().DivideWithAbsoluteRemainder(2, 8));
        Assert.AreEqual("200 divided by 750 gives 0, remainder 200.", LabFactory.Lab1().DivideWithAbsoluteRemainder(200, 750));
        Assert.AreEqual("-10 divided by 3 gives -3, remainder -1.", LabFactory.Lab1().DivideWithAbsoluteRemainder(-10, 3));
      }

      [Test]
      public void DivideWithAbsoluteRemainder_LargerDenominatorUneven_RequiringAbsolute()
      {
        Assert.AreEqual("2 divided by 8 gives 0, remainder 2.", LabFactory.Lab1().DivideWithAbsoluteRemainder(2, 8));
        Assert.AreEqual("200 divided by 750 gives 0, remainder 200.", LabFactory.Lab1().DivideWithAbsoluteRemainder(200, 750));
        Assert.AreEqual("-10 divided by 3 gives -3, remainder -1.", LabFactory.Lab1().DivideWithAbsoluteRemainder(-10, 3));
      }
    }
  }

  namespace L1_04_ComparisonOperators
  {
    [TestFixture]
    public class L1_04_01_Greatest
    {  
      [Test]
      public void Greatest_Left()
      {
        Assert.AreEqual(4, LabFactory.Lab1().Greatest(4, 3));
      }

      [Test]
      public void Greatest_Right()
      {
        Assert.AreEqual(8, LabFactory.Lab1().Greatest(4, 8));
      }

      [Test]
      public void Greatest_Equal()
      {
        Assert.AreEqual(5, LabFactory.Lab1().Greatest(5, 5));
      }

      [Test]
      public void Greatest_NegativeLeft()
      {
        Assert.AreEqual(3, LabFactory.Lab1().Greatest(-4, 3));
      }

      [Test]
      public void Greatest_NegativeRight()
      {
        Assert.AreEqual(4, LabFactory.Lab1().Greatest(4, -3));
      }

      [Test]
      public void Greatest_Negative()
      {
        Assert.AreEqual(-7, LabFactory.Lab1().Greatest(-8, -7));
      }
    }

    [TestFixture]
    public class L1_04_02_GreatestOfThree
    {
      [Test]
      public void Greatest_OfThree_Trivial()
      {
        Assert.AreEqual(1, LabFactory.Lab1().Greatest(1, 0, 0));
        Assert.AreEqual(1, LabFactory.Lab1().Greatest(0, 1, 0));
        Assert.AreEqual(1, LabFactory.Lab1().Greatest(0, 0, 1));
      }

      [Test]
      public void Greatest_OfThree_Low()
      {
        Assert.AreEqual(5, LabFactory.Lab1().Greatest(4, 3, 5));
        Assert.AreEqual(6, LabFactory.Lab1().Greatest(4, 6, 5));
        Assert.AreEqual(7, LabFactory.Lab1().Greatest(7, 3, 5));
      }

      [Test]
      public void Greatest_OfThree_High()
      {
        Assert.AreEqual(1040000, LabFactory.Lab1().Greatest(1040000, 250000, 110000));
        Assert.AreEqual(1040000, LabFactory.Lab1().Greatest(110000, 1040000, 250000));
        Assert.AreEqual(1040000, LabFactory.Lab1().Greatest(110000, 250000, 1040000));
      }

      [Test]
      public void Greatest_OfThree_Equal()
      {
        Assert.AreEqual(7, LabFactory.Lab1().Greatest(6, 7, 7));
        Assert.AreEqual(8, LabFactory.Lab1().Greatest(8, 6, 8));
        Assert.AreEqual(9, LabFactory.Lab1().Greatest(9, 9, 6));
        Assert.AreEqual(102960, LabFactory.Lab1().Greatest(102960, 102960, 102960));
      }

      [Test]
      public void Greatest_OfThree_Negative()
      {
        // Double negatives
        Assert.AreEqual(2, LabFactory.Lab1().Greatest(-2, -2, 2));
        Assert.AreEqual(2, LabFactory.Lab1().Greatest(2, -2, -2));
        Assert.AreEqual(2, LabFactory.Lab1().Greatest(-2, 2, -2));

        // Double negative different numbers
        Assert.AreEqual(3, LabFactory.Lab1().Greatest(-1, -2, 3));
        Assert.AreEqual(1, LabFactory.Lab1().Greatest(1, -2, -3));
        Assert.AreEqual(2, LabFactory.Lab1().Greatest(-1, 2, -3));

        // Single negative
        Assert.AreEqual(3, LabFactory.Lab1().Greatest(-1, 2, 3));
        Assert.AreEqual(3, LabFactory.Lab1().Greatest(3, -2, 1));
        Assert.AreEqual(2, LabFactory.Lab1().Greatest(1, 2, -3));

        // All negative
        Assert.AreEqual(-1, LabFactory.Lab1().Greatest(-1, -2, -3));
        Assert.AreEqual(-43, LabFactory.Lab1().Greatest(-43, -120, -20501));
        Assert.AreEqual(-1, LabFactory.Lab1().Greatest(-1, -1230, -3));
      }
    }

    [TestFixture]
    public class L1_04_03_GreatestOfFour
    {
      [Test]
      public void Greatest_OfFour_Trivial()
      {
        Assert.AreEqual(1, LabFactory.Lab1().Greatest(1, 0, 0, 0));
        Assert.AreEqual(1, LabFactory.Lab1().Greatest(0, 1, 0, 0));
        Assert.AreEqual(1, LabFactory.Lab1().Greatest(0, 0, 1, 0));
        Assert.AreEqual(1, LabFactory.Lab1().Greatest(0, 0, 0, 1));
      }

      [Test]
      public void Greatest_OfFour_Low()
      {
        Assert.AreEqual(10, LabFactory.Lab1().Greatest(10, 3, 4, 2));
        Assert.AreEqual(20, LabFactory.Lab1().Greatest(2, 20, 4, 3));
        Assert.AreEqual(30, LabFactory.Lab1().Greatest(2, 3, 30, 4));
        Assert.AreEqual(40, LabFactory.Lab1().Greatest(2, 3, 4, 40));
      }

      [Test]
      public void Greatest_OfFour_High()
      {
        Assert.AreEqual(1040001, LabFactory.Lab1().Greatest(1040001, 250000, 110000, 9000));
        Assert.AreEqual(1040002, LabFactory.Lab1().Greatest(110000, 1040002, 250000, 9000));
        Assert.AreEqual(1040003, LabFactory.Lab1().Greatest(110000, 250000, 1040003, 9000));
        Assert.AreEqual(1040004, LabFactory.Lab1().Greatest(110000, 250000, 9000, 1040004));
      }

      [Test]
      public void Greatest_OfFour_Equal()
      {
        Assert.AreEqual(6, LabFactory.Lab1().Greatest(5, 6, 6, 6));
        Assert.AreEqual(7, LabFactory.Lab1().Greatest(7, 5, 7, 7));
        Assert.AreEqual(8, LabFactory.Lab1().Greatest(8, 8, 5, 8));
        Assert.AreEqual(9, LabFactory.Lab1().Greatest(9, 9, 9, 5));
        Assert.AreEqual(1020765, LabFactory.Lab1().Greatest(1020765, 1020765, 1020765, 1020765));
      }

      [Test]
      public void Greatest_OfFour_Negative()
      {
        // Three negative
        Assert.AreEqual(2, LabFactory.Lab1().Greatest( 2, -1, -2, -3));
        Assert.AreEqual(3, LabFactory.Lab1().Greatest(-1,  3, -2, -3));
        Assert.AreEqual(4, LabFactory.Lab1().Greatest(-1, -2,  4, -3));
        Assert.AreEqual(5, LabFactory.Lab1().Greatest(-1, -2, -3,  5));

        // Two negative
        Assert.AreEqual(1, LabFactory.Lab1().Greatest(1,  1, -1, -1));
        Assert.AreEqual(1, LabFactory.Lab1().Greatest(1, -1,  1, -1));
        Assert.AreEqual(1, LabFactory.Lab1().Greatest(1, -1, -1,  1));
        Assert.AreEqual(1, LabFactory.Lab1().Greatest(-1, 1,  1, -1));
        Assert.AreEqual(1, LabFactory.Lab1().Greatest(-1, 1, -1,  1));
        Assert.AreEqual(1, LabFactory.Lab1().Greatest(-1, -1, 1,  1));

        // One negative
        Assert.AreEqual(4, LabFactory.Lab1().Greatest(-5, 4,  4,  4));
        Assert.AreEqual(4, LabFactory.Lab1().Greatest(4, -5,  4,  4));
        Assert.AreEqual(4, LabFactory.Lab1().Greatest(4,  4, -5,  4));
        Assert.AreEqual(4, LabFactory.Lab1().Greatest(4,  4,  4, -5));
      }
    }

    [TestFixture]
    public class L1_04_04_IsGreater
    {
      [Test]
      public void IsGreater_LeftGreatest_IsTrue()
      {
        Assert.IsTrue(LabFactory.Lab1().IsGreater(2, 1));
        Assert.IsTrue(LabFactory.Lab1().IsGreater(18000, 600));
        Assert.IsTrue(LabFactory.Lab1().IsGreater(909090, 909089));
        Assert.IsTrue(LabFactory.Lab1().IsGreater(0, -1));
        Assert.IsTrue(LabFactory.Lab1().IsGreater(-20, -50));
      }

      [Test]
      public void IsGreater_RightGreatest_IsFalse()
      {
        Assert.IsFalse(LabFactory.Lab1().IsGreater(1, 2));
        Assert.IsFalse(LabFactory.Lab1().IsGreater(500, 900));
        Assert.IsFalse(LabFactory.Lab1().IsGreater(707070, 707071));
        Assert.IsFalse(LabFactory.Lab1().IsGreater(-1, 0));
        Assert.IsFalse(LabFactory.Lab1().IsGreater(-140, -40));
      }

      [Test]
      public void IsGreater_Equal_IsFalse()
      {
        Assert.IsFalse(LabFactory.Lab1().IsGreater(0, 0));
        Assert.IsFalse(LabFactory.Lab1().IsGreater(1, 1));
        Assert.IsFalse(LabFactory.Lab1().IsGreater(808080, 808080));
        Assert.IsFalse(LabFactory.Lab1().IsGreater(-1507, -1507));
      }
    }
  }

  namespace L1_05_Booleans
  {
    [TestFixture]
    public class L1_05_01_And
    {
      [Test]
      public void And_TrueWhenTrueTrue()
      {
        Assert.IsTrue(LabFactory.Lab1().And(true, true));
      }

      [Test]
      public void And_FalseWhenTrueFalse()
      {
        Assert.IsFalse(LabFactory.Lab1().And(true, false));
      }

      [Test]
      public void And_FalseWhenFalseTrue()
      {
        Assert.IsFalse(LabFactory.Lab1().And(false, true));
      }

      [Test]
      public void And_FalseWhenFalseFalse()
      {
        Assert.IsFalse(LabFactory.Lab1().And(false, false));
      }
    }

    [TestFixture]
    public class L1_05_02_Or
    {
      [Test]
      public void Or_TrueWhenTrueTrue()
      {
        Assert.IsTrue(LabFactory.Lab1().Or(true, true));
      }

      [Test]
      public void Or_TrueWhenTrueFalse()
      {
        Assert.IsTrue(LabFactory.Lab1().Or(true, false));
      }

      [Test]
      public void Or_TrueWhenFalseTrue()
      {
        Assert.IsTrue(LabFactory.Lab1().Or(false, true));
      }

      [Test]
      public void Or_FalseWhenFalseFalse()
      {
        Assert.IsFalse(LabFactory.Lab1().Or(false, false));
      }
    }

    [TestFixture]
    public class L1_05_03_Xor
    {
      [Test]
      public void Xor_FalseWhenTrueTrue()
      {
        Assert.IsFalse(LabFactory.Lab1().Xor(true, true));
      }

      [Test]
      public void Xor_TrueWhenTrueFalse()
      {
        Assert.IsTrue(LabFactory.Lab1().Xor(true, false));
      }

      [Test]
      public void Xor_TrueWhenFalseTrue()
      {
        Assert.IsTrue(LabFactory.Lab1().Xor(false, true));
      }

      [Test]
      public void Xor_FalseWhenFalseFalse()
      {
        Assert.IsFalse(LabFactory.Lab1().Xor(false, false));
      }
    }

    [TestFixture]
    public class L1_05_04_Not
    {
      [Test]
      public void Not_TrueWhenFalse()
      {
        Assert.IsTrue(LabFactory.Lab1().Not(false));
      }

      [Test]
      public void Not_FalseWhenTrue()
      {
        Assert.IsFalse(LabFactory.Lab1().Not(true));
      }
    }
  }

  namespace L1_06_TypeConversions
  {
    [TestFixture]
    public class L1_06_01_IntToString
    {
      [Test]
      public void IntToString_ConvertsNumbersToStrings()
      {
        Assert.AreEqual("150430", LabFactory.Lab1().IntToString(150430));
        Assert.AreEqual("32", LabFactory.Lab1().IntToString(32));
      }

      [Test]
      public void IntToString_AllowsZeroToBeConverted()
      {
        Assert.AreEqual("0", LabFactory.Lab1().IntToString(0));
      }

      [Test]
      public void IntToString_PrependsDashToNegativeNumbers()
      {
        Assert.AreEqual("-12", LabFactory.Lab1().IntToString(-12));
        Assert.AreEqual("-4045", LabFactory.Lab1().IntToString(-4045));
      }
    }

    [TestFixture]
    public class L1_06_02_StringToInt
    {
      [Test]
      public void StringToInt_ConvertsStringOfAllNumbersToStrings()
      {
        Assert.AreEqual(3, LabFactory.Lab1().StringToInt("3"));
        Assert.AreEqual(100, LabFactory.Lab1().StringToInt("100"));
        Assert.AreEqual(10430, LabFactory.Lab1().StringToInt("10430"));
      }

      [Test]
      public void StringToInt_RemovesTrailingZeroes()
      {
        Assert.AreEqual(10, LabFactory.Lab1().StringToInt("010"));
        Assert.AreEqual(100000, LabFactory.Lab1().StringToInt("0000000000100000"));
        Assert.AreEqual(100400, LabFactory.Lab1().StringToInt("000100400"));
      }

      [Test]
      public void StringToInt_DashAsFirstCharacterCreatesNegativeNumbers()
      {
        Assert.AreEqual(-4, LabFactory.Lab1().StringToInt("-4"));
        Assert.AreEqual(-104, LabFactory.Lab1().StringToInt("-104"));
      }

      [Test]
      [ExpectedException]
      public void StringToInt_ThrowsExceptionOnNonNumbers()
      {
        LabFactory.Lab1().StringToInt("123hello");
        LabFactory.Lab1().StringToInt("a43");
        LabFactory.Lab1().StringToInt("123-45");
        LabFactory.Lab1().StringToInt("#123");
      }

      [Test]
      [ExpectedException]
      public void StringToInt_ThrowsExceptionOnEmptyOrNull()
      {
        LabFactory.Lab1().StringToInt("");
        LabFactory.Lab1().StringToInt(null);
      }
    }
  }

  namespace L1_07_Exercises
  {
    [TestFixture]
    public class L1_07_01_CanJoyride
    {
      [Test]
      public void CanJoyride_TrueWhenOldAndTallEnoughAndNoHeartCondition()
      {
        Assert.IsTrue(LabFactory.Lab1().CanJoyride(12, 150, false));
        Assert.IsTrue(LabFactory.Lab1().CanJoyride(80, 210, false));
        Assert.IsTrue(LabFactory.Lab1().CanJoyride(30, 170, false));
      }

      [Test]
      public void CanJoyride_TrueWhenAdultButNotTallEnoughButAboveLowestHeightLimitAndNoHeartCondition()
      {
        Assert.IsTrue(LabFactory.Lab1().CanJoyride(18, 149, false));
        Assert.IsTrue(LabFactory.Lab1().CanJoyride(25, 130, false));
      }

      [Test]
      public void CanJoyride_FalseWhenNotTallEnough()
      {
        Assert.IsFalse(LabFactory.Lab1().CanJoyride(7, 149, false));
        Assert.IsFalse(LabFactory.Lab1().CanJoyride(11, 130, false));
        Assert.IsFalse(LabFactory.Lab1().CanJoyride(8, 80, true));
      }

      [Test]
      public void CanJoyride_FalseWhenTooTall()
      {
        Assert.IsFalse(LabFactory.Lab1().CanJoyride(18, 211, false));
        Assert.IsFalse(LabFactory.Lab1().CanJoyride(32, 220, true));
        Assert.IsFalse(LabFactory.Lab1().CanJoyride(72, 240, false));
      }

      [Test]
      public void CanJoyride_FalseWhenEvenBelowLowesetHeightLimitForAdults()
      {
        Assert.IsFalse(LabFactory.Lab1().CanJoyride(18, 129, false));
        Assert.IsFalse(LabFactory.Lab1().CanJoyride(25, 100, true));
      }

      [Test]
      public void CanJoyride_FalseWhenHeartCondition()
      {
        Assert.IsFalse(LabFactory.Lab1().CanJoyride(18, 128, true));
        Assert.IsFalse(LabFactory.Lab1().CanJoyride(18, 148, true));
        Assert.IsFalse(LabFactory.Lab1().CanJoyride(18, 180, true));
        Assert.IsFalse(LabFactory.Lab1().CanJoyride(18, 180, true));
        Assert.IsFalse(LabFactory.Lab1().CanJoyride(25, 100, true));
      }
    }

    [TestFixture]
    public class L1_07_02_DateDistance
    {
      [Test]
      public void DateDistance_LeftAllGreater_ReturnsAbsoluteDifference()
      {
        Assert.AreEqual("1 year(s), 1 month(s), and 1 day(s).", LabFactory.Lab1().DateDistance(2, 2, 2, 1, 1, 1));
        Assert.AreEqual("2 year(s), 10 month(s), and 5 day(s).", LabFactory.Lab1().DateDistance(2030, 20, 20, 2028, 10, 15));
      }

      [Test]
      public void DateDistance_RightAllGreater_ReturnsAbsoluteDifference()
      {
        Assert.AreEqual("1 year(s), 1 month(s), and 1 day(s).", LabFactory.Lab1().DateDistance(0, 0, 0, 1, 1, 1));
        Assert.AreEqual("2645 year(s), 4 month(s), and 7 day(s).", LabFactory.Lab1().DateDistance(400, 4, 0, 3045, 8, 7));
      }

      [Test]
      public void DateDistance_Equal_ReturnsAbsoluteDifference()
      {
        Assert.AreEqual("0 year(s), 0 month(s), and 0 day(s).", LabFactory.Lab1().DateDistance(1, 1, 1, 1, 1, 1));
        Assert.AreEqual("0 year(s), 0 month(s), and 0 day(s).", LabFactory.Lab1().DateDistance(540, 3, 13, 540, 3, 13));
      }

      [Test]
      public void DateDistance_Mixed_ReturnsAbsoluteDistance()
      {
        Assert.AreEqual("1 year(s), 1 month(s), and 0 day(s).", LabFactory.Lab1().DateDistance(1, 0, 0, 0, 1, 0));
        Assert.AreEqual("1 year(s), 1 month(s), and 0 day(s).", LabFactory.Lab1().DateDistance(0, 1, 0, 1, 0, 0));
        Assert.AreEqual("1 year(s), 0 month(s), and 1 day(s).", LabFactory.Lab1().DateDistance(0, 0, 1, 1, 0, 0));
        Assert.AreEqual("3030 year(s), 7 month(s), and 4 day(s).", LabFactory.Lab1().DateDistance(4030, 5, 20, 1000, 12, 16));
      }
    }

    [TestFixture]
    public class L1_07_03_IsLeapYear
    {
      [Test]
      public void IsLeapYear_FalseIfNotDivisibleBy4()
      {
        Assert.IsFalse(LabFactory.Lab1().IsLeapYear(750));
        Assert.IsFalse(LabFactory.Lab1().IsLeapYear(93));
        Assert.IsFalse(LabFactory.Lab1().IsLeapYear(14523));
      }

      [Test]
      public void IsLeapYear_TrueIfDivisibleBy4ButNotDivisibleBy100()
      {
        Assert.IsTrue(LabFactory.Lab1().IsLeapYear(80));
        Assert.IsTrue(LabFactory.Lab1().IsLeapYear(1220));
      }

      [Test]
      public void IsLeapYear_FalseIfDivisibleBy4AndDivisibleBy100AndNotDivisibleBy400()
      {
        Assert.IsFalse(LabFactory.Lab1().IsLeapYear(1300));
        Assert.IsFalse(LabFactory.Lab1().IsLeapYear(80200));
      }

      [Test]
      public void IsLeapYear_TrueIfDivisibleBy4AndDivisibleBy100AndDivisibleBy400()
      {
        Assert.IsTrue(LabFactory.Lab1().IsLeapYear(400));
        Assert.IsTrue(LabFactory.Lab1().IsLeapYear(4800));
        Assert.IsTrue(LabFactory.Lab1().IsLeapYear(52400));
      }
    }
  }

  namespace L1_08_Selection
  {
    [TestFixture]
    public class L1_08_01_RequestPony
    {
      [Test]
      [TestCase(11, 66)]
      [TestCase(8,  65)]
      [TestCase(5,  50)]
      [TestCase(2,  30)]
      [TestCase(0,  29)]
      public void RequestPony_TooYoung_IsDenied(int age, int weight)
      {
        Assert.AreEqual("Too young to compete.", LabFactory.Lab1().RequestPony(age, weight));
      }

      [Test]
      [TestCase(12, 20)]
      [TestCase(22, 21)]
      [TestCase(34, 23)]
      [TestCase(42, 24)]
      [TestCase(56, 29)]
      [TestCase(72, 30)]
      public void RequestPony_WeightUnder31_GetsAPony(int age, int weight)
      {
        Assert.AreEqual("Class A pony", LabFactory.Lab1().RequestPony(age, weight));
      }

      [Test]
      [TestCase(12, 31)]
      [TestCase(22, 32)]
      [TestCase(34, 45)]
      [TestCase(56, 49)]
      [TestCase(72, 50)]
      public void RequestPony_WeightUnder51_GetsBPony(int age, int weight)
      {
        Assert.AreEqual("Class B pony", LabFactory.Lab1().RequestPony(age, weight));
      }

      [Test]
      [TestCase(12, 51)]
      [TestCase(22, 52)]
      [TestCase(34, 59)]
      [TestCase(56, 64)]
      [TestCase(72, 65)]
      public void RequestPony_WeightUnder66_GetsBPony(int age, int weight)
      {
        Assert.AreEqual("Class C pony", LabFactory.Lab1().RequestPony(age, weight));
      }

      [Test]
      [TestCase(12, 66)]
      [TestCase(22, 67)]
      [TestCase(34, 78)]
      [TestCase(56, 104)]
      [TestCase(72, 18070)]
      public void RequestPony_WeightOver65_GetsBPony(int age, int weight)
      {
        Assert.AreEqual("No ponies available for the given weight class.", LabFactory.Lab1().RequestPony(age, weight));
      }
    }

    [TestFixture]
    public class L1_08_02_WhatIsForLunch
    {
      [Test]
      public void WhatIsForLunch_IncorrectInput_ReturnsErrorString()
      {
        Assert.AreEqual("Incorrect input", LabFactory.Lab1().WhatIsForLunch(null));
        Assert.AreEqual("Incorrect input", LabFactory.Lab1().WhatIsForLunch(""));
        Assert.AreEqual("Incorrect input", LabFactory.Lab1().WhatIsForLunch("0"));
        Assert.AreEqual("Incorrect input", LabFactory.Lab1().WhatIsForLunch("8"));
        Assert.AreEqual("Incorrect input", LabFactory.Lab1().WhatIsForLunch("asd"));
        Assert.AreEqual("Incorrect input", LabFactory.Lab1().WhatIsForLunch("asdh KJFDGGDHJKASDFGKJHDS sdga fgs"));
        Assert.AreEqual("Incorrect input", LabFactory.Lab1().WhatIsForLunch("&(%(&€askghd"));
      }

      [Test]
      [TestCase("MONDAY")]
      [TestCase("Monday")]
      [TestCase("monday")]
      [TestCase("mon")]
      [TestCase("1")]
      public void WhatIsForLunch_Weekday1_ReturnsRatatouilleMenu(string weekday)
      {
        Assert.AreEqual("Ratatouille", LabFactory.Lab1().WhatIsForLunch(weekday));
      }

      [Test]
      [TestCase("TUESDAY")]
      [TestCase("Tuesday")]
      [TestCase("tuesday")]
      [TestCase("tue")]
      [TestCase("2")]
      public void WhatIsForLunch_Weekday2_ReturnsPancakesMenu(string weekday)
      {
        Assert.AreEqual("Pancakes and pea soup", LabFactory.Lab1().WhatIsForLunch(weekday));
      }

      [Test]
      [TestCase("WEDNESDAY")]
      [TestCase("Wednesday")]
      [TestCase("wednesday")]
      [TestCase("wed")]
      [TestCase("3")]
      public void WhatIsForLunch_Weekday3_ReturnsStewMenu(string weekday)
      {
        Assert.AreEqual("Winter vegetable stew", LabFactory.Lab1().WhatIsForLunch(weekday));
      }

      [Test]
      [TestCase("THURSDAY")]
      [TestCase("Thursday")]
      [TestCase("thursday")]
      [TestCase("thu")]
      [TestCase("4")]
      public void WhatIsForLunch_Weekday4_ReturnsPastaMenu(string weekday)
      {
        Assert.AreEqual("Spinach and garlic pasta", LabFactory.Lab1().WhatIsForLunch(weekday));
      }

      [Test]
      [TestCase("FRIDAY")]
      [TestCase("Friday")]
      [TestCase("friday")]
      [TestCase("fri")]
      [TestCase("5")]
      public void WhatIsForLunch_Weekday5_ReturnsSlidersMenu(string weekday)
      {
        Assert.AreEqual("Sliders", LabFactory.Lab1().WhatIsForLunch(weekday));
      }

      [Test]
      [TestCase("SATURDAY")]
      [TestCase("Saturday")]
      [TestCase("saturday")]
      [TestCase("sat")]
      [TestCase("6")]
      public void WhatIsForLunch_Weekday6_ReturnsQuesadillasMenu(string weekday)
      {
        Assert.AreEqual("Black bean quesadillas", LabFactory.Lab1().WhatIsForLunch(weekday));
      }

      [Test]
      [TestCase("SUNDAY")]
      [TestCase("Sunday")]
      [TestCase("sunday")]
      [TestCase("sun")]
      [TestCase("7")]
      public void WhatIsForLunch_Weekday7_ReturnsSlidersMenu(string weekday)
      {
        Assert.AreEqual("Raw food salad", LabFactory.Lab1().WhatIsForLunch(weekday));
      }
    }

    [TestFixture]
    public class L1_08_03_IsTheBathReady
    {
      [Test]
      [TestCase("YES", 37)]
      [TestCase("Yes", 37)]
      [TestCase("yes", 37)]
      [TestCase("Y", 37)]
      [TestCase("y", 37)]
      public void IsTheBathReady_HasGoodTemperaturedWater_ReturnsTrue(string hasWater, int degrees)
      {
        Assert.IsTrue(LabFactory.Lab1().IsTheBathReady(hasWater, degrees));
      }

      [Test]
      [TestCase("NO", 37)]
      [TestCase("No", 37)]
      [TestCase("no", 37)]
      [TestCase("N", 37)]
      [TestCase("n", 37)]
      public void IsTheBathReady_NoWater_ReturnsFalse(string hasWater, int degrees)
      {
        Assert.IsFalse(LabFactory.Lab1().IsTheBathReady(hasWater, degrees));
      }

      [Test]
      [TestCase("Y", 29)]
      [TestCase("Y", 28)]
      [TestCase("Y", 13)]
      [TestCase("Y", 0)]
      [TestCase("Y", -4)]
      public void IsTheBathReady_HasLowTemperaturedWater_ReturnsFalse(string hasWater, int degrees)
      {
        Assert.IsFalse(LabFactory.Lab1().IsTheBathReady(hasWater, degrees));
      }

      [Test]
      [TestCase("Y", 49)]
      [TestCase("Y", 50)]
      [TestCase("Y", 62)]
      [TestCase("Y", 74)]
      [TestCase("Y", 1330)]
      public void IsTheBathReady_HasHighTemperaturedWater_ReturnsFalse(string hasWater, int degrees)
      {
        Assert.IsFalse(LabFactory.Lab1().IsTheBathReady(hasWater, degrees));
      }
    }
  }

  namespace L1_09_Iteration
  {
    [TestFixture]
    public class L1_09_01_RepeatString
    { 
      [Test]
      [TestCase("", 0)]
      [TestCase("", 1)]
      [TestCase("", 4000)]
      [TestCase("", -12)]
      public void RepeatString_NoStringSomeOrNoTimes_ReturnsNoString(string text, int times){
        Assert.AreEqual("", LabFactory.Lab1().RepeatString(text, times));
      }

      [Test]
      [TestCase("Only once please ", 1)]
      [TestCase("someone telling someone about ", 3)]
      [TestCase("a", 50)]
      public void RepeatString_SomeStringSomeTimes_ReturnsSameStringRepeated(string text, int times){
        string expected = String.Join("", Enumerable.Repeat(text, times));
        string actual = LabFactory.Lab1().RepeatString(text, times);
        Assert.AreEqual(expected, actual);
      }

      [Test]
      [TestCase("foo", 0)]
      [TestCase("foo", -1)]
      [TestCase("baz", -152)]
      public void RepeatString_SomeStringNoOrNegativeTimes_ReturnsNoString(string text, int times){
        Assert.AreEqual("", LabFactory.Lab1().RepeatString(text, times));
      }
    }

    [TestFixture]
    public class L1_09_02_MultiplicationTableSum
    {
      [Test]
      [TestCase(0,0,0)]
      [TestCase(1,0,0)]
      [TestCase(-1,1,1)]
      [TestCase(0,12,12)]
      [TestCase(0,-3,-3)]
      [TestCase(0,15,15)]
      [TestCase(0,4507,4507)]
      public void MultiplicationTableSum_ZeroSteps_ReturnsJustZero(int factor, int start, int end)
      {
        Assert.AreEqual("0", LabFactory.Lab1().MultiplicationTableSum(factor, start, end));
      }

      [Test]
      [TestCase(2,3,6)]
      public void MultiplicationTableSum_SecondTableFourSteps_CalculatesTo36(int factor, int start, int end)
      {
        string expected = "(2*3)+(2*4)+(2*5)+(2*6) = 6+8+10+12 = 36";
        string actual   = LabFactory.Lab1().MultiplicationTableSum(factor, start, end);
        Assert.AreEqual(expected, actual);
      }

      [Test]
      [TestCase(1,0,1)]
      public void MultiplicationTableSum_Trivial_CalculatesTo1(int factor, int start, int end)
      {
        string actual = LabFactory.Lab1().MultiplicationTableSum(1, 0, 1);
        Assert.AreEqual("(1*0)+(1*1) = 0+1 = 1", actual);
      }

      [Test]
      [TestCase(3,-2,2)]
      public void MultiplicationTableSum_AroundZero_CalculatesFromBelowZeroToAbove(int factor, int start, int end)
      {
        string actual = LabFactory.Lab1().MultiplicationTableSum(factor, start, end);
        Assert.AreEqual("(3*-2)+(3*-1)+(3*0)+(3*1)+(3*2) = -6+-3+0+3+6 = 0", actual);
      }

      [Test]
      [TestCase(5,-4,-2)]
      public void MultiplicationTableSum_Negative_CalculatesNegativeSum(int factor, int start, int end)
      {
        string actual = LabFactory.Lab1().MultiplicationTableSum(factor, start, end);
        Assert.AreEqual("(5*-4)+(5*-3)+(5*-2) = -20+-15+-10 = -45", actual);
      }
    }
  }

  public class LabFactory
  {
    public static Lab1 Lab1()
    {
      return new Lab1();
    }
  }
}

