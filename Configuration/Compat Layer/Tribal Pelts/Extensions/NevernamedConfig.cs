using BepInEx.Configuration;
using DraftingMod.Utility;

namespace DraftingMod.Configuration.Compat_Layer.Tribal_Pelts.Extensions
{
	public class NevernamedConfig
	{
		public static ConfigFile Config;
		
		public static ConfigEntry<int> extraLobsters;
		public static ConfigEntry<int> extraSpiders;
		public static void NevernamedExtensionCount()
		{
			extraLobsters = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Lobster", 1, "Compat - Tribal Pelts - Nevernameds Pelts - Count");
			extraSpiders = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Spider", 1, "Compat - Tribal Pelts - Nevernameds Pelts - Count");
		}
		
		public static ConfigEntry<string> extraLobsterPeltChance;
		public static ConfigEntry<string> extraSpiderSkinChance;
		
		public static void NevernamedExtensionChance()
		{
			extraLobsterPeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Lobster", "25%", "Compat - Tribal Pelts - Nevernameds Pelts - Chance");
			extraSpiderSkinChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Spider", "25%", "Compat - Tribal Pelts - Nevernameds Pelts - Chance");
		}
	}
}