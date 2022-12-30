using System;
using System.IO;
using System.Linq;
using Pre = AoC_2022.AoC_MainEvents.Input.Input;
using AoC_MainEventsAoC_2022.AoC_MainEvents.Puzzle;
using Res = AoC_2022.AoC_Shared.Resources.TextResources;
using System.Collections.Generic;

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
        public static void Day01Function()
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
        public class Day02
        {

            // A = X ### A < Y ### A > Z
            // B > X ### B = Y ### B < Z
            // C < X ### C > Y ### C = Z
            // Win = 6 ### Draw = 3 ### Loss = 0
            // AY P1=1 + 0 P2= 2 + 6
            // BX P1=2 +6 P2= 1+0
            // CZ P1= 3 + 3 P2= 3 + 3


            class FormattedRounds : IEnumerable<string>
            {
                private List<string> internalList = new List<string>();
                public IEnumerator<string> GetEnumerator() => internalList.GetEnumerator();

                System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() => internalList.GetEnumerator();

                public void Add(string attack, string counter) => internalList.Add($@"{attack}{counter}");

            }

            public static void Day02Function()
            {
                FormattedRounds rounds = new FormattedRounds();
                
                for (int i = 0; i < round.Length; i++)
                {
                    Console.WriteLine(i);
                }

                
            }
            public static string[] round { get; set; }
            private string[] _round;

            public string[] PathInputToArray(string FilePAth)
            {
                
                var Input = File.ReadAllText(FilePath)
                .Split("\r\n", StringSplitOptions.None)
                .Select(_round => _round.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray()
                )
                .ToArray();

                return _round;
                //var Output = Input; //.Select(round => round.
            }
          
        }


        

    }
}