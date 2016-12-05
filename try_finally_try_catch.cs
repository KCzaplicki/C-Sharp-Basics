using System;

public class Test
{
	public static void Main()
	{
		try
		{
			try
			{
				string s = null;
				Console.WriteLine(s);
				Console.WriteLine("try");
				Console.WriteLine(s.ToString());
				Console.WriteLine("try2");
			}
			finally
			{
				Console.WriteLine("finally");
			}
		}
		catch (Exception e)
		{
			
		}
	}
}