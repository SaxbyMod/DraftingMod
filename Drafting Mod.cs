using AnsiConsolePlugin.Util;
using BepInEx;
using BepInEx.Logging;
using DraftingMod.PATCHES;
using DraftingMod.Configuration;
using DraftingMod.Utility;
using HarmonyLib;
using System;

namespace DraftingMod
{
    [BepInPlugin(PluginGuid, PluginName, PluginVersion)]
    [BepInDependency("cyantist.inscryption.api")]
    [BepInDependency(TribalPeltsGuid, BepInDependency.DependencyFlags.SoftDependency)]
    [BepInDependency(TemplePeltsGuid, BepInDependency.DependencyFlags.SoftDependency)]
    [BepInDependency(MorePeltsGuid, BepInDependency.DependencyFlags.SoftDependency)]
    public class DraftingMod : BaseUnityPlugin
    {
        public const string PluginGuid = "creator.inscryption.DraftingMod";
        public const string PluginName = "Drafting Mod";
        public const string PluginVersion = "1.1.0";
        public const string PluginPrefix = "Drafting_Mod";
        
        public const string TribalPeltsGuid = "creator.TribalPelts";
        public const string NevernamedsSigilariumGuid = "nevernamed.inscryption.sigils";
        public const string VerminTribeGuid = "extraVoid.inscryption.VerminTribe";
        public const string BundleOfTotemsGuid = "Lily.BOT";
        public const string MushroomTribesGuid = "mushroom.pelts";
        public const string TemplePeltsGuid = "creator.CostPelts";
        public const string MorePeltsGuid = "jamesgames.inscryption.morepelts";

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
            Logger.LogMessage($"{GetColorFromTypeFunctions.GetColorFromString("Green", "Bold")}{PluginGuid}: Loaded Mod: {PluginName} - {PluginVersion}{ANSICodeLists.ResetColor}");
        }
    }
}