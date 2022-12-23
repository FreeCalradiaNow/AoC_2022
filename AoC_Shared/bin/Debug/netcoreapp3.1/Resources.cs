using System;

namespace AoC_2022.AoC_Shared.Resources
{ //TODO: wenn möglich überall sichtbarkeit verringern


	//text pool
	public class TextResources
	{
		// console appearance
		public static string ConsoleHeader = "\t\t>>>>> FreeCalradiaNow's AdventofCode 2022 Answer Machine <<<<<";

		// main menu
		public static string MainMenuHeader = ">>>>> Main Menu <<<<<";
		public static string IsDebugTrue = "\r\n\n\r\t\t\t\t\tIS DEBUG MODE TRUE ?\n\t\t\t\t\t [Y] FOR YES\n\t\t\t\t\t [N] FOR NO\n\n\t\t\t\t\t";
		public static string ModePickError = "\r\n\n\r\t\t\t\t\tYOU FAILED TO PROVIDE PROPER INPUT !\n\t\t\t\t\t Press any key to try again..";

		// general
		public static string NothingInfo = "\n\n\n\t\t\tHere´s nothing to see but <insert random D&D lanscape description here>" +
											"\n\t\t\tProceed exploring the untouched and pure wilderness of this code by pressing any key..";
		public static string InfilInfo = "\t\tWelcome to entrypoint of this console app, do what app tell you to do and you´d be fine.. maybe" +
											"\n\t\t\tAnyhow type in a number between 1 and 24 now. The number equals the day of the puzzle you want the answer for.." +
											"\n\t\t\t\tAwaiting input by human..." +
											"\n\t\t\t\t\t>>>>>  ";
		public static string DemandPath = "\t\tPlease enter the path to the .txt now ";
		public static string ApprovePath = "\t\tThank you for complying.." +
											"\n\t\tThe data will be leeched.. ";
		public static string InfoPathFormat = "\t\t(Processable format -> D:\\Example.txt ) ";
		public static string IndicatorInput = "\n\t\tYour input: ";

		public static string InputError = "\t\tYour input sucks and failed to fit the guideline by beeing not a number between 1 and 24.." +
											"\n\t\tJust proceed with any key..\n";
		public static string InputPickedDay = "\n\n\t\tThe puzzle of day " +
												"\n\t\t\t>>>>> {0} <<<<< " +
												"\n\t\t\t\tseems to be the one you want my answers for - at least that´s what i was told.." +
												"\n\t\t\t\tProceed with any key..\n";
		public static string AnyKeyInfo = "\n\t\tProceed with any key..\n";
		public static string DayResultHeader = "\r\n\t\t>>>>> Advent of Code 2022 - Day 1 - Results <<<<<";

		// day 1
		public static string Day1Part1ResultPresentation = "\n\t\tPart 1 --> The elf with the most calories has {0} of it in its inventory.";
		public static string Day1Part2ResultPresentation = "\n\t\tPart 2 --> The three elves overall calories top three inventories are: " +
															"\n\n\t\t\t\t#1 {0} calories." +
															"\n\n\t\t\t\t#2 {1} calories." +
															"\n\n\t\t\t\t#3 {2} calories.";

	}


	//ascii pool
	public class ASCIIResources
	{
		public static string FrameUpper = "╔════════════════════════════════════════════════════════════════════════════════════════╗";
		public static string FrameDowner = "╚════════════════════════════════════════════════════════════════════════════════════════╝";
	}

	public class FixTestPaths
    {
		public static string Day1_b_wrk_0224 = @"C:\Users\M.Witzik\Desktop\aocd1.txt";
		public static string Day2_b_wrk_0224 = @"C:\Users\M.Witzik\Desktop\AoC_2022Day2LiveInput.txt";
		public static string Day3_b_wrk_0224 = @"C:\Users\M.Witzik\Desktop\XXX.txt";
		public static string Day4_b_wrk_0224 = @"C:\Users\M.Witzik\Desktop\XXX.txt";
	}
}
