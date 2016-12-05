using System;

public class Test
{
	public static void Main()
	{
		int i = foo();
		Console.WriteLine(i);
	}
	
	static int foo(){
		try{
			int i = 1;
			return i;
		}
		finally{
			Console.WriteLine("finally");
		}
	}
}