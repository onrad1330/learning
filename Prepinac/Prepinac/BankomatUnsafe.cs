using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Prepinac
{
    class BankomatUnsafe
    {
        private decimal hotovost = 100;
        private object zamek = new object();

        private void Vyber100()
        {
            lock (zamek)
            {
                if (hotovost >= 100)
                {
                    Console.WriteLine("Vybírám 100");
                    hotovost -= 100;
                    Console.WriteLine("na účtu máte ještě {0}.", hotovost);
                }
            }
        }

        public void VyberVlakny()
        {
            
                Thread vlakno1 = new Thread(Vyber100);
                vlakno1.Start();
                Vyber100();
                if (hotovost < 0)
                    Console.WriteLine("Hotovost je v mínusu, okradli nás.");
        }

    }
}
