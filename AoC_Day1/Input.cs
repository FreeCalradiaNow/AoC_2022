using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Res = AoC_2022.AoC_Shared.Resources.TextResources;
using Pth = AoC_2022.AoC_Shared.Resources.FixTestPaths;
using Boss = AoC_2022.AoC_MainEvents.AdventMainEvents;
using AoC_MainEventsAoC_2022.AoC_MainEvents.Puzzle;
using Jun = AoC_2022.AoC_MainEvents.Junk.JunkYard;
using Con = AoC_2022.AoC_Shared.ConsoleAppearance.ConsoleAppearance;

namespace AoC_2022.AoC_MainEvents.Input
{
    public class Input : Puzzle
    {
        // new object of Puzzle that its properties can be used
        Puzzle _1 = new Puzzle();

        // asks user for the day choise and gives it back
        public static int DayChoiceInput()
        {
            Puzzle.Choice = 0;
            int _choiceHelper = 0; //[Puzzle.Choice] cant be used with [out] when parsing in while loop

           
                

            Console.WriteLine(Res.InfilInfo);

            string input = Console.ReadLine();

            // while input isnt a # in range 1 to 24 loop keeps asking for proper input
            //TODO: implement opt out off loop for user
            while (input.Length > 2 || input.Length < 1 || !int.TryParse(input, out _choiceHelper) ||
                  _choiceHelper < 1 || _choiceHelper >= 25)
            {
                Console.WriteLine(Res.InputError);
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine(Res.InfilInfo); //TODO: this is text res of main menu, not with funct of it - keep in mind once orig main menu got more opts 

                input = Console.ReadLine();
            }
            Puzzle.Choice = _choiceHelper;
            Console.Clear();
            Console.WriteLine(Res.InputPickedDay, Puzzle.Choice);
            Console.ReadKey();
            Console.Clear();
            return Puzzle.Choice;

        }

        // gets filepath from user
        public static string GetFilePath()
        {
            
            Puzzle.FilePath = "";

            if (Jun.debugMode == true)
            {
                switch (Puzzle.Choice)
                {
                    case 1:
                        Puzzle.FilePath = Pth.Day1_b_wrk_0224; //day 1 - fix path for testing
                        break;
                    case 2:
                        Puzzle.FilePath = Pth.Day2_b_wrk_0224; //day 2 - fix path for testing
                        break;
                    default:
                        break;
                }
            }
            else
            {            
                while (Puzzle.FilePath == "")
                    {
                        Console.Clear();
                        Console.WriteLine(Res.DemandPath + "\n" + Res.InfoPathFormat + "\n" + Res.IndicatorInput);
                        Puzzle.FilePath = Console.ReadLine();
                    }                  
            }   
            
            Console.WriteLine(Res.ApprovePath + "\n\n");
            Console.Clear();

            return Puzzle.FilePath;
        }


       


    }
}
