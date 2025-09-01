using BepInEx.Configuration;
using DraftingMod.Utility;

namespace DraftingMod.Configuration.Compat_Layer.Perk_Pelts
{
	public class CountConfigsPerk
	{
		public static ConfigFile Config;

		// Config Vars
		public static ConfigEntry<int> extraRats;
		public static ConfigEntry<int> extraTrees;

		public static void Init()
		{
			extraRats = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Perk", 1, "Compat - Perk Pelts - Count");
			extraTrees = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Tree", 1, "Compat - Perk Pelts - Count");
		}
	}
}