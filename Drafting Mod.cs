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
        
        public void Awake()
        {
            CountConfigs.Config = Config;
            CountConfigs.Init();
            ChanceConfigs.Config = Config;
            ChanceConfigs.Init();
            
            harmony.PatchAll(typeof(RunstatePatches));
            harmony.PatchAll(typeof(DeckInfoPatches));
            harmony.PatchAll(typeof(MapGeneratorPatches));
            harmony.PatchAll(typeof(AscensionSaveDataPatches));
            harmony.PatchAll(typeof(AscensionStartScreenPatches));
            Logger.LogMessage($"{PluginGuid}: Loaded Mod: {PluginName} - {PluginVersion}");
        }
    }
}