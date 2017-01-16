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

		}
	}
}
