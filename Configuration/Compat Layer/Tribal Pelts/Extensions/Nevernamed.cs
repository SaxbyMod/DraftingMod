using BepInEx.Configuration;

namespace DraftingMod.Configuration.Compat_Layer.Tribal_Pelts.Extensions
{
	public class Nevernamed
	{
		public static ConfigFile Config;
		
		public static ConfigEntry<int> extraLobsters;
		public static ConfigEntry<int> extraSpiders;
		public static void NevernamedExtensionCount()
		{
			extraLobsters = Config.Bind<int>(DraftingMod.PluginGuid + ".pelt.counts",
				"How many extra lobsters for the entree?",
				1,
				"How many extra lobsters should be given for the entree?");
			extraSpiders = Config.Bind<int>(DraftingMod.PluginGuid + ".pelt.counts",
				"How many extra spiders for the entree?",
				1,
				"How many extra spiders should be given for the entree?");
		}
		
		public static ConfigEntry<string> extraLobsterPeltChance;
		public static ConfigEntry<string> extraSpiderSkinChance;
		
		public static void NevernamedExtensionChance()
		{
			extraLobsterPeltChance = Config.Bind<string>(DraftingMod.PluginGuid + ".pelt.chances",
				"What should the chances for each lobster entree be?",
				"25%",
				"Give me a list of percentages seperated by commas for each pelt asked for in the counts section. EX; If there were four write `30%, 20%, 10%, 5%` note it doesn't have to be these precisely but must be formatted as such.");
			extraSpiderSkinChance = Config.Bind<string>(DraftingMod.PluginGuid + ".pelt.chances",
				"What should the chances for each spider entree be?",
				"25%",
				"Give me a list of percentages seperated by commas for each pelt asked for in the counts section. EX; If there were four write `30%, 20%, 10%, 5%` note it doesn't have to be these precisely but must be formatted as such.");
		}
	}
}