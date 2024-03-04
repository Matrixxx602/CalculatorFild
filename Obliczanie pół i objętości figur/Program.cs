using Obliczanie_pół_i_objętości_figur;
using System;
using System.Security.Policy;

namespace Obliczanie_pol_i_objetosci_figur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Zmienne
            string choice;
            double area, bigHeight, vol;

            // Wybór figury geometrycznej
            Console.WriteLine("Witaj w programie obliczjącym pola i objętości figur.");
            Console.WriteLine("Wybierz jedną z figur: okrag, kwadrat, prostokat, trojkat.");

            // Obliczanie pola figury
            skip:
            choice = Console.ReadLine();

           switch (choice)
           {
                    case "okrag":
                        area = FigureField.CalculateCircle();
                        break;

                    case "kwadrat":
                       area = FigureField.CalculateSquare();
                        break;

                    case "prostokat":
                       area = FigureField.CalculateRectangle(out bool square);

                        if (square)
                        {
                        Console.WriteLine("Ten prostokat jest kwadratem.");
                        }
                        break;

                    case "trojkat":
                        area = FigureField.CalculateTriangle();
                        break;

                    default:
                    Communique.WrongAnswer();
                        Console.WriteLine("Masz do wyboru: okrag, kwadrat, prostokat, trojkat.");
                        goto skip;

           }
            Console.WriteLine("Pole figury wynosi: {0}", area);

            // Obliczanie objętości
            Console.Write("Teraz policzymy objętość bryły. Podaj jego wysokość: ");
            skip2:
            bool value = double.TryParse(Console.ReadLine(), out bigHeight);
            if (bigHeight <= 0)
            {
                Communique.WrongAnswer();
                goto skip2;          
            }

            vol = area * bigHeight;
            Console.WriteLine("Objetość bryły o podstawie {0} to: {1}",choice, vol);
            Console.ReadLine();
        }
    }
}