using BepInEx;
using BepInEx.Logging;
using DraftingMod.PATCHES;
using HarmonyLib;
using BepInEx.Configuration;

namespace DraftingMod
{
    [BepInPlugin(PluginGuid, PluginName, PluginVersion)]
    [BepInDependency("cyantist.inscryption.api")]
    public class DraftingMod : BaseUnityPlugin
    {
        // --------------------------------------------------------------------------------------------------------------------------------------------------

        // These are variables that exist everywhere in the entire class.
        public const string PluginGuid = "creator.inscryption.DraftingMod";
        public const string PluginName = "Drafting Mod";
        public const string PluginVersion = "1.0.0";
        public const string PluginPrefix = "Drafting_Mod";

        // Define a Manual Log Source
        public static ManualLogSource Log = new ManualLogSource(PluginName);

        // Declare Harmony here for future Harmony patches. You'll use Harmony to patch the game's code outside of the scope of the API.
        public static Harmony harmony = new(PluginGuid);
        
        // Config Vars
        public static ConfigEntry<int> extraHares;
        public static ConfigEntry<string> extraHareChance;
        public static ConfigEntry<int> extraWolves;
        public static ConfigEntry<string> extraWolveChance;
        public static ConfigEntry<int> extraGolds;
        public static ConfigEntry<string> extraGoldChance;
        
        public void Awake()
        {
            extraHares = Config.Bind<int>(DraftingMod.PluginGuid + ".pelt.counts",
                "How many extra hares for the entree?",
                2,
                "How many extra hares should be given for the entree?");
            extraHareChance = Config.Bind<string>(DraftingMod.PluginGuid + ".pelt.chances",
                "What should the chances for each hare entree be?",
                "30%, 10%",
                "Give me a list of percentages seperated by commas for each pelt asked for in the counts section. EX; If there were four write `30%, 20%, 10%, 5%` note it doesn't have to be these precisely but must be formatted as such.");
            extraWolves = Config.Bind<int>(DraftingMod.PluginGuid + ".pelt.counts",
                "How many extra wolves for the entree?",
                1,
                "How many extra wolves should be given for the entree?");
            extraWolveChance = Config.Bind<string>(DraftingMod.PluginGuid + ".pelt.chances",
                "What should the chances for each wolve entree be?",
                "20%",
                "Give me a list of percentages seperated by commas for each pelt asked for in the counts section. EX; If there were four write `30%, 20%, 10%, 5%` note it doesn't have to be these precisely but must be formatted as such.");
            extraGolds = Config.Bind<int>(DraftingMod.PluginGuid + ".pelt.counts",
                "How many extra golds for the entree?",
                1,
                "How many extra golds should be given for the entree?");
            extraGoldChance = Config.Bind<string>(DraftingMod.PluginGuid + ".pelt.chances",
                "What should the chances for each gold entree be?",
                "5%",
                "Give me a list of percentages seperated by commas for each pelt asked for in the counts section. EX; If there were four write `30%, 20%, 10%, 5%` note it doesn't have to be these precisely but must be formatted as such.");
            
            harmony.PatchAll(typeof(RunstatePatches));
            Logger.LogMessage($"{PluginGuid}: Loaded Mod: {PluginName} - {PluginVersion}");
        }
    }
}