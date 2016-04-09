using System;

namespace Modul02
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Дефиниране на променливи
			int a = 0, b = 0;
			int sum = 0;

			//Събиране на числа
			a=5; b=55;
			sum = a + b;

			//Писане в конзолата
			Console.Write (a);
			Console.Write (" + ");
			Console.Write (b);
			Console.Write (" = ");
			Console.WriteLine ( sum );
		}
	}
}
