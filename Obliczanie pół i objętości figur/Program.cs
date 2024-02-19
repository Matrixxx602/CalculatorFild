using System;

namespace Obliczanie_pól_i_objętości_figur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Zmienne
            string wybor;
            float r, a, b, h, duzeh, obj;
            float polef = 0;

            // Wybór figury geometrycznej
            Console.WriteLine("Witaj w programie obliczjącym pola i objętości figur.");
            Console.WriteLine("Wybierz jedną z figur: okrag, kwadrat, prostokat, trojkat.");

            // Obliczanie pola figury
            skip:
            wybor = Console.ReadLine();
            Console.WriteLine("Wybrałeś {0}", wybor);
            PoleFigur pole = new PoleFigur();

             
           switch (wybor)
           {
                    case "okrag":
                        pole.Okrag(out r, out polef);
                        break;

                    case "kwadrat":
                        pole.Kwadrat(out a, out polef);
                        break;

                    case "prostokat":
                        pole.Prostokat(out a, out b, out polef);
                        break;

                    case "trojkat":
                        pole.Trojkat(out a, out h, out polef);
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Podałeś złe wyrazenie, popraw!");
                        Console.ResetColor();
                        Console.WriteLine("Masz do wyboru: okrag, kwadrat, prostokat, trojkat.");
                        goto skip;

           }
            
           
            // Obliczanie objętości
            Console.Write("Teraz policzymy objętość bryły. Podaj jego wysokość: ");
            skip2:
            bool prawidlowawys = float.TryParse(Console.ReadLine(), out duzeh);
            if (duzeh == 0)
            {
                goto skip2;          
            }

            obj = polef * duzeh;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Objetość bryły o podstawie {0} to: {1}",wybor, obj);
            Console.ResetColor();
        }
    }
    public class PoleFigur
    {
        internal float Okrag(out float promien, out float polef)
        {
            float pi = 3.1415f;

            step1:
            Console.Write("Podaj promien okręgu: ");
            bool wynik = float.TryParse(Console.ReadLine(),out promien);

            if (promien == 0)
            {
                goto step1;
            }

            polef = pi * (promien * promien);
            Console.WriteLine("Pole okregu wynosi: {0}", polef);
            return polef;
        }

        internal float Kwadrat(out float bok, out float polef)
        {
            step1:
            Console.Write("Podaj dlugosc boku: ");
            bool wynik = float.TryParse(Console.ReadLine(), out bok);

            if (bok == 0)
            {
                goto step1;
            }

            polef = bok * bok;
            Console.WriteLine("Pole kwadratu wynosi: {0}", polef);
            return polef;
        }

        internal float Prostokat(out float bok1, out float bok2, out float polef)
        {
            step1:
            Console.Write("Podaj dlugosc pierwszego boku: ");
            bool wynik1 = float.TryParse(Console.ReadLine(), out bok1);
            if (bok1 == 0)
            {
                goto step1;
            }

            step2:
            Console.Write("Podaj dlugosc drugiego boku: ");
            bool wynik2 = float.TryParse(Console.ReadLine(), out bok2);
            if (bok2 == 0)
            {
                goto step2;
            }

            polef = bok1 * bok2;
            Console.WriteLine("Pole prostokatu wynosi: {0}", polef);
            return polef;
        }

        internal float Trojkat(out float podstawa, out float wysokosc, out float polef)
        {
            step1:
            Console.Write("Podaj dlugosc podstawy: ");
            bool wynik1 = float.TryParse(Console.ReadLine(), out podstawa);
            if (podstawa == 0)
            {
                goto step1;
            }

            step2:
            Console.Write("Podaj wysokosc trojkata: ");
            bool wynik2 = float.TryParse(Console.ReadLine(), out wysokosc);
            if (wysokosc == 0)
            {
                goto step2;
            }

            polef = podstawa * wysokosc * 0.5f;
            Console.WriteLine("Pole trojkata wynosi: {0}", polef);
            return polef;
        }
    }
}
