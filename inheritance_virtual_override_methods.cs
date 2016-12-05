using System;

public class Test
{
	public static void Main()
	{
		A instance = new B();
		instance.foo();
		B instance2 = new B();
		instance2.foo();
	}
	
	class A
    {
        public virtual void foo(){
			Console.WriteLine("A");
        }
    }

    class B : A
    {
        public override void foo(){
			Console.WriteLine("B");
        }
    }
}