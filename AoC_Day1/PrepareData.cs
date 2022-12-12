using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Res = AoC_2022.AoC_Shared.Resources.TextResources;

namespace AoC_2022.AoC_Day1.Prepare
{
    public class PrepareData
    {

        public static string FilePath;
        public static string[] lines;

        // shows instructions and gets input
        internal static void GetFilePath()
        {
            //do
            //{
            //    Console.Clear();
            //    Console.WriteLine(Res.DemandPath + "\n" + Res.InfoPathFormat + "\n" + Res.IndicatorInput);
            // FilePath = Console.ReadLine();
            //} while (FilePath == "");
            FilePath = @"F:\TrainingGIT Tests\AoC_2022\AoC_Day1\BeispielTxt001.txt";
        }



        // processes elve inventories to lists
        internal static void AddStringToList() //TODO: naming anpassen
        {
            var list = new List<string>();
            var fileStream = new FileStream(FilePath, FileMode.Open, FileAccess.Read);

            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    list.Add(line);
                }
            }
            lines = list.ToArray();

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
                  
        }

        // processes list to array
        internal static void Makearray() //TODO: nameing anpassen
        {
            var s = lines.Split(" ".ToCharArray());
        }

    }
}
