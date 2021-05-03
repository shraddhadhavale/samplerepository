using System;

namespace ImplicitlyTypedLocalVar
{
	class Program
	{
		static void Main()
		{
			Console.Write("enter number ");
			object input=Console.ReadLine();
			short number=Convert.ToInt16(input);
			Console.WriteLine("you entered {0}", number);
		}
	}
}