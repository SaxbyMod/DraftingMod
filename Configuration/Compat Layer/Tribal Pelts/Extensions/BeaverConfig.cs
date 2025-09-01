using BepInEx.Configuration;
using DraftingMod.Utility;

namespace DraftingMod.Configuration.Compat_Layer.Tribal_Pelts.Extensions
{
	public class BeaverConfig
	{
		public static ConfigFile Config;
		
		public static ConfigEntry<int> extraBeavers;
		
		public static void BeaverExtensionCount()
		{
			extraBeavers = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Beaver", 1, "Compat - Tribal Pelts - Beaver Pelt - Count");
		}
		
		public static ConfigEntry<string> extraBeaverPeltChance;
		
		public static void BeaverExtensionChance()
		{
			extraBeaverPeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Beaver", "25%", "Compat - Tribal Pelts - Beaver Pelt - Chance");
		}
	}
}