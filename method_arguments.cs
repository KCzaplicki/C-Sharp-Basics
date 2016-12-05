using System;

public class Test
{
	public static void Main()
	{
		int i = 0;
		foo(i);
		Console.WriteLine(i);
		foo2(ref i);
		Console.WriteLine(i);
		foo3(out i);
		Console.WriteLine(i);
	}
	
	static void foo(int i){
		i = 1;
	}
	
	static void foo2(ref int i){
		i = 5;
	}
	
	static void foo3(out int i){
		i = 3;
	}
}