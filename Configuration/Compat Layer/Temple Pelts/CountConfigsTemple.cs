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
			extraBloods = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Blood", 1);
			extraBones = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Bone", 1);
			extraEnergys = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Energy", 1);
			extraGems = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Gem", 1);
            
			// Compatibility Sections
			if (BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey(DraftingMod.TribalPeltsGuid))
			{
				Compat_Layer.Tribal_Pelts.CountConfigsTribal.Config = Config;
				Compat_Layer.Tribal_Pelts.CountConfigsTribal.Init();
			}
		}
	}
}