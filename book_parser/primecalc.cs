using System;

namespace book_parser
{
	public class PrimeNumberCalculator
	{

		public bool IsAPrimeNumber(ulong n)
		{
			if (n <=3)
				return n > 1;
			if (IsDivisibleByTwoOrThree (n))
				return false;
			return IsDivisibleByOtherNumbers (n);
		}

		private bool IsDivisibleByTwoOrThree(ulong n)
		{
			return n % 2 == 0 || n % 3 == 0;
		}

		private bool IsDivisibleByOtherNumbers(ulong n)
		{
			for (ulong i = 5; i * i <= n; i += 6)
			{
				if (n % i == 0 || n % (i + 2) == 0)
					return false;
			}
			return true;
		}


	}
}

