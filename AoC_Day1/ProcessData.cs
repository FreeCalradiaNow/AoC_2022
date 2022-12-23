using System;
using System.IO;
using System.Linq;
using Pre = AoC_2022.AoC_MainEvents.Input.Input;
using AoC_MainEventsAoC_2022.AoC_MainEvents.Puzzle;
using Res = AoC_2022.AoC_Shared.Resources.TextResources;

namespace AoC_2022.AoC_MainEvents.Process
{
    public class ProcessData : Pre
    {
        //// fields
        //public static var input;
        //
        //// properties
        //public static var Input
        //{
        //    get { return input; }
        //    set { input = value; }
        //}

        ProcessData _1 = new ProcessData();

        // function for day 1
        public static void Day1Function()
        {            
            var Input = File.ReadAllText(FilePath)
                .Split("\r\n\r\n", StringSplitOptions.None)
                .Select(elf => elf.Split("\r\n", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray()
                )
                .ToArray();
                      
            var Output = Input.Select(elf => elf.Sum()).ToList();
            var MrBigPockets = Output.Max();
            var BigPocketGangNo2 = Output.OrderByDescending(z => z).Skip(1).First();
            var BigPocketGangNo3 = Output.OrderByDescending(z => z).Skip(2).First();

            Console.WriteLine(Res.DayResultHeader);
            Console.WriteLine(Res.Day1Part1ResultPresentation, MrBigPockets);
            Console.WriteLine(Res.Day1Part2ResultPresentation, MrBigPockets, BigPocketGangNo2, BigPocketGangNo3);
        }

        // function for day 2
        public static void Day2Function()
        {

        }


    }
}