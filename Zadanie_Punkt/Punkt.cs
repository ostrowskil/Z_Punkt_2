using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_Punkt
{
    class Punkt
    {
        public Punkt(int PoX, int PoY)
        {
            PozX = PoX;
            PozY = PoY;
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
        
        /////////////////// wstawienie operatora ////////////////////////
        // dodawanie
        public static Punkt operator +(Punkt p1, Punkt p2)
        {

            return new Punkt(p1.PozX + p2.PozX, p1.PozY + p2.PozY);
            //LUB

            //p1.X += p2.X
            //p1.Y += p2.Y

            //Punkt result = new Punkt(5, 5);
            //return result;
                    }
        // odejmowanie
        public static Punkt operator -(Punkt p1, Punkt p2)
        {

            return new Punkt(p1.PozX - p2.PozX, p1.PozY - p2.PozY);
            
            
        }
        // mnożenie
        public static Punkt operator *(Punkt p1, int p)
        {
            return new Punkt(p1.PozX * p, p1.PozY * p); 
        }
        // zamienione argumenty jeżeli są zamienione to nie musimy pisać całej implementacji 
        //dddd
        public static Punkt operator *(int p, Punkt p1)
        {
            return p1 * p; 
        }

        public static Punkt operator /(int p, Punkt p1)
        {
            return p1 * p;
        }
    }
}
