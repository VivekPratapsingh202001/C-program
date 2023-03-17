class Factorial
{
	static void Main()
	{    
	    System.Console.Write("enter any  of number ");
		int num= System.Convert.ToInt32(System.Console.ReadLine());
		int i=1,fact=1;
		while(i<num)
		{
		fact=fact*i;
			
		i++;
		}
		System.Console.Write("factorial number"+fact);
		
	}
}
