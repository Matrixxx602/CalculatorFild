using Obliczanie_pół_i_objętości_figur;
using System;

namespace Obliczanie_pol_i_objetosci_figur
{
    internal static class UserInputHelper
    {
        public static float GetValue(string question)
        {
            float value;
            do
            {
                Console.WriteLine(question);
                if (!float.TryParse(Console.ReadLine(), out float result) || result <= 0)
                {
                    Communique.WrongAnswer();
                    value = result;
                }
                else
                {
                    value = (float)result;
                }
                
            } while (value <= 0);

           return value;
        }
    }
}
