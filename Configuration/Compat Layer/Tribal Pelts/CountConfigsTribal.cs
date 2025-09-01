using BepInEx.Configuration;
using DraftingMod.Configuration.Compat_Layer.Tribal_Pelts.Extensions;
using DraftingMod.Utility;

namespace DraftingMod.Configuration.Compat_Layer.Tribal_Pelts
{
	public class CountConfigsTribal
	{
		public static ConfigFile Config;
		
		public static ConfigEntry<int> extraRavens;
		public static ConfigEntry<int> extraCoyotes;
		public static ConfigEntry<int> extraMoths;
		public static ConfigEntry<int> extraDeers;
		public static ConfigEntry<int> extraCrocadiles;

		public static void Init()
		{
			// Handle Tribal Pelts -- Base
			extraRavens = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Raven", 1, "Compat - Tribal Pelts - Base - Count");
			extraCoyotes = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Coyote", 1, "Compat - Tribal Pelts - Base - Count");
			extraMoths = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Moth", 1, "Compat - Tribal Pelts - Base - Count");
			extraDeers = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Deer", 1, "Compat - Tribal Pelts - Base - Count");
			extraCrocadiles = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Crocadile", 1, "Compat - Tribal Pelts - Base - Count");
			
			// Handle Tribal Pelts Extensions
			if (BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey(DraftingMod.NevernamedsSigilariumGuid) || BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey(DraftingMod.BundleOfTotemsGuid) || BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey(DraftingMod.VerminTribeGuid))
			{
				BeaverConfig.Config = Config;
				BeaverConfig.BeaverExtensionCount();
			}
			if (BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey(DraftingMod.NevernamedsSigilariumGuid))
			{
				NevernamedConfig.Config = Config;
				NevernamedConfig.NevernamedExtensionCount();
			}
			if (BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey(DraftingMod.BundleOfTotemsGuid))
			{
				BundleConfig.Config = Config;
				BundleConfig.BundleExtensionCount();
			}
			if (BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey(DraftingMod.MushroomTribesGuid))
			{
				MushroomConfig.Config = Config;
				MushroomConfig.MushroomExtensionCount();
			}
		}
	}
}