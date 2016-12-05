using System;

public class Test
{
	public static void Main()
	{
		string s = foo();
		Console.WriteLine(s);
	}
	
	static string foo(){
		try{
			string s = null;
			return s.ToString();
		}
		catch(Exception e){
			Console.WriteLine("catch");
			return "null";
		}
		finally{
			Console.WriteLine("finally");
		}
	}
}