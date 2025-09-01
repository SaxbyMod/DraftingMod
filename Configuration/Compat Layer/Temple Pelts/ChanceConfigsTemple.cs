using BepInEx.Configuration;
using DraftingMod.Utility;

namespace DraftingMod.Configuration.Compat_Layer.Temple_Pelts
{
	public class ChanceConfigsTemple
	{
		public static ConfigFile Config;
        
		// Config Vars
		public static ConfigEntry<string> extraBloodVialChance;
		public static ConfigEntry<string> extraBoneFossilChance;
		public static ConfigEntry<string> extraEnergyCapsuleChance;
		public static ConfigEntry<string> extraGemHolderChance;
        
		public static void Init()
		{
			// Base
			extraBloodVialChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Blood", "10%", "Compat - Temple Pelts - Base - Chance");
			extraBoneFossilChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Bone", "10%", "Compat - Temple Pelts - Base - Chance");
			extraEnergyCapsuleChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Energy", "", "Compat - Temple Pelts - Base - Chance");
			extraGemHolderChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Gem", "", "Compat - Temple Pelts - Base - Chance");
		}
	}
}