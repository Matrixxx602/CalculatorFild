using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorFieldApp
{
    public static class Communique
    {
        public static void WrongAnswer()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Zla wartosc! Podaj wlasciwa.");
            Console.ResetColor();
        }
    }
}
