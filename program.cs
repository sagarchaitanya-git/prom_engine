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
		CalculateActuals(A_Quant, B_Quant, C_Quant, D_Quant);
	}
	private static void CalculateActuals(int A_Quant,int B_Quant,int C_Quant,int D_Quant)
	{
		int Total_A=SKUID_PRICE_A * A_Quant;
		int Total_B=SKUID_PRICE_B * B_Quant;
		int Total_C=SKUID_PRICE_C * C_Quant;
		int Total_D=SKUID_PRICE_D * D_Quant;
		int Total=Total_A+Total_B+Total_C+Total_D;
		Console.WriteLine(A_Quant + " * A " + Total_A);
		Console.WriteLine(B_Quant + " * B " + Total_B);
		Console.WriteLine(C_Quant + " * C " + Total_C);
		Console.WriteLine(D_Quant + " * D " + Total_D);
		Console.WriteLine("=========\nTotal "+Total);
	}
}
