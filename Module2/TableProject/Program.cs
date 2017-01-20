using System;

namespace TableProject
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			//дефиниране на масив( 1ви метод- по- сложен за изписване и по- лесен за проверка)
			string[] row = new string[3];
			row[0] = "row 1";
			row[1] = "row 2";
			row[2] = "row 3";
			Console.WriteLine(" array row: " + row[0] + ", " + row[1] + ", " + row[2] + "\n");
			//дефиниране на масив, 2ри метод- по- лесен за изписване, по- сложен за проверка( вадим дължината на масива накрая) 
			string[] parse = "1,2,3,4,5,6,7,8,9".Split(',');
			Console.WriteLine(" the amount of the array is: " + "1,2,3,4,5,6,7,8,9\n\n is:" + parse.Length);


			//събиране на масиви(без да използваме цикли):
			string list1 = string.Join(";", parse);
			Console.WriteLine("new array is: " + list1 + "\n\n");


		}


	}
}
