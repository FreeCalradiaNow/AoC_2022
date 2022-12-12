using System;
using System.Collections.Generic;
using System.Text;
using Res = AoC_2022.AoC_Shared.Resources.TextResources;
using LINQ;

namespace AoC_2022.AoC_Day1.Prepare
{
    public class PrepareData
    {
        // shows instructions and gets input
        internal static void Input()
        {
            string path;
                       
            do
            {
                Console.Clear();
                Console.WriteLine(Res.DemandPath + "\n" + Res.InfoPathFormat + "\n" + Res.IndicatorInput);
                path = Console.ReadLine();
            } while (path == "");

        }



        // processes elve inventories to lists
        internal static void MakeList() //TODO: nameing anpassen
        {
            //
        }

        // processes list to array
        internal static void Makearray() //TODO: nameing anpassen
        {
            //
        }

    }
}
