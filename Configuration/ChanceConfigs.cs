using BepInEx.Configuration;
using DraftingMod.Compat_Layer;

namespace DraftingMod
{
    public static class ChanceConfigs
    {
        public static ConfigFile Config;
        
        // Config Vars
        public static ConfigEntry<string> extraHareChance;
        public static ConfigEntry<string> extraWolveChance;
        public static ConfigEntry<string> extraGoldChance;
        
        public static void Init()
        {
            // Base
            extraHareChance = Config.Bind<string>(DraftingMod.PluginGuid + ".pelt.chances",
                "What should the chances for each hare entree be?",
                "30%, 10%",
                "Give me a list of percentages seperated by commas for each pelt asked for in the counts section. EX; If there were four write `30%, 20%, 10%, 5%` note it doesn't have to be these precisely but must be formatted as such.");
            extraWolveChance = Config.Bind<string>(DraftingMod.PluginGuid + ".pelt.chances",
                "What should the chances for each wolve entree be?",
                "20%",
                "Give me a list of percentages seperated by commas for each pelt asked for in the counts section. EX; If there were four write `30%, 20%, 10%, 5%` note it doesn't have to be these precisely but must be formatted as such.");
            extraGoldChance = Config.Bind<string>(DraftingMod.PluginGuid + ".pelt.chances",
                "What should the chances for each gold entree be?",
                "5%",
                "Give me a list of percentages seperated by commas for each pelt asked for in the counts section. EX; If there were four write `30%, 20%, 10%, 5%` note it doesn't have to be these precisely but must be formatted as such.");
            // Compatibility Sections
            if (BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey(DraftingMod.TribalPeltsPrefix))
            {
                TribalPeltsChanceConfigs.Config = Config;
                DraftingMod.Log.LogMessage("Do I see The other DLL? I do, I do see the other DLL! (Tribal Pelts)");
                TribalPeltsChanceConfigs.Init();
            }
        }
    }
}