using BepInEx.Configuration;

namespace DraftingMod
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
            extraHares = Config.Bind<int>(DraftingMod.PluginGuid + ".pelt.counts",
                "How many extra hares for the entree?",
                2,
                "How many extra hares should be given for the entree?");
            extraWolves = Config.Bind<int>(DraftingMod.PluginGuid + ".pelt.counts",
                "How many extra wolves for the entree?",
                1,
                "How many extra wolves should be given for the entree?");
            extraGolds = Config.Bind<int>(DraftingMod.PluginGuid + ".pelt.counts",
                "How many extra golds for the entree?",
                1,
                "How many extra golds should be given for the entree?");
        }
    }
}