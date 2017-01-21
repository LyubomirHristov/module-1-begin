using System;

namespace TableProject
{
	class MainClass
	{
		public static void Main(string[] args)




		{

			//дефиниране на таблица
			string[,] table = new string[2, 3];
			//въвеждане на 1ви ред
			table[0, 0] = "Lyubo"; table[0, 1] = "Hristov"; table[0, 2] = "24";

			//въвеждане на 2ри ред
			table[1, 0] = "Hristo"; table[1, 1] = "Lyubomirov"; table[1, 2] = "25";

			//печат
			Console.Write("which row do you want to see: ");
			int _index = Convert.ToInt32(Console.ReadLine ()) -1;//-->слагаме -1, защото компилатора ни брои 0 като цяло число и започваме от нея

			Console.WriteLine((table[_index, 0])[0] + "." + table[_index, 1] + ", " +"age:"+ table[_index,2]);




		}


	}
}
