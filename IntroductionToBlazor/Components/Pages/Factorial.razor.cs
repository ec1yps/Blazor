namespace IntroductionToBlazor.Components.Pages
{
	public partial class Factorial
	{
		int n = 0;
		long factorial = 1;
		void Calculate()
		{
			factorial = 1;
			for (int i = 1; i <= n; i++)
			{
				factorial *= i;
			}
		}
	}
}
