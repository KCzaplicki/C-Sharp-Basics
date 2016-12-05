using System;

public class Test
{
	public static void Main()
	{
		B instance = new C();
		instance.foo();
	}
	
	abstract class A
    {
    	public abstract void foo();
    }

    class B : A
    {
    	public override void foo(){
    		Console.WriteLine("B");
    	}
    }
    
    class C : B{
    	public override void foo(){
    		Console.WriteLine("C");
    	}
    }
}