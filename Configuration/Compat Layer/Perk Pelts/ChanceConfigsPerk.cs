using BepInEx.Configuration;
using DraftingMod.Utility;

namespace DraftingMod.Configuration.Compat_Layer.Perk_Pelts
{
	public class ChanceConfigsPerk
	{
		public static ConfigFile Config;

		// Config Vars
		public static ConfigEntry<string> extraPerkRatChance;
		public static ConfigEntry<string> extraPerkTreeChance;

		public static void Init()
		{
			extraPerkRatChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Perk", "1%", "Compat - Perk Pelts - Chance");
			extraPerkTreeChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Tree", "0.5%", "Compat - Perk Pelts - Chance");
		}
	}
}