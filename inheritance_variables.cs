using System;

public class Test
{
	public static void Main()
	{
		B instance = new B();
		instance.foo();
	}
	
	class A
    {
        protected int i = 1;
    }

    class B : A
    {
        int i = 2;
        
        public void foo(){
			Console.WriteLine(i);
        }
    }
}