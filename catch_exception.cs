using System;

public class Test
{
	public static void Main()
	{
		try{
			string s = null;
			Console.WriteLine(s);
			Console.WriteLine("try");
			Console.WriteLine(s.ToString());
			Console.WriteLine("try2");
		}
		catch(Exception e){
			Console.WriteLine("exception");
		}
		finally{
			Console.WriteLine("finally");
		}
	}
}