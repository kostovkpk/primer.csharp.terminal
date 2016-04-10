using System;

namespace TableProject
{
	enum ti{ime=0, familia, godini}; //декларация

	class MainClass
	{
		public static void Main (string[] args)
		{
			//Дефиниране на таблица
			string[,] table = new string[2, 3];
			//Въвеждане на първи ред
			table[0, (int) ti.ime] = "Калоян"; table[0, (int) ti.familia ] = "Костов"; table[0, (int) ti.godini ] = "27";

			//Въвеждане на втори ред
			table[1, (int) ti.ime ] = "Мариан"; table[1, (int) ti.familia ] = "Костов";	table[1, (int) ti.godini ] = "34";

			// Печат//
			Console.Write ("Кой ред искате да видите: ");
			int _index = Convert.ToInt32 (Console.ReadLine ()) - 1;

			Console.WriteLine ((table[_index, (int) ti.ime])[0]
					   + ". " + table[_index,(int) ti.familia ]
					   + ", " + table[_index,(int) ti.godini ] + " г.");

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