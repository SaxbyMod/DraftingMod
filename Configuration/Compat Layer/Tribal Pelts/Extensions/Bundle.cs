using BepInEx.Configuration;

namespace DraftingMod.Configuration.Compat_Layer.Tribal_Pelts.Extensions
{
	public class Bundle
	{
		public static ConfigFile Config;
		
		public static ConfigEntry<int> extraHumans;
		public static ConfigEntry<int> extraSharks;
		public static ConfigEntry<int> extraTigers;
		
		public static void BundleExtensionCount()
		{
			extraHumans = Config.Bind<int>(DraftingMod.PluginGuid + ".pelt.counts",
				"How many extra humans for the entree?",
				1,
				"How many extra humans should be given for the entree?");
			extraSharks = Config.Bind<int>(DraftingMod.PluginGuid + ".pelt.counts",
				"How many extra sharks for the entree?",
				1,
				"How many extra sharks should be given for the entree?");
			extraTigers = Config.Bind<int>(DraftingMod.PluginGuid + ".pelt.counts",
				"How many extra tigers for the entree?",
				1,
				"How many extra tigers should be given for the entree?");
		}
		
		public static ConfigEntry<string> extraHumanRemainsChance;
		public static ConfigEntry<string> extraSharkLeatherChance;
		public static ConfigEntry<string> extraTigerPeltChance;

		public static void BundleExtensionChance()
		{
			extraHumanRemainsChance = Config.Bind<string>(DraftingMod.PluginGuid + ".pelt.chances",
				"What should the chances for each human entree be?",
				"25%",
				"Give me a list of percentages seperated by commas for each pelt asked for in the counts section. EX; If there were four write `30%, 20%, 10%, 5%` note it doesn't have to be these precisely but must be formatted as such.");
			extraSharkLeatherChance = Config.Bind<string>(DraftingMod.PluginGuid + ".pelt.chances",
				"What should the chances for each shark entree be?",
				"25%",
				"Give me a list of percentages seperated by commas for each pelt asked for in the counts section. EX; If there were four write `30%, 20%, 10%, 5%` note it doesn't have to be these precisely but must be formatted as such.");
			extraTigerPeltChance = Config.Bind<string>(DraftingMod.PluginGuid + ".pelt.chances",
				"What should the chances for each tiger entree be?",
				"25%",
				"Give me a list of percentages seperated by commas for each pelt asked for in the counts section. EX; If there were four write `30%, 20%, 10%, 5%` note it doesn't have to be these precisely but must be formatted as such.");
		}
	}
}