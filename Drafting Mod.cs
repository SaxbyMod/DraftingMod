using BepInEx;
using BepInEx.Logging;
using DraftingMod.PATCHES;
using DraftingMod.Configuration;
using HarmonyLib;

namespace DraftingMod
{
    [BepInPlugin(PluginGuid, PluginName, PluginVersion)]
    [BepInDependency("cyantist.inscryption.api")]
    [BepInDependency("creator.TribalPelts", BepInDependency.DependencyFlags.SoftDependency)]
    public class DraftingMod : BaseUnityPlugin
    {
        public const string PluginGuid = "creator.inscryption.DraftingMod";
        public const string PluginName = "Drafting Mod";
        public const string PluginVersion = "1.1.0";
        public const string PluginPrefix = "Drafting_Mod";
        
        public const string TribalPeltsPrefix = "creator.TribalPelts";
        public const string NGUID = "nevernamed.inscryption.sigils";
        public const string VGUID = "extraVoid.inscryption.VerminTribe";
        public const string LGUID = "Lily.BOT";
        public const string MGUID = "mushroom.pelts";

        // Define a Manual Log Source
        public static ManualLogSource Log = new ManualLogSource(PluginName);

        // Declare Harmony here for future Harmony patches. You'll use Harmony to patch the game's code outside of the scope of the API.
        public static Harmony Harmony = new(PluginGuid);
        
        public void Awake()
        {
            CountConfigs.Config = Config;
            CountConfigs.Init();
            ChanceConfigs.Config = Config;
            ChanceConfigs.Init();
            
            Harmony.PatchAll(typeof(RunstatePatches));
            Harmony.PatchAll(typeof(DeckInfoPatches));
            Harmony.PatchAll(typeof(MapGeneratorPatches));
            Harmony.PatchAll(typeof(AscensionSaveDataPatches));
            Harmony.PatchAll(typeof(AscensionStartScreenPatches));
            Logger.LogMessage($"{PluginGuid}: Loaded Mod: {PluginName} - {PluginVersion}");
        }
    }
}