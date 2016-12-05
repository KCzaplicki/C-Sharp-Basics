using System;

public class Test
{
	public static void Main()
	{
		B instance2 = new B();
		instance2.foo();
	}
	
	class A
    {
        public void foo(){
			Console.WriteLine("A");
        }
    }

    class B : A
    {
        private void foo(){
			Console.WriteLine("B");
        }
    }
}