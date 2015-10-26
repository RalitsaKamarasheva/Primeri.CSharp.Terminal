using System;

namespace Modul03
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			double a = 0;
			double b = 0;
			//double c = 0;

			Console.Write (">a=");
			a = Convert.ToDouble(Console.ReadLine ());
			Console.Write (">b=");
			b= Convert.ToDouble(Console.ReadLine ());
			Console.WriteLine (">a/b=" + (a/b).ToString("#0.00"));
		}
	}
}
