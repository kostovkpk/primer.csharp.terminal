using System;

namespace TableProject
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Дефиниране на таблица
			string[,] table = new string[2, 3];
			//Въвеждане на първи ред
			table[0, 0] = "Калоян"; table[0, 1] = "Костов"; table[0, 2] = "27";

			//Въвеждане на втори ред
			table[1, 0] = "Мариан";	table[1, 1] = "Костов";	table[1, 2] = "34";

			// Печат//
			Console.Write ("Кой ред искате да видите: ");
			int _index = Convert.ToInt32 (Console.ReadLine ()) - 1;

			Console.WriteLine ((table[_index,0])[0] + ". " + table[0,1] + ", " + table[_index,2] + " г.");

		}
	}
}
//			//създаване на масив задава се проя на елементите а отдолу се описват//
//			string[] row = new string[3];
//
//			row[0] = "Стойност 1";
//			row[1] = "Стойност 2";
//			row[2] = "Стойност 3";
//
//			//изобразяване на дисплея//
//			Console.WriteLine ("Масив row: " + row[0] + ", " + row[1] + ", " + row[2] + "\n");
//
//			//Друг начин за създаване на стринг//
//			string[] parse = "1,2,3,4,5,6,7,8,9".Split (',');
//
//			Console.WriteLine ("Броят на цифрите в масива: " + "1,2,3,4,5,6,7,8,9\n e: " + parse.Length);
//
//			//Нови команди .Split, .Length//
//
//			string list1 = string.Join (", ", parse);
//
//			Console.WriteLine ("Новият стринг е:\n" + list1 + "\n");