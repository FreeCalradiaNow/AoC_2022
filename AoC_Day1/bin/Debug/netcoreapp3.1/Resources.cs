using System;

namespace AoC_2022.AoC_Shared.Resources
{ //TODO: wenn möglich überall sichtbarkeit verringern


	//text pool
	public class TextResources
	{
		public static string NothingInfo = "\n\n\n\t\t\tHere´s nothing to see but <insert random D&D lanscape description here>" +
											"\n\t\t\tProceed exploring the untouched and pure wilderness of this code by pressing any key..";
		public static string InfilInfo = "\t\tWelcome to infiltration, do what told you to do and you´d spared.. maybe" +
											"\n\t\t\tType in a number between 1 and 24 for the puzzle you want the answer for and wait for following instructions then" +
											"\n\t\t\t\tAwaiting input by human..." +
											"\n\t\t\t\t\t>>>>>  ";
		public static string DemandPath = "\t\tPlease enter the path to the .txt now ";
        public static string InfoPathFormat = "\t\t(Processable format -> D:\\Example.txt ) ";
		public static string IndicatorInput = "Your input: ";

		public static string InputError = "\t\tYour input sucks and failed to fit the guideline by beeing not a number between 1 and 24..\r";
		public static string InputPickedDay = "\n\n\t\tThe puzzle of day \n\t\t\t>>>>> {0} <<<<< \n\t\t\t\tseems to be the one you want my answers for - at least that´s what i was told..";
    }


	//ascii pool
	public class ASCIIResources
	{
		//	
    }

}
