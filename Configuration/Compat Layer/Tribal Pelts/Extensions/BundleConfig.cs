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
			extraHumans = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Human", 1);
			extraSharks = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Shark", 1);
			extraTigers = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Tiger", 1);
		}
		
		public static ConfigEntry<string> extraHumanRemainsChance;
		public static ConfigEntry<string> extraSharkLeatherChance;
		public static ConfigEntry<string> extraTigerPeltChance;

		public static void BundleExtensionChance()
		{
			extraHumanRemainsChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Human", "25%");
			extraSharkLeatherChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Shark", "25%");
			extraTigerPeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Tiger", "25%");
		}
	}
}