using BepInEx.Configuration;
using DraftingMod.Utility;

namespace DraftingMod.Configuration.Compat_Layer.Temple_Pelts
{
	public class CountConfigsTemple
	{
		public static ConfigFile Config;
        
		// Config Vars
		public static ConfigEntry<int> extraBloods;
		public static ConfigEntry<int> extraBones;
		public static ConfigEntry<int> extraEnergys;
		public static ConfigEntry<int> extraGems;
        
		public static void Init()
		{
			// Base
			extraBloods = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Blood", 1, "Compat - Temple Pelts - Base - Count");
			extraBones = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Bone", 1, "Compat - Temple Pelts - Base - Count");
			extraEnergys = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Energy", 0, "Compat - Temple Pelts - Base - Count");
			extraGems = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Gem", 0, "Compat - Temple Pelts - Base - Count");
            
			// Compatibility Sections
			if (BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey(DraftingMod.TribalPeltsGuid))
			{
				Compat_Layer.Tribal_Pelts.CountConfigsTribal.Config = Config;
				Compat_Layer.Tribal_Pelts.CountConfigsTribal.Init();
			}
		}
	}
}