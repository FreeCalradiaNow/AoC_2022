using System;
using System.Collections.Generic;
using System.Text;
using AoC_2022.AoC_MainEvents;
using Res = AoC_2022.AoC_Shared.Resources.TextResources;
using Boss = AoC_2022.AoC_MainEvents.AdventMainEvents;
using Pro = AoC_2022.AoC_MainEvents.Process.ProcessData;

namespace AoC_2022.AoC_MainEvents.Junk
{
    public class JunkYard : Pro
    {
        public static void Wasted()
        {
            Console.WriteLine(Res.NothingInfo);
            Console.ReadKey();
        }
        public static void LitSwitchCase()
        {
            Console.WriteLine(Res.AnyKeyInfo);
            Console.ReadKey();
            Console.Clear();
        }

        // field
        public static bool debugMode = true; // hard true , TODO: implement method beneath

        JunkYard _1 = new JunkYard();

        // property
        //public static bool DebugMode
        //{
        //    get { return debugMode; }
        //    set { debugMode = value; }
        //}

        //public static bool Mode()
        //{            
        //    ModeEntry:
        //    Console.WriteLine(Res.IsDebugTrue);
        //    if (Console.ReadKey().Key = ConsoleKey.Y)
        //    {
        //        return debugMode = true;
        //    }
        //    if (Console.ReadKey().Key = ConsoleKey.N)
        //    {
        //        return debugMode = false;
        //    }
        //    if (Console.ReadKey().Key != ConsoleKey.Y || ConsoleKey.N)
        //    {
        //        Console.WriteLine(Res.ModePickError);
        //        Console.Clear();
        //        return debugMode = false;
        //        goto ModeEntry;
        //       
        //    }
        //}
        
    }
}
