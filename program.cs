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
		int.TryParse(Console.ReadLine(), out A_Quant);
		Console.WriteLine("Please enter how many products you need for SKUID B");
		int.TryParse(Console.ReadLine(), out B_Quant);
		Console.WriteLine("Please enter how many products you need for SKUID C");
		int.TryParse(Console.ReadLine(), out C_Quant);
		Console.WriteLine("Please enter how many products you need for SKUID D");
		int.TryParse(Console.ReadLine(), out D_Quant);
		CalculateActuals(A_Quant, B_Quant, C_Quant, D_Quant);
	}
	private static void CalculateActuals(int A_Quant,int B_Quant,int C_Quant,int D_Quant)
	{
		int Total_A=0;
		int Total_B=0;
		int Total_C=0;
		int Total_D=0;
		int Total=0;
		if(A_Quant!=0)
		{
			Total_A = SKUID_PRICE_A * A_Quant;
			Console.WriteLine(A_Quant + " * A " + Total_A);
		}
		if(B_Quant!=0)
		{
			Total_B=SKUID_PRICE_B * B_Quant;
			Console.WriteLine(B_Quant + " * B " + Total_B);
		}
		if(C_Quant!=0)
		{
			Total_C=SKUID_PRICE_C * C_Quant;
			Console.WriteLine(C_Quant + " * C " + Total_C);
		}
		if(D_Quant!=0)
		{
			Total_D=SKUID_PRICE_D * D_Quant;
			Console.WriteLine(D_Quant + " * D " + Total_D);
		}
		Total=Total_A+Total_B+Total_C+Total_D;
		if(Total!=0){
			Console.WriteLine("=========\nTotal "+Total);			
		}
		else
		{
			Console.WriteLine("You have an empty cart. Please try again.");			
		}		
	}
}
