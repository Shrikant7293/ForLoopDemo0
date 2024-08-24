

class Program { 
public static void Main()
{
		/* Single For Loop */

		// PrintNumbers(); 

		// PrintNumber1();

		/* Nested Loop */

		// PrintStar();

		// RevPrintNum(); 

		// RevPrintNum1();

		// RevPrintNum2();

		// RevPrintNum3();

	}

	/* Single Loop */

	public static void PrintNumbers()
	{
		// Print Number From 10,8,6,4,2,0

		for(int i=10;  i>=0; i = i - 2)
		{
			Console.WriteLine("Reverse Number Printed = "+i);
		}
	}

	public static void PrintNumber1()
	{
		// Print Number From 5,10,15,.....,50

		for (int j = 5; j <= 50; j = j + 5)
		{
			Console.WriteLine("Reverse Number Printed = " + j);
		}
	}

	/* Nested Loop */

	public static void PrintStar()
	{
		// 4 x 6

		for (int i=1; i<=4; i++) // Rows
		{
			for (int j=1; j<=6; j++) // Cplumns
			{
				Console.Write(" * ");
			}
			Console.WriteLine();
		}
	}

	public static void RevPrintNum()
	{
		// Print Number 54321 Five Times

		for (int i = 1; i <= 5; i++)
		{
			for (int j = 5; j >= 1; j--)
			{
				Console.Write(j);
			}
			Console.WriteLine();
		}

	}

	public static void RevPrintNum1()
	{
		// Print Number 12345 Five Times
		for(int i=1; i<=5; i++)
		{
			for(int j=1; j<=5; j++)
			{
				Console.Write(j);
			}
			Console.WriteLine();
		}
	}

	public static void RevPrintNum2()
	{
		// Print Number 11111 Five Times
		for(int i=1; i<=5; i++)
		{
			for(int j=1;j<=5; j++)
			{
				Console.Write(i);
			}
			Console.WriteLine();
		}
	}

	public static void RevPrintNum3()
	{
		// Print Number 55555 Five Times
		for(int i=5; i>=1; i--)
		{
			for(int j=1; j<=5; j++)
			{
				Console.Write(i);
			}
			Console.WriteLine();
		}
	}

}
