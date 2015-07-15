using System;

public class Program 
{
	public static void Main(String[] args)
	{
		Utils.Random = new Random();
		var spiritualPerson = new SpiritualPerson(isAlive: true);
		
		while (spiritualPerson.IsAlive)
		{
			Console.WriteLine(spiritualPerson.Think());
			Console.WriteLine(spiritualPerson.Act());
		}
	}
}

public static class Utils
{
	public static Random Random { get; set; }
}