using System;
					
public class Program
{
	private static int SKUID_PRICE_A=50;
	private static int SKUID_PRICE_B=30;
	private static int SKUID_PRICE_C=20;
	private static int SKUID_PRICE_D=15;
	public static void Main()
	{
		int A_Quant;
		int B_Quant;
		int C_Quant;
		int D_Quant;
		Console.WriteLine("Please enter how many products you need for SKUID A");
		A_Quant = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Please enter how many products you need for SKUID B");
		B_Quant = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Please enter how many products you need for SKUID C");
		C_Quant = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Please enter how many products you need for SKUID D");
		D_Quant = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine(SKUID_PRICE_A*A_Quant);
	}
}
