using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obliczanie_pół_i_objętości_figur.Interafces
{
    internal interface IConsoleUISubMenu : IConsoleUIMenu
    {
        void BackToPreviousMenu(IConsoleUIMenu PreviousMenu);
    }
}
