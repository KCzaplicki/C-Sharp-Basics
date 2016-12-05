using System;

public class Test
{
	public static void Main()
	{
		A instance2 = new B();
	}
	
	sealed class A
    {
    }

    class B : A
    {
    }
}