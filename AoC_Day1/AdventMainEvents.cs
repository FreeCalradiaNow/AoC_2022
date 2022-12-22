using System;
using Res = AoC_2022.AoC_Shared.Resources.TextResources;
using Con = AoC_2022.AoC_Shared.ConsoleAppearance.ConsoleAppearance;
using Pre = AoC_2022.AoC_MainEvents.Input.Input;
using Pro = AoC_2022.AoC_MainEvents.Process.ProcessData;
using Jun = AoC_2022.AoC_MainEvents.Junk.JunkYard;

namespace AoC_2022.AoC_MainEvents
{
    public class AdventMainEvents
    {
        public static int choice;
        public static void Main()
        {
            Con.ConsoleOptic();

        Infil:
            Pre.DayChoiceInput();
            Console.Clear();
            Console.WriteLine(Res.InputPickedDay, choice);
            Console.ReadKey();

        switch (choice)
            {
                case 1: 
                    Pre.GetFilePath();

                    //Pro.ArrayDataUp();
                    //Pro.Compare();

                    //Console.WriteLine(Pro);
                    Console.ReadKey();
                    break;

                case 2:
                    Pre.GetFilePath();
                    break;
                case 3:
                    Jun.Wasted();
                    break;
                default:
                    break;
            }
        }               
    }
}
