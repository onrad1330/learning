using System;
using System.Threading;

namespace Prepinac
{
	class Program
	{
		static void Main(string[] args)
		{
			//Prepinac prep = new Prepinac();
			//prep.Prepinej();
			//Thread.CurrentThread.Name = "Hlavní vlákno";
			//Console.WriteLine(Thread.CurrentThread.Name);

			//Vypisovac vypisovac = new Vypisovac();
			//Thread vlakno0 = new Thread(vypisovac.Vypisuj0);
			//Thread vlakno1 = new Thread(vypisovac.Vypisuj1);

			//vlakno0.Start();
			//vlakno1.Start();
			//vlakno0.Join();
			//vlakno1.Join();
			//Console.WriteLine("Hotovo");

			for (int i = 0; i < 100; i++)
			{
				BankomatUnsafe bankomat = new BankomatUnsafe();
				bankomat.VyberVlakny();
			}

			Console.ReadKey();
		}
	}
}
