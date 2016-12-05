using System;

public class Test
{
	public static void Main()
	{
		A instance = new B();
	}
	
	class A
    {
        public A()
        {
            Console.WriteLine("A");
        }
        
        ~A(){
        	Console.WriteLine("~A");
        }
    }

    class B : A
    {
        public B()
        {
            Console.WriteLine("B");
        }
        
        ~B(){
        	Console.WriteLine("~B");
        }
    }
}