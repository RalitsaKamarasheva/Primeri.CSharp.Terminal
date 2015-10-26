using System;

namespace Modul02
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			//Дефиниране на променлива
			int a=0, b=0;
			int sum = 0;
			string program_name = "Modul02-Примери";
			string program_version = "1.0";


			//Събиране на числа
			a=5;
			b = 10;
			sum = a + b;



			//Писане в конзола
			Console.Write(a);
			Console.Write("+");
			Console.Write(b);
			Console.Write ("=");
			Console.WriteLine(sum);

			Console.WriteLine (program_name);

			//Допълнителни оператори

		}
	}
}
