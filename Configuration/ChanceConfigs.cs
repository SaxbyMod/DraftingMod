using BepInEx.Configuration;
using DraftingMod.Utility;

namespace DraftingMod.Configuration
{
    public static class ChanceConfigs
    {
        public static ConfigFile Config;
        
        // Config Vars
        public static ConfigEntry<string> extraHarePeltChance;
        public static ConfigEntry<string> extraWolvePeltChance;
        public static ConfigEntry<string> extraGoldPeltChance;
        
        public static void Init()
        {
            // Base
            extraHarePeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Hare", "30%, 10%", "Base Game - Chance");
            extraWolvePeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Wolve", "10%", "Base Game - Chance");
            extraGoldPeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Gold", "5%", "Base Game - Chance");
            
            // Compatibility Sections
            if (BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey(DraftingMod.TribalPeltsGuid))
            {
                Compat_Layer.Tribal_Pelts.ChanceConfigsTribal.Config = Config;
                Compat_Layer.Tribal_Pelts.ChanceConfigsTribal.Init();
            }
            if (BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey(DraftingMod.TemplePeltsGuid))
            {
                Compat_Layer.Temple_Pelts.ChanceConfigsTemple.Config = Config;
                Compat_Layer.Temple_Pelts.ChanceConfigsTemple.Init();
            }
            if (BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey(DraftingMod.MorePeltsGuid))
            {
                Compat_Layer.More_Pelts.ChanceConfigsMore.Config = Config;
                Compat_Layer.More_Pelts.ChanceConfigsMore.Init();
            }
            if (BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey(DraftingMod.PerkPeltsGuid))
            {
                Compat_Layer.Perk_Pelts.ChanceConfigsPerk.Config = Config;
                Compat_Layer.Perk_Pelts.ChanceConfigsPerk.Init();
            }
        }
    }
}