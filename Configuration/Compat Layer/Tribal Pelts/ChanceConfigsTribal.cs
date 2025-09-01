using BepInEx.Configuration;
using DraftingMod.Configuration.Compat_Layer.Tribal_Pelts.Extensions;
using DraftingMod.Utility;

namespace DraftingMod.Configuration.Compat_Layer.Tribal_Pelts
{
	public class ChanceConfigsTribal
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
			extraRavenEpidermisesChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Raven", "25%", "Compat - Tribal Pelts - Base - Chance");
			extraCoyotePeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Coyote", "25%", "Compat - Tribal Pelts - Base - Chance");
			extraMothMoltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Moth", "25%", "Compat - Tribal Pelts - Base - Chance");
			extraDeerPeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Deer", "25%", "Compat - Tribal Pelts - Base - Chance");
			extraCrocadileHideChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Crocadile", "25%", "Compat - Tribal Pelts - Base - Chance");
            
            // Handle Tribal Pelts Extensions
            if (BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey(DraftingMod.NevernamedsSigilariumGuid) || BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey(DraftingMod.BundleOfTotemsGuid) || BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey(DraftingMod.VerminTribeGuid))
            {
	            BeaverConfig.Config = Config;
	            BeaverConfig.BeaverExtensionChance();
            }
            if (BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey(DraftingMod.NevernamedsSigilariumGuid))
            {
	            NevernamedConfig.Config = Config;
	            NevernamedConfig.NevernamedExtensionChance();
            }
            if (BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey(DraftingMod.BundleOfTotemsGuid))
            {
	            BundleConfig.Config = Config;
	            BundleConfig.BundleExtensionChance();
            }
            if (BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey(DraftingMod.MushroomTribesGuid))
            {
	            MushroomConfig.Config = Config;
	            MushroomConfig.MushroomExtensionChance();
            }
		}
	}
}