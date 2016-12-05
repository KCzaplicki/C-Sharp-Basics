using System;

public class Test
{
	static String s;
	static DateTime dt;
	
	public static void Main()
	{
		Console.WriteLine(s == null ? "null" : s);
		Console.WriteLine(dt == null ? "null" : dt.ToString());
	}
}