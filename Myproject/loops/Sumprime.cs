using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.loops
{
    class Sumprime
    {
		public static void Main(string[] args)
		{
			int i, p, k, s = 0;

			

			for (i = 1; i <= 10; i++)
			{
				k = 2;
				p = 1;
				while (k < i)
				{
					if (i % k == 0)
					{
						p = 0;
						break;
					}
					k++;
				}
				if (p == 1)
				{
					s = s + i;
				}
			}

			Console.WriteLine("Sum of prime numbers:" + s);
		}

	}
}
