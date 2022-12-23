using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Res = AoC_2022.AoC_Shared.Resources.TextResources;
using Con = AoC_2022.AoC_Shared.ConsoleAppearance.ConsoleAppearance;
using Pre = AoC_2022.AoC_MainEvents.Input.Input;
using Pro = AoC_2022.AoC_MainEvents.Process.ProcessData;
using Jun = AoC_2022.AoC_MainEvents.Junk.JunkYard;
using Boss = AoC_2022.AoC_MainEvents.AdventMainEvents;


namespace AoC_MainEventsAoC_2022.AoC_MainEvents.Puzzle
{
    public class Puzzle
    {
        // fields
        public static string filePath;
        public static int choice;
        public static string[] lines;


        // properties
        public static string FilePath
        {
            get { return filePath; }
            set { filePath = value; }
        }

        public static int Choice 
        {
            get { return choice; }
            set { choice = value; }
        }

        public string[] Lines 
        {
            get { return lines; }
            set { lines = value; }
        }


    }
}
