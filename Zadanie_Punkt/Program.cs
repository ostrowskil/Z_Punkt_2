using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_Punkt
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 5; i++)
            {
                Punkt punkt8 = new Punkt(10, 10);
            }

            Console.WriteLine("LICZNIK{0}",Punkt.Licznik);

            Console.WindowHeight = 50;
            Console.WindowWidth = 84;
            Console.BackgroundColor = ConsoleColor.Blue;
          //  Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Title = "BALLUFF - KURS C#";
            string kursor = "BALLUFF";

            Punkt punkt = new Punkt(20, 20);

            Punkt punkt1 = new Punkt(2, 2);
            Punkt punkt2 = new Punkt(2, 2);

            Punkt punkt3 = punkt1 - punkt2;

            punkt3.Wspolrzedne();

            
            
            // punkt.Gora(1);
            // punkt.Lewo(2);


            while (true)
            {
                ConsoleKeyInfo klawisz = Console.ReadKey();
                switch (klawisz.Key)
                {
                    case ConsoleKey.UpArrow:
                        Console.Clear(); punkt.Gora(1); punkt.Wspolrzedne();
                        Console.SetCursorPosition(punkt.PozX, punkt.PozY);
                        Console.WriteLine(kursor);
                        break;
                    case ConsoleKey.DownArrow:
                        Console.Clear(); punkt.Dol(1); punkt.Wspolrzedne();
                        Console.SetCursorPosition(punkt.PozX, punkt.PozY);
                        Console.WriteLine(kursor);
                        break;
                    case ConsoleKey.LeftArrow:
                        Console.Clear(); punkt.Lewo(1)  ; punkt.Wspolrzedne();
                        Console.SetCursorPosition(punkt.PozX, punkt.PozY);
                        Console.WriteLine(kursor);
                        break;
                    case ConsoleKey.RightArrow:
                        Console.Clear(); punkt.Prawo(1); punkt.Wspolrzedne();
                        Console.SetCursorPosition(punkt.PozX, punkt.PozY);
                        Console.WriteLine(kursor);
                        break;

                }
            }

            
            
            Console.ReadKey();
        }
    }
}
