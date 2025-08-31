using BepInEx.Configuration;
using DraftingMod.Utility;

namespace DraftingMod.Configuration
{
    public static class CountConfigs
    {
        public static ConfigFile Config;
        
        // Config Vars
        public static ConfigEntry<int> extraHares;
        public static ConfigEntry<int> extraWolves;
        public static ConfigEntry<int> extraGolds;
        
        public static void Init()
        {
            // Base
            extraHares = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Hare", 2);
            extraWolves = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Wolve", 1);
            extraGolds = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Gold", 1);
            
            // Compatibility Sections
            if (BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey(DraftingMod.TribalPeltsGuid))
            {
                Compat_Layer.Tribal_Pelts.CountConfigsTribal.Config = Config;
                Compat_Layer.Tribal_Pelts.CountConfigsTribal.Init();
            }
            if (BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey(DraftingMod.TemplePeltsGuid))
            {
                Compat_Layer.Temple_Pelts.CountConfigsTemple.Config = Config;
                Compat_Layer.Temple_Pelts.CountConfigsTemple.Init();
            }
        }
    }
}