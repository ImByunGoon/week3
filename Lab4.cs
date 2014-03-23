using System;

namespace typeConversion
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			string num1 = Console.ReadLine ();
			string num2 = Console.ReadLine ();

			int num1_;
			int num2_;

			num1_ = int.Parse (num1);
			num2_ = int.Parse (num2);

			int sum = num1_ + num2_;
		
			Console.WriteLine ("num1={0},num2={1},sum={2}", num1, num2, sum);
		}
	}
}
