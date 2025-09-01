using DraftingMod.Configuration.Compat_Layer.More_Pelts;
using DraftingMod.Configuration.Compat_Layer.Tribal_Pelts;
using DraftingMod.Configuration.Compat_Layer.Tribal_Pelts.Extensions;
using DraftingMod.Configuration.Compat_Layer.Temple_Pelts;
using System.Collections.Generic;
using System.Linq;
using System;
using AnsiConsolePlugin.Util;

namespace DraftingMod.Utility
{
    public class Chance
    {
        public static List<float> GetConfigChances(string peltType)
        {
            string listStr = peltType switch
            {
                // Base
                "Hare" => Configuration.ChanceConfigs.extraHarePeltChance.Value,
                "Wolve" => Configuration.ChanceConfigs.extraWolvePeltChance.Value,
                "Gold" => Configuration.ChanceConfigs.extraGoldPeltChance.Value,
                // Tribal
                "Raven" => ChanceConfigsTribal.extraRavenEpidermisesChance.Value,
                "Coyote" => ChanceConfigsTribal.extraCoyotePeltChance.Value,
                "Moth" => ChanceConfigsTribal.extraMothMoltChance.Value,
                "Deer" => ChanceConfigsTribal.extraDeerPeltChance.Value,
                "Crocadile" => ChanceConfigsTribal.extraCrocadileHideChance.Value,
                // Tribal - Overlap
                "Beaver" => BeaverConfig.extraBeaverPeltChance.Value,
                // Tribal - Nevernameds
                "Lobster" => NevernamedConfig.extraLobsterPeltChance.Value,
                "Spider" => NevernamedConfig.extraSpiderSkinChance.Value,
                // Tribal - Bundles
                "Human" => BundleConfig.extraHumanRemainsChance.Value,
                "Shark" => BundleConfig.extraSharkLeatherChance.Value,
                "Tiger" => BundleConfig.extraTigerPeltChance.Value,
                // Tribal - Mushrooms
                "Blaster" => MushroomConfig.extraBlasterPeltChance.Value,
                "Block" => MushroomConfig.extraBlockPeltChance.Value,
                "Blooper" => MushroomConfig.extraBlooperPeltChance.Value,
                "Bob-Omb" => MushroomConfig.extraBobOmbPeltChance.Value,
                "Boo" => MushroomConfig.extraBooPeltChance.Value,
                "Chain Chomp" => MushroomConfig.extraChainChompPeltChance.Value,
                "Cheep Cheep" => MushroomConfig.extraCheepCheepPeltChance.Value,
                "Conkdor" => MushroomConfig.extraConkdorPeltChance.Value,
                "Dragon" => MushroomConfig.extraDragonPeltChance.Value,
                "Dry Bone" => MushroomConfig.extraDryBonePeltChance.Value,
                "Goomba" => MushroomConfig.extraGoombaPeltChance.Value,
                "Koopa" => MushroomConfig.extraKoopaPeltChance.Value,
                "Piranha" => MushroomConfig.extraPiranhaPeltChance.Value,
                "Pokey" => MushroomConfig.extraPokeyPeltChance.Value,
                "Power Up" => MushroomConfig.extraPowerUpPeltChance.Value,
                "Ram" => MushroomConfig.extraRamPeltChance.Value,
                "Shroob" => MushroomConfig.extraShroobPeltChance.Value,
                "Shy Guy" => MushroomConfig.extraShyGuyPeltChance.Value,
                "Spike" => MushroomConfig.extraSpikePeltChance.Value,
                "Star" => MushroomConfig.extraStarPeltChance.Value,
                "Tanuki" => MushroomConfig.extraTanukiPeltChance.Value,
                "Thwomp" => MushroomConfig.extraThwompPeltChance.Value,
                "Waddlewing" => MushroomConfig.extraWaddlewingPeltChance.Value,
                "Wiggler" => MushroomConfig.extraWigglerPeltChance.Value,
                // Temple
                "Blood" => ChanceConfigsTemple.extraBloodVialChance.Value,
                "Bone" => ChanceConfigsTemple.extraBoneFossilChance.Value,
                "Energy" => ChanceConfigsTemple.extraEnergyCapsuleChance.Value,
                "Gem" => ChanceConfigsTemple.extraGemHolderChance.Value,
                // More
                "Air" => ChanceConfigsMore.extraAirPeltChance.Value,
                "Battery" => ChanceConfigsMore.extraBatteryPeltChance.Value,
                "Bear" => ChanceConfigsMore.extraBearPeltChance.Value,
                "BeaverB" => ChanceConfigsMore.extraBeaverPeltChance.Value,
                "BoneB" => ChanceConfigsMore.extraBonePeltChance.Value,
                "Buffalo" => ChanceConfigsMore.extraBuffaloPeltChance.Value,
                "Fish" => ChanceConfigsMore.extraFishPeltChance.Value,
                "Gecko" => ChanceConfigsMore.extraGeckoPeltChance.Value,
                "Light" => ChanceConfigsMore.extraLightPeltChance.Value,
                "Mox" => ChanceConfigsMore.extraMoxPeltChance.Value,
                "RHare" => ChanceConfigsMore.extraRHarePeltChance.Value,
                "RWolve" => ChanceConfigsMore.extraRWolvePeltChance.Value,
                "RGold" => ChanceConfigsMore.extraRGoldPeltChance.Value,
                "SBattery" => ChanceConfigsMore.extraSBatteryPeltChance.Value,
                "SHare" => ChanceConfigsMore.extraSHarePeltChance.Value,
                "Wizard" => ChanceConfigsMore.extraWizardPeltChance.Value,
                _ => "",
            };

            List<float> chances = new List<float>();
            List<string> newList = listStr.Split(',').ToList();
            foreach (string percentage in newList)
            {
                string newPercentage = percentage.Replace(" ", "").Replace("%", "");
                float newNewPercentage = float.TryParse(newPercentage, out newNewPercentage) ? newNewPercentage : 0;
                float percentageCast = newNewPercentage / 100;
                chances.Add(percentageCast);
            }
            return chances;
        }

        public static bool chanceSuccessful(float percentage, string Type)
        {
            float num = UnityEngine.Random.Range(0.00f, 1.00f);
            Console.WriteLine($"{GetColorFromTypeFunctions.GetColorFromString("Green", "Underlined")}Doing RNG for {ANSICodeLists.ResetColor}{GetColorFromTypeFunctions.GetColorFromString("Cyan", "Underlined")}{Type}{ANSICodeLists.ResetColor}{GetColorFromTypeFunctions.GetColorFromString("Green", "Underlined")}; The success Percentage given was {ANSICodeLists.ResetColor}{GetColorFromTypeFunctions.GetColorFromString("Cyan", "Underlined")}{percentage}{ANSICodeLists.ResetColor}{GetColorFromTypeFunctions.GetColorFromString("Green", "Underlined")}, the Rolled value is {ANSICodeLists.ResetColor}{GetColorFromTypeFunctions.GetColorFromString("Cyan", "Underlined")}{num}{ANSICodeLists.ResetColor}{GetColorFromTypeFunctions.GetColorFromString("Green", "Underlined")}.{ANSICodeLists.ResetColor}");
            if (num <= percentage) {
                Console.WriteLine($"{GetColorFromTypeFunctions.GetColorFromString("Green", "Flashy")}The Aforementioned roll has succeeded{ANSICodeLists.ResetColor}");
            } else {
                Console.WriteLine($"{GetColorFromTypeFunctions.GetColorFromString("Red", "Flashy")}The Aforementioned roll has failed{ANSICodeLists.ResetColor}");
            }
            return num <= percentage;
        }
    }
}