using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_Punkt
{
    class Punkt
    {
        public Punkt()
        {
            PozX = 20;
            PozY = 20;
            Console.WriteLine("Utworzono punkt");
            Wspolrzedne();
        }

        public int PozX { get; private set; }
        public int PozY { get; private set; }

        public int Gora(int G)
        {
            return PozY = PozY-G;
        }

        public int Dol(int D)
        {
            return PozY = PozY + D;
        }

        public int Lewo(int L)
        {
            return PozX = PozX -L;
        }

        public int Prawo(int P)
        {
            return PozX = PozX + P;
        }


        public void Wspolrzedne()
        {
            Console.WriteLine("Wspolrzedna x = {0} Wspolrzedna y = {1}",PozX , PozY);

        }
    }
}
