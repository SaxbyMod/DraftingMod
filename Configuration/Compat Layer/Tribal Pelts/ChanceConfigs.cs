using BepInEx.Configuration;
using DraftingMod.Configuration.Compat_Layer.Tribal_Pelts.Extensions;

namespace DraftingMod.Configuration.Compat_Layer.Tribal_Pelts
{
	public class ChanceConfigs
	{
		public static ConfigFile Config;
		
		public static ConfigEntry<string> extraRavenEpidermisesChance;
		public static ConfigEntry<string> extraCoyotePeltChance;
		public static ConfigEntry<string> extraMothMoltChance;
		public static ConfigEntry<string> extraDeerPeltChance;
		public static ConfigEntry<string> extraCrocadileHideChance;

		public static void Init()
		{
			// Handle Tribal Pelts -- Base
            extraRavenEpidermisesChance = Config.Bind<string>(DraftingMod.PluginGuid + ".pelt.chances",
                "What should the chances for each raven entree be?",
                "25%",
                "Give me a list of percentages seperated by commas for each pelt asked for in the counts section. EX; If there were four write `30%, 20%, 10%, 5%` note it doesn't have to be these precisely but must be formatted as such.");
            extraCoyotePeltChance = Config.Bind<string>(DraftingMod.PluginGuid + ".pelt.chances",
                "What should the chances for each coyote entree be?",
                "25%",
                "Give me a list of percentages seperated by commas for each pelt asked for in the counts section. EX; If there were four write `30%, 20%, 10%, 5%` note it doesn't have to be these precisely but must be formatted as such.");
            extraMothMoltChance = Config.Bind<string>(DraftingMod.PluginGuid + ".pelt.chances",
                "What should the chances for each moth entree be?",
                "25%",
                "Give me a list of percentages seperated by commas for each pelt asked for in the counts section. EX; If there were four write `30%, 20%, 10%, 5%` note it doesn't have to be these precisely but must be formatted as such.");
            extraDeerPeltChance = Config.Bind<string>(DraftingMod.PluginGuid + ".pelt.chances",
                "What should the chances for each deer entree be?",
                "25%",
                "Give me a list of percentages seperated by commas for each pelt asked for in the counts section. EX; If there were four write `30%, 20%, 10%, 5%` note it doesn't have to be these precisely but must be formatted as such.");
            extraCrocadileHideChance = Config.Bind<string>(DraftingMod.PluginGuid + ".pelt.chances",
                "What should the chances for each crocadile entree be?",
                "25%",
                "Give me a list of percentages seperated by commas for each pelt asked for in the counts section. EX; If there were four write `30%, 20%, 10%, 5%` note it doesn't have to be these precisely but must be formatted as such.");
            
            // Handle Tribal Pelts Extensions
            if (BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey(DraftingMod.NGUID) || BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey(DraftingMod.LGUID) || BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey(DraftingMod.VGUID))
            {
	            Beaver.Config = Config;
	            Beaver.BeaverExtensionChance();
            }
            if (BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey(DraftingMod.NGUID))
            {
	            Nevernamed.Config = Config;
	            Nevernamed.NevernamedExtensionChance();
            }
            if (BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey(DraftingMod.LGUID))
            {
	            Bundle.Config = Config;
	            Bundle.BundleExtensionChance();
            }
		}
	}
}