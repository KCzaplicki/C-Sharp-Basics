using System;

public class Test
{
	public static void Main()
	{
		A instance = new B();
		B instance2 = new B();
		var instance3 = new B();
	}
	
	class A
    {
        public A()
        {
            Console.WriteLine("A");
        }
    }

    class B : A
    {
        public B()
        {
            Console.WriteLine("B");
        }
    }
}