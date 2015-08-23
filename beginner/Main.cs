using System;

namespace Beginner
{
	class Beginer
	{
		static void Main()
		{
			Noob greg = new Noob();
			Console.WriteLine("Greg start counter = " + greg.StartCounter);
			greg.StartCounter = 2;
			Console.WriteLine("Greg start counter = " + greg.StartCounter);
			greg.EndCounter = 6;
			greg.PrintName();
			Console.ReadLine();
		}
	}
	
	class Noob
	{
		private int startCounter = 8;
		private int endCounter;
		
		public int StartCounter
		{
			get
			{
				return startCounter;
			}
			set
			{
				startCounter = value;
			}
		}
		
		public int EndCounter
		{
			get
			{
				return endCounter;
			}
			set
			{
				endCounter = value;
			}
		}
		
		//public Noob(int start, int end)
		//{
		//	startCounter = start;
		//	endCounter = end;
		//}
		
		public static void PrintS(string p1, string p2)
		{
			Console.WriteLine(p1 + p2);
		}
		
		public void Print(string p1, string p2)
		{
			PrintPrivate(p1, p2);
		}
		
		private void PrintPrivate(string p1, string p2)
		{
			Console.WriteLine(p1 + p2);
		}
		
		public void PrintName()
		{
			string name;
			Console.Write("Input name please: ");
			name = Console.ReadLine();
			if(name.ToLower() != "fuck you" && startCounter <= endCounter )
			{
				Console.WriteLine("Your name is: " + name);
				startCounter ++;
				PrintName();
			}
			else
			{
				Console.WriteLine("Fuck YOU");
			}
		}
		
		
	}
}
