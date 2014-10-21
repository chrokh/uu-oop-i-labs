using NUnit.Framework;
using System;

namespace OOP1Labs
{
	[TestFixture]
	public class L101_Add : Lab1TestBase
	{
		[Test]
		public void Add_LowNumbers()
		{
			Assert.AreEqual(3, lab.Add(1, 2));
		}

		[Test]
		public void Add_HighNumbers()
		{
			Assert.AreEqual(30500, lab.Add(10480, 20020));
		}

		[Test]
		public void Add_OneZero()
		{
			Assert.AreEqual (1, lab.Add(1, 0));
		}

		[Test]
		public void Add_NegativeNumbers()
		{
			Assert.AreEqual(-2, lab.Add(2, -4));
		}
	}

	[TestFixture]
	public class L102_Subtract : Lab1TestBase
	{
		[Test]
		public void Subtract_LowNumbers()
		{
			Assert.AreEqual(3, lab.Subtract(5, 2));
		}

		[Test]
		public void Subtract_HighNumbers()
		{
			Assert.AreEqual(99018, lab.Subtract(104050, 5032));
		}

		[Test]
		public void Subtract_Zero()
		{
			Assert.AreEqual(0, lab.Subtract(3, 3));
		}

		[Test]
		public void Subtract_SecondNegative()
		{
			Assert.AreEqual(5, lab.Subtract(2, -3));
		}

		[Test]
		public void Subtract_FirstNegative()
		{
			Assert.AreEqual(-5, lab.Subtract(-2, 3));
		}

		[Test]
		public void Subtract_BothNegative()
		{
			Assert.AreEqual(1, lab.Subtract(-2, -3));
		}
	}

	[TestFixture]
	public class L103_Multiply : Lab1TestBase
	{
		[Test]
		public void Multiply_LowNumbers()
		{
			Assert.AreEqual(6, lab.Subtract(2, 3));
		}

		[Test]
		public void Multiply_HighNumbers()
		{
			Assert.AreEqual(109082, lab.Subtract(104050, 5032));
		}

		[Test]
		public void Multiply_Zero()
		{
			Assert.AreEqual(0, lab.Subtract(3, 0));
		}

		[Test]
		public void Multiply_SecondNegative()
		{
			Assert.AreEqual(-6, lab.Subtract(2, -3));
		}

		[Test]
		public void Multiply_FirstNegative()
		{
			Assert.AreEqual(-6, lab.Subtract(-2, 3));
		}

		[Test]
		public void Multiply_BothNegative()
		{
			Assert.AreEqual(6, lab.Subtract(-2, -3));
		}
	}

	[TestFixture]
	public class L104_Hello : Lab1TestBase
	{
		[Test]
		public void Hello_SingleWord()
		{
			Assert.AreEqual("Hello, Superman.", lab.Hello("Superman"));
		}

		[Test]
		public void Hello_MultiWord()
		{
			Assert.AreEqual("Hello, Doktor Glas.", lab.Hello("Doktor Glas"));
		}

		[Test]
		public void Hello_Empty()
		{
			Assert.AreEqual("Hello, Anonymous.", lab.Hello(""));
		}

		[Test]
		public void Hello_Null()
		{
			Assert.AreEqual("Hello, Anonymous.", lab.Hello(null));
		}
	}

	[TestFixture]
	public class L105_DivideIntegers : Lab1TestBase
	{
		[Test]
		public void DivideIntegers_LowEven()
		{
			Assert.AreEqual(2, lab.DivideIntegers(4, 2));
		}

		[Test]
		public void DivideIntegers_LowUneven()
		{
			Assert.AreEqual(2, lab.DivideIntegers(5, 2));
		}

		[Test]
		public void DivideIntegers_HighEven()
		{
			Assert.AreEqual(53, lab.DivideIntegers(424, 8));
		}

		[Test]
		public void DivideIntegers_HighUneven()
		{
			Assert.AreEqual(52, lab.DivideIntegers(423, 8));
		}

		[Test]
		public void DivideIntegers_SecondNegative()
		{
			Assert.AreEqual(-4, lab.DivideIntegers(8, -2));
		}

		[Test]
		public void DivideIntegers_FirstNegative()
		{
			Assert.AreEqual(-5, lab.DivideIntegers(-10, 2));
		}

		[Test]
		public void DivideIntegers_LargerDenominator()
		{
			Assert.AreEqual(0, lab.DivideIntegers(8, 10));
		}

		[Test]
		[ExpectedException(typeof(DivideByZeroException))]
		public void DivideIntegers_DivideByZero()
		{
			lab.DivideIntegers(2, 0);
		}
	}

	[TestFixture]
	public class L106_IntsToDouble : Lab1TestBase
	{
		[Test]
		public void Divide_IntsToDouble_LowEven()
		{
			Assert.AreEqual(2.0, lab.DivideExact(4, 2));
		}

		[Test]
		public void Divide_IntsToDouble_LowUneven()
		{
			Assert.AreEqual(2.5, lab.DivideExact(5, 2));
		}

		[Test]
		public void Divide_IntsToDouble_HighEven()
		{
			Assert.AreEqual(53, lab.DivideExact(422, 8));
		}

		[Test]
		public void Divide_IntsToDouble_HighUneven()
		{
			Assert.AreEqual(52.875, lab.DivideExact(423, 8));
		}

		[Test]
		public void Divide_IntsToDouble_SecondNegativeUneven()
		{
			Assert.AreEqual(-4.5, lab.DivideExact(9, -2));
		}

		[Test]
		public void Divide_IntsToDouble_FirstNegativeUneven()
		{
			Assert.AreEqual(-5.5, lab.DivideExact(-11, 2));
		}

		[Test]
		public void Divide_IntsToDouble_LargerDenominatorUneven()
		{
			Assert.AreEqual(0.8, lab.DivideExact(8, 10));
		}

		[Test]
		[ExpectedException(typeof(DivideByZeroException))]
		public void Divide_DivideByZero()
		{
			lab.DivideExact(2, 0);
		}
	}

	[TestFixture]
	public class L107_DivideDoublesToDouble : Lab1TestBase
	{
		[Test]
		public void Divide_DoublesToDouble_LowEven()
		{
			Assert.AreEqual(2.0, lab.DivideExact(4.0, 2.0));
		}

		[Test]
		public void Divide_DoublesToDouble_LowUneven()
		{
			Assert.AreEqual(1.875, lab.DivideExact(4.5, 2.4));
		}

		[Test]
		public void Divide_DoublesToDouble_HighEven()
		{
			Assert.AreEqual(53, lab.DivideExact(422.0, 8.0));
		}

		[Test]
		public void Divide_DoublesToDouble_HighUneven()
		{
			Assert.AreEqual(53.175, lab.DivideExact(425.4, 8.0));
		}

		[Test]
		public void Divide_DoublesToDouble_SecondNegativeUneven()
		{
			Assert.AreEqual(-3.7, lab.DivideExact(9.25, -2.5));
		}

		[Test]
		public void Divide_DoublesToDouble_FirstNegativeUneven()
		{
			Assert.AreEqual(-4.6, lab.DivideExact(-11.5, 2.5));
		}

		[Test]
		public void Divide_DoublesToDouble_LargerDenominatorUneven()
		{
			Assert.AreEqual(0.3125, lab.DivideExact(2.5, 8.0));
		}

		[Test]
		[ExpectedException(typeof(DivideByZeroException))]
		public void Divide_DoublesToDouble_DivideByZero()
		{
			lab.DivideExact(2, 0);
		}
	}

	[TestFixture]
	public class L108_DivideAndTruncate : Lab1TestBase
	{
		[Test]
		public void DivideAndTruncate_LowEven()
		{
			Assert.AreEqual(2, lab.DivideExact(4.0, 2.0));
		}

		[Test]
		public void DivideAndTruncate_LowUneven()
		{
			Assert.AreEqual(1, lab.DivideExact(4.5, 2.4));
		}

		[Test]
		public void DivideAndTruncate_HighEven()
		{
			Assert.AreEqual(53, lab.DivideExact(422.0, 8.0));
		}

		[Test]
		public void DivideAndTruncate_HighUneven()
		{
			Assert.AreEqual(53, lab.DivideExact(425.4, 8.0));
		}

		[Test]
		public void DivideAndTruncate_SecondNegativeUneven()
		{
			Assert.AreEqual(-3, lab.DivideExact(9.25, -2.5));
		}

		[Test]
		public void DivideAndTruncate_FirstNegativeUneven()
		{
			Assert.AreEqual(-4, lab.DivideExact(-11.5, 2.5));
		}

		[Test]
		public void DivideAndTruncate_LargerDenominatorUneven()
		{
			Assert.AreEqual(0, lab.DivideExact(2.5, 8.0));
		}

		[Test]
		[ExpectedException(typeof(DivideByZeroException))]
		public void DivideAndTruncate_DivideByZero()
		{
			lab.DivideAndTruncate(2, 0);
		}
	}

	[TestFixture]
	public class L109_DivideAndRound : Lab1TestBase
	{
		[Test]
		public void DivideAndRound_Even_DoesNotRound()
		{
			Assert.AreEqual(2, lab.DivideAndRound(4, 2));
			Assert.AreEqual(4, lab.DivideAndRound(100, 25));
			Assert.AreEqual(1810, lab.DivideAndRound(9050, 5));
		}

		[Test]
		public void DivideAndRound_QuotientAbovePointFive_RoundsUp()
		{
			Assert.AreEqual(2, lab.DivideAndRound(4.5, 2.4));
			Assert.AreEqual(53, lab.DivideAndRound(422.0, 8.0));
			Assert.AreEqual(-3, lab.DivideAndRound(9.25, -2.5));
		}

		[Test]
		public void DivideAndRound_QuotientBelowPointFive_RoundsDown()
		{
			Assert.AreEqual(53, lab.DivideAndRound(425.4, 8.0));
			Assert.AreEqual(-4, lab.DivideAndRound(-11.5, 2.5));
			Assert.AreEqual(0, lab.DivideAndRound(2.5, 8.0));
		}

		[Test]
		public void DivideAndRound_QuotientAtPointFive_RoundsUp()
		{
			Assert.AreEqual(3, lab.DivideAndRound(25, 10));
			Assert.AreEqual(91, lab.DivideAndRound(1086, 12));
			Assert.AreEqual(1, lab.DivideAndRound(1, 2));
			Assert.AreEqual(36, lab.DivideAndRound(-71, -2));
		}
	}

	[TestFixture]
	public class L110_DivideWithRemainder : Lab1TestBase{
		[Test]
		public void DivideWithRemainder_LowEven()
		{
			Assert.AreEqual("4 divided by 2 gives 2, remainder 0.", lab.DivideWithRemainder(4, 2));
		}

		[Test]
		public void DivideWithRemainder_LowUneven()
		{
			Assert.AreEqual("5 divided by 2 gives 2, remainder 1.", lab.DivideWithRemainder(5, 2));
		}

		[Test]
		public void DivideWithRemainder_HighEven()
		{
			Assert.AreEqual("424 divided by 8 gives 53, remainder 0.", lab.DivideWithRemainder(424, 8));
		}

		[Test]
		public void DivideWithRemainder_HighUneven()
		{
			Assert.AreEqual("422 divided by 8 gives 52, remainder 6.", lab.DivideWithRemainder(422, 8));
		}

		[Test]
		public void DivideWithRemainder_SecondNegativeUneven()
		{
			Assert.AreEqual("9 divided by -2 ger gives 4, remainder -1.", lab.DivideWithRemainder(9, -2));
		}

		[Test]
		public void DivideWithRemainder_FirstNegativeUneven()
		{
			Assert.AreEqual("-11 divided by 3 ger gives 3, remainder -2.", lab.DivideWithRemainder(-11, 3));
		}

		[Test]
		public void DivideWithRemainder_LargerDenominatorUneven()
		{
			Assert.AreEqual("2 divided by 8 gives 0, remainder 2.", lab.DivideWithRemainder(2, 8));
		}

		[Test]
		[ExpectedException(typeof(DivideByZeroException))]
		public void DivideWithRemainder_DivideByZero()
		{
			lab.DivideWithRemainder(2, 0);
		}
	}

	[TestFixture]
	public class L111_Greatest : Lab1TestBase
	{	 
		[Test]
		public void Greatest_Left()
		{
			Assert.AreEqual(4, lab.Greatest(4, 3));
		}

		[Test]
		public void Greatest_Right()
		{
			Assert.AreEqual(8, lab.Greatest(4, 8));
		}

		[Test]
		public void Greatest_Equal()
		{
			Assert.AreEqual(5, lab.Greatest(5, 5));
		}

		[Test]
		public void Greatest_NegativeLeft()
		{
			Assert.AreEqual(3, lab.Greatest(-4, 3));
		}

		[Test]
		public void Greatest_NegativeRight()
		{
			Assert.AreEqual(4, lab.Greatest(4, -3));
		}

		[Test]
		public void Greatest_Negative()
		{
			Assert.AreEqual(-7, lab.Greatest(-8, -7));
		}
	}

	[TestFixture]
	public class L112_GreatestOfThree : Lab1TestBase
	{
		[Test]
		public void Greatest_OfThree_Trivial()
		{
			Assert.AreEqual(1, lab.Greatest(1, 0, 0));
			Assert.AreEqual(1, lab.Greatest(0, 1, 0));
			Assert.AreEqual(1, lab.Greatest(0, 0, 1));
		}

		[Test]
		public void Greatest_OfThree_Low()
		{
			Assert.AreEqual(5, lab.Greatest(4, 3, 5));
			Assert.AreEqual(6, lab.Greatest(4, 6, 5));
			Assert.AreEqual(7, lab.Greatest(7, 3, 5));
		}

		[Test]
		public void Greatest_OfThree_High()
		{
			Assert.AreEqual(1040000, lab.Greatest(1040000, 250000, 110000));
			Assert.AreEqual(1040000, lab.Greatest(110000, 1040000, 250000));
			Assert.AreEqual(1040000, lab.Greatest(110000, 250000, 1040000));
		}

		[Test]
		public void Greatest_OfThree_Equal()
		{
			Assert.AreEqual(7, lab.Greatest(6, 7, 7));
			Assert.AreEqual(8, lab.Greatest(8, 6, 8));
			Assert.AreEqual(9, lab.Greatest(9, 9, 6));
			Assert.AreEqual(102960, lab.Greatest(102960, 102960, 102960));
		}

		[Test]
		public void Greatest_OfThree_Negative()
		{
			// Double negatives
			Assert.AreEqual(2, lab.Greatest(-2, -2, 2));
			Assert.AreEqual(2, lab.Greatest(2, -2, -2));
			Assert.AreEqual(2, lab.Greatest(-2, 2, -2));

			// Double negative different numbers
			Assert.AreEqual(3, lab.Greatest(-1, -2, 3));
			Assert.AreEqual(1, lab.Greatest(1, -2, -3));
			Assert.AreEqual(2, lab.Greatest(-1, 2, -3));

			// Single negative
			Assert.AreEqual(3, lab.Greatest(-1, 2, 3));
			Assert.AreEqual(1, lab.Greatest(3, -2, 1));
			Assert.AreEqual(2, lab.Greatest(1, 2, -3));

			// All negative
			Assert.AreEqual(-1, lab.Greatest(-1, -2, -3));
			Assert.AreEqual(-43, lab.Greatest(-43, -120, -20501));
			Assert.AreEqual(-1, lab.Greatest(-1, -1230, -3));
		}
	}

	[TestFixture]
	public class L113_GreatestOfFour : Lab1TestBase
	{
		[Test]
		public void Greatest_OfFour_Trivial()
		{
			Assert.AreEqual(1, lab.Greatest(1, 0, 0, 0));
			Assert.AreEqual(1, lab.Greatest(0, 1, 0, 0));
			Assert.AreEqual(1, lab.Greatest(0, 0, 1, 0));
			Assert.AreEqual(1, lab.Greatest(0, 0, 0, 1));
		}

		[Test]
		public void Greatest_OfFour_Low()
		{
			Assert.AreEqual(10, lab.Greatest(10, 3, 4, 2));
			Assert.AreEqual(20, lab.Greatest(2, 20, 4, 3));
			Assert.AreEqual(30, lab.Greatest(2, 3, 30, 4));
			Assert.AreEqual(40, lab.Greatest(2, 3, 4, 40));
		}

		[Test]
		public void Greatest_OfFour_High()
		{
			Assert.AreEqual(1040001, lab.Greatest(1040001, 250000, 110000, 9000));
			Assert.AreEqual(1040002, lab.Greatest(110000, 1040002, 250000, 9000));
			Assert.AreEqual(1040003, lab.Greatest(110000, 250000, 1040003, 9000));
			Assert.AreEqual(1040004, lab.Greatest(110000, 250000, 9000, 1040004));
		}

		[Test]
		public void Greatest_OfFour_Equal()
		{
			Assert.AreEqual(6, lab.Greatest(5, 6, 6, 6));
			Assert.AreEqual(7, lab.Greatest(7, 5, 7, 7));
			Assert.AreEqual(8, lab.Greatest(8, 8, 5, 8));
			Assert.AreEqual(9, lab.Greatest(9, 9, 9, 5));
			Assert.AreEqual(1020765, lab.Greatest(1020765, 1020765, 1020765, 1020765));
		}

		[Test]
		public void Greatest_OfFour_Negative()
		{
			// Three negative
			Assert.AreEqual(2, lab.Greatest( 2, -1, -2, -3));
			Assert.AreEqual(3, lab.Greatest(-1,  3, -2, -3));
			Assert.AreEqual(4, lab.Greatest(-1, -2,  4, -3));
			Assert.AreEqual(5, lab.Greatest(-1, -2, -3,  5));

			// Two negative
			Assert.AreEqual(1, lab.Greatest(1,  1, -1, -1));
			Assert.AreEqual(1, lab.Greatest(1, -1,  1, -1));
			Assert.AreEqual(1, lab.Greatest(1, -1, -1,  1));
			Assert.AreEqual(1, lab.Greatest(-1, 1,  1, -1));
			Assert.AreEqual(1, lab.Greatest(-1, 1, -1,  1));
			Assert.AreEqual(1, lab.Greatest(-1, -1, 1,  1));

			// One negative
			Assert.AreEqual(4, lab.Greatest(-5, 4,  4,  4));
			Assert.AreEqual(4, lab.Greatest(4, -5,  4,  4));
			Assert.AreEqual(4, lab.Greatest(4,  4, -5,  4));
			Assert.AreEqual(4, lab.Greatest(4,  4,  4, -5));
		}
	}

	[TestFixture]
	public class L113_IsGreater : Lab1TestBase
	{
		[Test]
		public void IsGreater_LeftGreatest_IsTrue()
		{
			Assert.IsTrue(lab.IsGreater(2, 1));
			Assert.IsTrue(lab.IsGreater(18000, 600));
			Assert.IsTrue(lab.IsGreater(909090, 909089));
			Assert.IsTrue(lab.IsGreater(0, -1));
			Assert.IsTrue(lab.IsGreater(-20, -50));
		}

		[Test]
		public void IsGreater_RightGreatest_IsFalse()
		{
			Assert.IsFalse(lab.IsGreater(1, 2));
			Assert.IsFalse(lab.IsGreater(500, 900));
			Assert.IsFalse(lab.IsGreater(707070, 707071));
			Assert.IsFalse(lab.IsGreater(-1, 0));
			Assert.IsFalse(lab.IsGreater(-140, -40));
		}

		[Test]
		public void IsGreater_Equal_IsFalse()
		{
			Assert.IsFalse(lab.IsGreater(0, 0));
			Assert.IsFalse(lab.IsGreater(1, 1));
			Assert.IsFalse(lab.IsGreater(808080, 808080));
			Assert.IsFalse(lab.IsGreater(-1507, -1507));
		}
	}

	[TestFixture]
	public class L114_And : Lab1TestBase
	{
		[Test]
		public void And_TrueWhenTrueTrue()
		{
			Assert.IsTrue(lab.And(true, true));
		}

		[Test]
		public void And_FalseWhenTrueFalse()
		{
			Assert.IsFalse(lab.And(true, false));
		}

		[Test]
		public void And_FalseWhenFalseTrue()
		{
			Assert.IsFalse(lab.And(false, true));
		}

		[Test]
		public void And_FalseWhenFalseFalse()
		{
			Assert.IsFalse(lab.And(false, false));
		}
	}

	[TestFixture]
	public class L115_Or : Lab1TestBase
	{
		[Test]
		public void Or_TrueWhenTrueTrue()
		{
			Assert.IsTrue(lab.Or(true, true));
		}

		[Test]
		public void Or_TrueWhenTrueFalse()
		{
			Assert.IsTrue(lab.Or(true, false));
		}

		[Test]
		public void Or_TrueWhenFalseTrue()
		{
			Assert.IsTrue(lab.Or(false, true));
		}

		[Test]
		public void Or_FalseWhenFalseFalse()
		{
			Assert.IsFalse(lab.Or(false, false));
		}
	}

	[TestFixture]
	public class L116_Xor : Lab1TestBase
	{
		[Test]
		public void Xor_FalseWhenTrueTrue()
		{
			Assert.IsFalse(lab.Xor(true, true));
		}

		[Test]
		public void Xor_TrueWhenTrueFalse()
		{
			Assert.IsTrue(lab.Xor(true, false));
		}

		[Test]
		public void Xor_TrueWhenFalseTrue()
		{
			Assert.IsTrue(lab.Xor(false, true));
		}

		[Test]
		public void Xor_FalseWhenFalseFalse()
		{
			Assert.IsFalse(lab.Xor(false, false));
		}
	}

	[TestFixture]
	public class L117_Not : Lab1TestBase
	{
		[Test]
		public void Not_TrueWhenFalse()
		{
			Assert.IsTrue(lab.Not(true));
		}

		[Test]
		public void Not_FalseWhenTrue()
		{
			Assert.IsFalse(lab.Not(true));
		}
	}

	[TestFixture]
	public class L118_IntToString : Lab1TestBase
	{
		[Test]
		public void IntToString_ConvertsNumbersToStrings()
		{
			Assert.AreEqual("150430", lab.IntToString(150430));
			Assert.AreEqual("32", lab.IntToString(32));
		}

		[Test]
		public void IntToString_AllowsZeroToBeConverted()
		{
			Assert.AreEqual("0", lab.IntToString(0));
		}

		[Test]
		public void IntToString_PrependsDashToNegativeNumbers()
		{
			Assert.AreEqual("-12", lab.IntToString(-12));
			Assert.AreEqual("-4045", lab.IntToString(-4045));
		}
	}

	[TestFixture]
	public class L119_StringToInt : Lab1TestBase
	{
		[Test]
		public void StringToInt_ConvertsStringOfAllNumbersToStrings()
		{
			Assert.AreEqual(3, lab.StringToInt("3"));
			Assert.AreEqual(100, lab.StringToInt("100"));
			Assert.AreEqual(10430, lab.StringToInt("10430"));
		}

		[Test]
		public void StringToInt_RemovesTrailingZeroes()
		{
			Assert.AreEqual(10, lab.StringToInt("010"));
			Assert.AreEqual(100000, lab.StringToInt("0000000000100000"));
			Assert.AreEqual(100400, lab.StringToInt("000100400"));
		}

		[Test]
		public void StringToInt_DashAsFirstCharacterCreatesNegativeNumbers()
		{
			Assert.AreEqual(-4, lab.StringToInt("-4"));
			Assert.AreEqual(-104, lab.StringToInt("-104"));
		}

		[Test]
		public void StringToInt_IgnoresWhitespaceBetweenNumbers()
		{
			Assert.AreEqual(16889, lab.StringToInt("   1  6 8  8  9"));
			Assert.AreEqual(79, lab.StringToInt("     7    9   "));
			Assert.AreEqual(-28, lab.StringToInt("      2   8 "));
		}

		[Test]
		public void StringToInt_IgnoresWhitespaceAroundInitialDash()
		{
			Assert.AreEqual(-123, lab.StringToInt("     -  123"));
			Assert.AreEqual(-78, lab.StringToInt("     -   7     8"));
		}

		[Test]
		[ExpectedException]
		public void StringToInt_ThrowsExceptionOnNonNumbers()
		{
			lab.StringToInt("123hello");
			lab.StringToInt("a43");
			lab.StringToInt("123-45");
			lab.StringToInt("#123");
		}

		[Test]
		[ExpectedException]
		public void StringToInt_ThrowsExceptionOnEmptyOrNull()
		{
			lab.StringToInt("");
			lab.StringToInt(null);
		}
	}

	[TestFixture]
	public class L121_CanJoyride : Lab1TestBase
	{
		[Test]
		public void CanJoyride_TrueWhenOldAndTallEnoughAndNoHeartCondition()
		{
			Assert.IsTrue(lab.CanJoyride(12, 150, false));
			Assert.IsTrue(lab.CanJoyride(80, 210, false));
			Assert.IsTrue(lab.CanJoyride(30, 170, false));
		}

		[Test]
		public void CanJoyride_TrueWhenAdultButNotTallEnoughButAboveLowestHeightLimitAndNoHeartCondition()
		{
			Assert.IsTrue(lab.CanJoyride(18, 149, false));
			Assert.IsTrue(lab.CanJoyride(25, 130, false));
		}

		[Test]
		public void CanJoyride_FalseWhenNotTallEnough()
		{
			Assert.IsFalse(lab.CanJoyride(7, 149, false));
			Assert.IsFalse(lab.CanJoyride(11, 130, false));
			Assert.IsFalse(lab.CanJoyride(8, 80, true));
		}

		[Test]
		public void CanJoyride_FalseWhenTooTall()
		{
			Assert.IsFalse(lab.CanJoyride(18, 211, false));
			Assert.IsFalse(lab.CanJoyride(32, 220, true));
			Assert.IsFalse(lab.CanJoyride(72, 240, false));
		}

		[Test]
		public void CanJoyride_FalseWhenEvenBelowLowesetHeightLimitForAdults()
		{
			Assert.IsFalse(lab.CanJoyride(18, 129, false));
			Assert.IsFalse(lab.CanJoyride(25, 100, true));
		}

		[Test]
		public void CanJoyride_FalseWhenHeartCondition()
		{
			Assert.IsFalse(lab.CanJoyride(18, 128, true));
			Assert.IsFalse(lab.CanJoyride(18, 148, true));
			Assert.IsFalse(lab.CanJoyride(18, 180, true));
			Assert.IsFalse(lab.CanJoyride(18, 180, true));
			Assert.IsFalse(lab.CanJoyride(25, 100, true));
		}
	}

  [TestFixture]
  public class L121_DateDifference : Lab1TestBase
  {
    [Test]
    public void DateDifference_LeftAllGreater_ReturnsAbsoluteDifference()
    {
      Assert.AreEqual("1 year(s), 1 month(s), and 1 day(s).", lab.DateDifference(2, 2, 2, 1, 1, 1));
      Assert.AreEqual("2 year(s), 10 month(s), and 5 day(s).", lab.DateDifference(2030, 20, 20, 2028, 10, 15));
    }

    [Test]
    public void DateDifference_RightAllGreater_ReturnsAbsoluteDifference()
    {
      Assert.AreEqual("1 year(s), 1 month(s), and 1 day(s).", lab.DateDifference(0, 0, 0, 1, 1, 1));
      Assert.AreEqual("2645 year(s), 4 month(s), and 7 day(s).", lab.DateDifference(400, 4, 0, 3045, 8, 7));
    }

    [Test]
    public void DateDifference_Equal_ReturnsAbsoluteDifference()
    {
      Assert.AreEqual("0 year(s), 0 month(s), and 0 day(s).", lab.DateDifference(1, 1, 1, 1, 1, 1));
      Assert.AreEqual("0 year(s), 0 month(s), and 0 day(s).", lab.DateDifference(540, 3, 13, 540, 3, 13));
    }

    [Test]
    public void DateDifference_Mixed_ReturnsAbsoluteDistance()
    {
      Assert.AreEqual("1 year(s), 1 month(s), and 0 day(s).", lab.DateDifference(1, 0, 0, 0, 1, 0));
      Assert.AreEqual("1 year(s), 1 month(s), and 0 day(s).", lab.DateDifference(0, 1, 0, 1, 0, 0));
      Assert.AreEqual("1 year(s), 0 month(s), and 1 day(s).", lab.DateDifference(0, 0, 1, 1, 0, 0));
      Assert.AreEqual("3030 year(s), 7 month(s), and 4 day(s).", lab.DateDifference(4030, 5, 20, 1000, 12, 16));
    }
  }

	[TestFixture]
	public class L122_IsLeapYear : Lab1TestBase
	{
		[Test]
		public void IsLeapYear_FalseIfNotDivisibleBy4()
		{
			Assert.IsFalse(lab.IsLeapYear(750));
			Assert.IsFalse(lab.IsLeapYear(93));
			Assert.IsFalse(lab.IsLeapYear(14523));
		}

		[Test]
		public void IsLeapYear_TrueIfDivisibleBy4ButNotDivisibleBy100()
		{
			Assert.IsTrue(lab.IsLeapYear(80));
			Assert.IsTrue(lab.IsLeapYear(1220));
		}

		[Test]
		public void IsLeapYear_FalseIfDivisibleBy4AndDivisibleBy100AndNotDivisibleBy400()
		{
			Assert.IsFalse(lab.IsLeapYear(1300));
			Assert.IsFalse(lab.IsLeapYear(80200));
		}

		[Test]
		public void IsLeapYear_TrueIfDivisibleBy4AndDivisibleBy100AndDivisibleBy400()
		{
			Assert.IsTrue(lab.IsLeapYear(400));
			Assert.IsTrue(lab.IsLeapYear(4800));
			Assert.IsTrue(lab.IsLeapYear(52400));
		}
	}

	// Test setup
	public class Lab1TestBase
	{
		public ILab1 lab = new Lab1();
	}
}

