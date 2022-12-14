using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Res = AoC_2022.AoC_Shared.Resources.TextResources;

namespace AoC_2022.AoC_Day1.Input
{
    public class Input
    {

        public static string FilePath;
        public static string[] lines;

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
