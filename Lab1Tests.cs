using NUnit.Framework;
using System;

namespace OOP1Labs
{
	[TestFixture]
	public class Lab1Tests
	{
		ILab1 lab = new Lab1();

		[Test]
		public void Test_Add_LowNumbers()
		{
			Assert.AreEqual(3, lab.Add(1, 2));
		}

		[Test]
		public void Test_Add_OneZero()
		{
			Assert.AreEqual (1, lab.Add(1, 0));
		}

		[Test]
		public void Test_Add_NegativeNumbers()
		{
			Assert.AreEqual(-2, lab.Add(2, -4));
		}

		[Test]
		public void Test_Add_LargeNumbers()
		{
			Assert.AreEqual(30500, lab.Add(10480, 20020));
		}
	}
}

