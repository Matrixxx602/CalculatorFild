using System;
using System.Security.Policy;

namespace Obliczanie_pól_i_objętości_figur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Zmienne
            string choice;
            float area, bigheight, vol;

            // Wybór figury geometrycznej
            Console.WriteLine("Witaj w programie obliczjącym pola i objętości figur.");
            Console.WriteLine("Wybierz jedną z figur: okrag, kwadrat, prostokat, trojkat.");

            // Obliczanie pola figury
            FigureField pole = new FigureField();
            skip:
            choice = Console.ReadLine();

           switch (choice)
           {
                    case "okrag":
                        area = pole.CalculateCircle();
                        break;

                    case "kwadrat":
                       area = pole.CalculateSquare();
                        break;

                    case "prostokat":
                       area = pole.CalculateRectangle(out bool isIt);

                        if (isIt)
                        {
                        Console.WriteLine("Ten prostokat jest kwadratem.");
                        }
                        break;

                    case "trojkat":
                        area = pole.CalculateTriangle();
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Podales zle wyrazenie, popraw!");
                        Console.ResetColor();
                        Console.WriteLine("Masz do wyboru: okrag, kwadrat, prostokat, trojkat.");
                        goto skip;

           }
            Console.WriteLine("Pole figury wynosi: {0}", area);

            // Obliczanie objętości
            Console.Write("Teraz policzymy objętość bryły. Podaj jego wysokość: ");
            skip2:
            bool value = float.TryParse(Console.ReadLine(), out bigheight);
            if (bigheight <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Zła wartość! Podaj wlasciwa.");
                Console.ResetColor();
                goto skip2;          
            }

            vol = area * bigheight;
            Console.WriteLine("Objetość bryły o podstawie {0} to: {1}",choice, vol);
        }
    }
    public class FigureField
    {
        internal float CalculateCircle()
        {
            const float pi = 3.1415f;

            var r = UserInputHelper.GetValue("Podaj promien okręgu: ");

            return pi * (r * r);
        }

        internal float CalculateSquare()
        {
            float side1 = UserInputHelper.GetValue("Podaj bok kwadratu");

            return side1 * side1;
        }

        internal float CalculateRectangle(out bool isSquare)
        {
            isSquare = false;

            float side1 = UserInputHelper.GetValue("Podaj pierwszy bok prostokata: ");
            var side2 = UserInputHelper.GetValue("Podaj drugi bok prostokata: ");
           

            if (side1 == side2)
            {
                isSquare = true;
            }

            return side1 * side2;
        }

        internal float CalculateTriangle()
        {
            float side1 = UserInputHelper.GetValue("Podaj dlugosc podstawy trojkata: ");
            var height = UserInputHelper.GetValue("Podaj wysokosc trojkata: ");
          
            return side1 * height * 0.5f;
        }
    }
    public static class UserInputHelper
    {

        public static float GetValue(string question)
        {
            Console.WriteLine(question);

            while (!float.TryParse(Console.ReadLine(), out float result) || result <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Zla wartosc! Podaj wlasciwa.");
                Console.ResetColor();
                Console.WriteLine(question);
            }
            return result;
        }
    }
}