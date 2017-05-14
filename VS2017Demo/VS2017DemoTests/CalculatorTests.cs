using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VS2017Demo;

namespace VS2017DemoTests
{
	// MSTest v2
	// Install-Package MSTest.TestFramework
	// Install-Package MSTest.TestAdapter

	[TestClass]
	public class CalculatorTests
	{
		[DataTestMethod]
		[DataRow(5, 5, 10)]
		[DataRow(0, 0, 0)]
		[DataRow(-1, -5, -6)]
		public void Calculator_Add(int value1, int value2, int expected)
		{
			// arrange
			var calculator = new Calculator();

			// act
			var result = calculator.Add(value1, value2);

			// assert
			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void Calculator_CombineHashCode_Integers()
		{
			// arrange
			var calculator = new Calculator();

			// act
			var result = calculator.CombineHashCode(1, 1);

			// assert
			Assert.AreEqual(2, result);
		}

		[TestMethod]
		public void Calculator_CombineHashCode_Null()
		{
			// arrange
			var calculator = new Calculator();

			// act
			var result = calculator.CombineHashCode(1, null);

			// assert
			Assert.AreEqual(2, result);
		}
	}
}
