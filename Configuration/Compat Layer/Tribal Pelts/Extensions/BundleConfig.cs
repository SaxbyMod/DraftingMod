using BepInEx.Configuration;
using DraftingMod.Utility;

namespace DraftingMod.Configuration.Compat_Layer.Tribal_Pelts.Extensions
{
	public class BundleConfig
	{
		public static ConfigFile Config;
		
		public static ConfigEntry<int> extraHumans;
		public static ConfigEntry<int> extraSharks;
		public static ConfigEntry<int> extraTigers;
		
		public static void BundleExtensionCount()
		{
			extraHumans = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Human", 1, "Compat - Tribal Pelts - Bundle Pelts - Count");
			extraSharks = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Shark", 1, "Compat - Tribal Pelts - Bundle Pelts - Count");
			extraTigers = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Tiger", 1, "Compat - Tribal Pelts - Bundle Pelts - Count");
		}
		
		public static ConfigEntry<string> extraHumanRemainsChance;
		public static ConfigEntry<string> extraSharkLeatherChance;
		public static ConfigEntry<string> extraTigerPeltChance;

		public static void BundleExtensionChance()
		{
			extraHumanRemainsChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Human", "25%", "Compat - Tribal Pelts - Bundle Pelts - Chance");
			extraSharkLeatherChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Shark", "25%", "Compat - Tribal Pelts - Bundle Pelts - Chance");
			extraTigerPeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Tiger", "25%", "Compat - Tribal Pelts - Bundle Pelts - Chance");
		}
	}
}