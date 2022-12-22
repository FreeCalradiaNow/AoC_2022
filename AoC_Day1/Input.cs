using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Res = AoC_2022.AoC_Shared.Resources.TextResources;
using Boss = AoC_2022.AoC_MainEvents.AdventMainEvents;

namespace AoC_2022.AoC_MainEvents.Input
{
    public class Input
    {

        public static string FilePath;
        public static string[] lines;


        // Demands, gets, checks and gives back the day choise input
        internal static int DayChoiceInput()
        {             
            
            Boss.choice = 0;
            Console.Write(Res.InfilInfo);

            string input = Console.ReadLine();

            while (input.Length > 2 || input.Length < 1 || !int.TryParse(input, out Boss.choice) ||
                  Boss.choice < 1 || Boss.choice >= 25)
            {
                Console.WriteLine(Res.InputError + Res.InfilInfo);

                input = Console.ReadLine();
            }

            return Boss.choice;
            
        }

        // shows instructions and gets filepath
        internal static void GetFilePath()
        {
            //do
            //{
            //    Console.Clear();
            //    Console.WriteLine(Res.DemandPath + "\n" + Res.InfoPathFormat + "\n" + Res.IndicatorInput);
            // FilePath = Console.ReadLine();
            //} while (FilePath == "");
            FilePath = @"C:\Users\M.Witzik\Desktop\aocd1.txt";
            var Input = File.ReadAllText(FilePath)
                .Split("\r\n\r\n", StringSplitOptions.None)
                .Select(elf => elf.Split("\r\n", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray()
                )
                .ToArray();
            var Output = Input.Select(elf => elf.Sum()).ToList();
            Output.Sort();
            //Output.Reverse();
            foreach (int i in Output)
            Console.WriteLine(i);
            Console.ReadLine();
        }
    }
}
