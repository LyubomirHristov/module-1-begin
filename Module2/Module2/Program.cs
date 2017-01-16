using System;
namespace Module2
{
	class MainClass
{
	public static void Main(string[] args)
	{

		//дефиниране на променливи
		int a = 0, b = 0;
		int sum = 0; int sum2 = 0;
		int c = 0; int d = 0;

			//string program type 
			string program_name = "module2- examples";
			Console.WriteLine(program_name);
			//string program version
			string program_version = "1.0";
			Console.WriteLine("version: "+ program_version+ "\n\n");


		//събиране на числа
		a = 55; b = 10; sum = a + b;
		c = 10; d = 5; sum2 = c + d;
		//писане в конзола
		Console.Write(a);
		Console.Write(" + ");
		Console.Write(b);
		Console.Write(" = ");
		Console.WriteLine(sum);
		Console.Write(c);
		Console.Write(" + ");
		Console.Write(d);
		Console.Write(" = ");
		Console.WriteLine(sum2);
		//допълнителни оператори
		Console.WriteLine("\n using +=");
		a += b;
		Console.WriteLine(a);
		Console.WriteLine("\n using -=");
		c -= d;
		Console.WriteLine(c);

		Console.WriteLine("\n multiplication on 4 int *=");
		Console.WriteLine(a);
		Console.WriteLine(b);
		a *= b;
		Console.WriteLine(a);




	}

}
}
