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
            extraHares = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Hare", 2, "Base Game - Count");
            extraWolves = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Wolve", 1, "Base Game - Count");
            extraGolds = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Gold", 1, "Base Game - Count");
            
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
            if (BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey(DraftingMod.MorePeltsGuid))
            {
                Compat_Layer.More_Pelts.CountConfigsMore.Config = Config;
                Compat_Layer.More_Pelts.CountConfigsMore.Init();
            }
        }
    }
}