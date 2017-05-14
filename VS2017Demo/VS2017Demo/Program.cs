using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VS2017Demo
{
	public static class Program
	{
		public static void Main(string[] args)
		{
		}
	}

	public class Calculator
	{
		public decimal Add(int value1, int value2)
		{
			return value1 + value2;
		}

		public decimal Sub(int value1, int value2)
		{
			return value1 - value2;
		}

		public int Compute(object obj1, object obj2)
		{
			return obj1.GetHashCode() + obj2.GetHashCode();
		}
	}

}
