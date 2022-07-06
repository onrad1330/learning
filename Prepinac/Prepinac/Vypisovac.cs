using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Prepinac
{
	class Vypisovac
	{
		public void Vypisuj0()
		{
			for (int i = 0; i <100; i++)
			{
				Console.Write("0");
				Thread.Sleep(5);
			}
		}

		public void Vypisuj1()
		{
			for (int i = 0; i < 150; i++)
			{
				Console.Write("1");
				Thread.Sleep(5);
			}
		}
	}
}
