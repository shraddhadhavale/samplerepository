using System;

namespace BoxUnbox
{
	class Program
	{
		static void Main()
		{
			//int i=10;
			//object obj=i;//boxing with implicit cast
			//int j=Convert.ToInt32(obj);//unboxing
			//Console.WriteLine(j);
			//int i=10;
			//object obj=i;//boxing with implicit cast
			//string s=obj.ToString();//unboxing with explicit cast parsing the int data  stores value like "10" 10 in string
			//int j=int.Parse(s);
			//Console.WriteLine(j);
			
			int i=10;
			object obj=i;//boxing with implicit cast
			//obj="Ten";
			string s=obj.ToString();
			int j;
			bool result=int.TryParse(s, out j);
			if(result==true)
			{
				Console.WriteLine(j);
			}
			else{
				Console.WriteLine("Invalid value !!");
			}
		}
	}
}