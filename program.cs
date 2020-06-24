using System;
					
public class Program
{
	private static int SKUID_PRICE_A=50;
	private static int SKUID_PRICE_B=30;
	private static int SKUID_PRICE_C=20;
	private static int SKUID_PRICE_D=15;
	private static bool IS_PROMOTION_1=false;//FOR 3A = 130
	private static bool IS_PROMOTION_2=false;//FOR 2B = 45
	private static bool IS_PROMOTION_3=false;//FOR C+D = 30
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
			IS_PROMOTION_1=(A_Quant/3)>0?true:false;
			Total_A = IS_PROMOTION_1==false?(SKUID_PRICE_A * A_Quant):((A_Quant/3)*130 + SKUID_PRICE_A*(A_Quant%3));
			if(!IS_PROMOTION_1)
			{
				Console.WriteLine(A_Quant + " * A " + Total_A);
			}
			else
			{
				int a=(A_Quant/3)*130;
				int b=SKUID_PRICE_A*(A_Quant%3);
				int c= a+b;
				Console.WriteLine(A_Quant + " * A " + c);
			}
		}
		if(B_Quant!=0)
		{
			int a= (B_Quant/2)*45;
			int b=SKUID_PRICE_B*(B_Quant%2);
			int c= a+b;
			if(IS_PROMOTION_1==true)
			{
				IS_PROMOTION_2=false;
			}
			else
			{
				IS_PROMOTION_2=(B_Quant/2)>0?true:false;				
			}
			Total_B=IS_PROMOTION_2==false?(SKUID_PRICE_B * B_Quant):((B_Quant/2)*45 + SKUID_PRICE_B*(B_Quant%2));
			if(!IS_PROMOTION_2)
			{
				Console.WriteLine(B_Quant + " * B " + Total_B);
			}
			else
			{
				Console.WriteLine(B_Quant + " * B " + c);
			}
		}
		if(C_Quant==1 && D_Quant==1 && IS_PROMOTION_1==false && IS_PROMOTION_2==false)
		{
			Total_C=15;
			Total_D=15;
			Console.WriteLine("C + D " + 30);
		}
		else
		{
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
