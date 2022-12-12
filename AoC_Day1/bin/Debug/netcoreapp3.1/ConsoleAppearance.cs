using System;
using System.Collections.Generic;
using System.Text;

namespace AoC_2022.AoC_Shared.ConsoleAppearance
{
    public abstract class ConsoleAppearance
    {
        //TODO: schauen ob man das nicht über abstract/virtual laufen lassen kann + sichtbarkeit verringern
        public static void ConsoleOptic()
        {
            //calibrating console view
            Console.CursorVisible = false;
        }

    }
}
