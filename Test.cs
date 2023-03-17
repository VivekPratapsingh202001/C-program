class project
{   
	static void Main(string [] args)
	{
	System.Console.WriteLine("Enter any no");
	int num=int.Parse(System.Console.ReadLine());
	System.Console.WriteLine("chouse any oprator which you want to performed");
	System.Console.WriteLine("\n1.Addition of all digit number"+"\n2.check even and odd values"+"\n3.check positive and negative values"
	+"\n4.check prime or non prime"+"\n5.revers the values"
	+"\n6.factorial of values"+"\n7.squre of values"+"\n8.check no is palindrom or not"+"\n9.check no is Armstrong or not"
	+"\n10.Multiply of all digit number"+"\n11. print fabbiano series"+"\n12. double values"); 
	int num1=System.Convert.ToInt32(System.Console.ReadLine());
   	switch(num1)
	{
	case 1:
		{
		System.Console.WriteLine("addition of all digit number");
		int temp=num;
		int i=0,revers=0,sum=0;
		while(num>i)
	{
		revers=num%10;
		sum=sum+revers;
		num=num/10;
	}
		System.Console.WriteLine("addition of values"+sum);
		break;
		}
		
	case 2:
		{
			System.Console.WriteLine("check even and odd values");
			if(num%2==0)
		{
		System.Console.WriteLine(num+" this is even no");
		}
	else
		{
		System.Console.WriteLine(num+" this is odd number");
		}
		break;
		}
	
	case 3:
		{
			System.Console.WriteLine("check positive and negative values");
			if(num>0)
		{
		System.Console.WriteLine(num+" this is positive no");
		}
	else
		{
		System.Console.WriteLine(num+" this is negative no");
		}
		break;
		}
		
	case 4:
		{
			System.Console.WriteLine("check prime or non prime values");
			int count=0;
			for(int j=1;j<=num;j++)
			{
			if(num%j==0)
			
				count++;
			}    
		
		if(count==2)
		{
		System.Console.WriteLine(num+" this is prime no");
		}
	else
		{
		System.Console.WriteLine(num+" this is non prime no");
		}
		break;
		}
		
	case 5:
		{
			System.Console.WriteLine("Revers values");
			int rev=0;
			for(int j=0;j<=num;j++)
			{
			rev=(num%10);
			System.Console.Write(rev);
			num=num/10;
			}
			break;
		}
		
	case 6:
		{
			System.Console.WriteLine("Factorial values");
			int fac=1;
			for(int i=1;i<=num;i++)
			{
			fac=fac*i;
		
			}
			System.Console.Write("factorial number" +fac);
			break;
		}

    case 7:
		{
			System.Console.WriteLine("Squre of number");
			int squre=1;
			for(int i=0;i<=num;i++)
			{
				squre=squre*num;
			}
			System.Console.Write("Squre of number"+squre);
			break;
		}	
		
	
	case 8:
	{
		System.Console.WriteLine("check no is palindrom or not");
		int temp=num;
	    int i=0,revers=0;
	    while(num>i)
	{
		revers=num%10;
		num=num/10;
		}
	if(num==temp) 
		{
		System.Console.WriteLine(temp+" no is palindrom ");
		}
	else
		{
		System.Console.WriteLine(temp+" no is not palindrom ");
		}
	break;
	}
	
	case 9:
	{
		System.Console.WriteLine("check no is Armstrong or not");
		int temp=num;
		int i=0,revers=0,arm=0;
		while(num>i)
	{
		revers=num%10;
		arm=arm*10+revers*revers*revers;
		num=num/10;
	}
	if(num==arm)
		{
		System.Console.WriteLine(temp +" no is Armstrong");
		}
	else{
		System.Console.WriteLine(temp +" no is not Armstrong");
		}
		break;
		}
		case 10:
		{
		System.Console.WriteLine("multiply of all digit number");
		int temp=num;
		int i=0,revers=0,mul=1;
		while(num>i)
		{
		revers=num%10;
		mul=mul*revers;
		num=num/10;
		}
		System.Console.WriteLine("multiply =" +mul);
	break;
		}
		case 11:
		{
		System.Console.WriteLine("fabbiano series");
		int n1=0,n2=1,n3,i;
		System.Console.Write( n1 + " "+ n2 +" " );
		for(i=2;i<num;i++)
			{
				n3=n1+n2;
				
				System.Console.Write( n3 + " ");
				n1=n2;
				n2=n3;
			}
		}
		break;
	case 12:
		{
			System.Console.WriteLine("double of number");
			int dou;
			dou=num*2;
			System.Console.WriteLine("double number "+dou);
		}
	break;
	
	}
}
}


















/*class Program
    {
        static void Main(string[] args)
        {
           
            int min, max;
            int[,] arr ={ { 10,50,13,80,40}, { 1, 250, 65, 28, 15 }, { 12, 17, 45, 20, 6 } };
            
            
            min = arr[0,0];
            max = arr[0,0];
 
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                { 
                    if(arr[i,j] > max) 
                    {
                        max = (max>arr[i,j])?max:arr[i,j];
					}
					if(arr[i,j] < min)
					{
						min = (min<arr[i,j])?min:arr[i,j];
                    }
 
 
                }
 
            }
 
           
            System.Console.Write("Array Elements\n");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                   System.Console.Write(arr[i, j]+" ,");
                }
                System.Console.WriteLine();
            }
            System.Console.WriteLine();
 
            
            System.Console.WriteLine("Maximum element:"+max);
           System.Console.WriteLine("Minimum  element:" + min);
            System.Console.ReadLine();
        }
    }
	*/
	

/*class Program
    {
        static void Main(string[] args)
        {
           
            int min, max;
            int[,] arr ={ { 10,50,13,80,40}, { 1, 250, 65, 28, 15 }, { 12, 17, 45, 20, 6 } };
            
            
            min = arr[0,0];
            max = arr[0,0];
 
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                { 
                    if(arr[i,j] > max) 
                    {
                        max = (max>arr[i,j])?max:arr[i,j];
					}
					if(arr[i,j] < min)
					{
						min = (min<arr[i,j])?min:arr[i,j];
                    }
 
 
                }
 
            }
 
           
            System.Console.Write("Array Elements\n");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                   System.Console.Write(arr[i, j]+" ,");
                }
                System.Console.WriteLine();
            }
            System.Console.WriteLine();
 
            
            System.Console.WriteLine("Maximum element:"+max);
           System.Console.WriteLine("Minimum  element:" + min);
            System.Console.ReadLine();
        }
    }
	*/
	