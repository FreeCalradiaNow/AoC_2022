using System;
using Res = AoC_2022.AoC_Shared.Resources.TextResources;
using Con = AoC_2022.AoC_Shared.ConsoleAppearance.ConsoleAppearance;
using Pre = AoC_2022.AoC_MainEvents.Input.Input;
using Pro = AoC_2022.AoC_MainEvents.Process.ProcessData;
using Jun = AoC_2022.AoC_MainEvents.Junk.JunkYard;
using Puz = AoC_MainEventsAoC_2022.AoC_MainEvents.Puzzle.Puzzle;

namespace AoC_2022.AoC_MainEvents
{
    public class AdventMainEvents : Pro
    {
        
        public static void Main()
        {
            //console appearance gets referenced
            //TODO: actually implement a ref in res
            //Entry:
            
            //TODO: debug mode abfrage implementieren
            Con.ConsoleOptic();

        //main menu appears
        //TODO: menu needs more options like exit and a visual mockup
        Begin:
            Pre.DayChoiceInput();
        
        // day choice activates case with function set 
        //TODO: add cases as the functions got implemented
            switch (Puz.Choice)
            {
                case 1: 
                    Pre.GetFilePath();
                    Pro.Day01Function();
                    Jun.LitSwitchCase();
                    goto Begin;
                    
                case 2:
                    Pre.GetFilePath();
                    Pro.Day02.Day02Function();




                    Jun.LitSwitchCase();
                    goto Begin;

                case 3:
                        Jun.Wasted();
                    break;

                default:
                    break;
            }
        }               
    }
}
