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
			extraBloodVialChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Blood", "20%");
			extraBoneFossilChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Bone", "20%");
			extraEnergyCapsuleChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Energy", "20%");
			extraGemHolderChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Gem", "20%");
		}
	}
}