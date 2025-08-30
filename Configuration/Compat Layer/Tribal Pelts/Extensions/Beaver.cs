using BepInEx.Configuration;

namespace DraftingMod.Configuration.Compat_Layer.Tribal_Pelts.Extensions
{
	public class Beaver
	{
		public static ConfigFile Config;
		
		public static ConfigEntry<int> extraBeavers;
		
		public static void BeaverExtensionCount()
		{
			extraBeavers = Config.Bind<int>(DraftingMod.PluginGuid + ".pelt.counts",
				"How many extra beavers for the entree?",
				1,
				"How many extra beavers should be given for the entree?");
		}
		
		public static ConfigEntry<string> extraBeaverPeltChance;
		
		public static void BeaverExtensionChance()
		{
			extraBeaverPeltChance = Config.Bind<string>(DraftingMod.PluginGuid + ".pelt.chances",
				"What should the chances for each beaver entree be?",
				"25%",
				"Give me a list of percentages seperated by commas for each pelt asked for in the counts section. EX; If there were four write `30%, 20%, 10%, 5%` note it doesn't have to be these precisely but must be formatted as such.");
		}
	}
}