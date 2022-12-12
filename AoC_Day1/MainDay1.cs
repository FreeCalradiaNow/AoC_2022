using System;
using Res = AoC_2022.AoC_Shared.Resources.TextResources;
using Con = AoC_2022.AoC_Shared.ConsoleAppearance.ConsoleAppearance;
using Pre = AoC_2022.AoC_Day1.Prepare.PrepareData;
using Pro = AoC_2022.AoC_Day1.Process.ProcessData;

namespace AoC_2022.AoC_Day1
{
    public class MainDay1
    {       
        private static void Main()
        {
            
            Con.ConsoleOptic();

            Pre.GetFilePath();
            Pre.AddStringToList();
            Pre.Makearray();

            Pro.SumUp();
            Pro.Compare();
            Pro.Pick();
            Pro.PutOut();

        }
    }
}
