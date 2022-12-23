﻿using System;
using System.Collections.Generic;
using System.Text;
using Res = AoC_2022.AoC_Shared.Resources.TextResources;

namespace AoC_2022.AoC_Shared.ConsoleAppearance
{
    public abstract class ConsoleAppearance
    {
        //TODO: schauen ob man das nicht über abstract/virtual laufen lassen kann + sichtbarkeit verringern
        public static void ConsoleOptic()
        {
            //calibrating console view
            Console.CursorVisible = false;
            //Console.Title = Res.ConsoleHeader;
            Console.ForegroundColor = ConsoleColor.Red;
        }

        // console header
        /// <summary>
        /// 
        /// </summary>
        /// <param name="title"></param>
        /// <param name="subtitle"></param>
        /// <param name="foreGroundColor"></param>
        /// <param name="windowWidthSize"></param>
        public static void Header(string title, string subtitle = "", ConsoleColor foreGroundColor = ConsoleColor.White, int windowWidthSize = 90)
        {
            Console.Title = title + (subtitle != "" ? " - " + subtitle : "");
            string titleContent = CenterText(title, "║");
            string subtitleContent = CenterText(subtitle, "║");
            string borderLine = new String('═', windowWidthSize - 2);

            Console.ForegroundColor = foreGroundColor;
            Console.WriteLine($"╔{borderLine}╗");
            Console.WriteLine(titleContent);

            if (!string.IsNullOrEmpty(subtitle))
            {
                Console.WriteLine(subtitleContent);
            }

            Console.WriteLine($"╚{borderLine}╝");
            Console.ResetColor();
        }

        // centers text
        public static string CenterText(string content, string decorationString = "", int windowWidthSize = 90)
        {
            int windowWidth = windowWidthSize - (2 * decorationString.Length);

            return String.Format(decorationString + "{0," + ((windowWidth / 2) + (content.Length / 2)) + "}{1," + (windowWidth - (windowWidth / 2) - (content.Length / 2) + decorationString.Length) + "}"
                , content
                , decorationString);
        }

    }
}
