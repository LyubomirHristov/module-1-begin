using System;

namespace readfromcommand
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			//define the strings
			int a = 5, b = 0;
			//input data
			Console.WriteLine("please input value for b: ");
			b= Convert.ToInt32 ( Console.ReadLine() );
			// the result
			Console.WriteLine(" the sum of a and b is: " + ( a + b).ToString() + "\n\n");//слагаме .tostring-> за да ни превърне резултата в текст


			string test = "1";
			 test += ", 2";
			 test += ",777";
			test += ", 4";
			test += ", 5";
			Console.WriteLine("addition with += : " + test + "\n"); // adding symbols to existing one
			test = test.Replace(",", "-");
			Console.WriteLine("replace , with - = : " + test + "\n");// replacing symbols with already typed one
			Console.WriteLine("3th sign" + test.Split('-')[2]); //listing particular symbol from string(our case "test")


			string one = "hello";
			string two = "world";
			object first = one +" " + two;
			Console.WriteLine("my message is:\n" + first);


		}


	}
}
