using DraftingMod.Configuration.Compat_Layer.Tribal_Pelts;
using DraftingMod.Configuration.Compat_Layer.Tribal_Pelts.Extensions;
using DraftingMod.Configuration.Compat_Layer.Temple_Pelts;
using System.Collections.Generic;
using System.Linq;
using System;

namespace DraftingMod.Utility
{
    public class Chance
    {
        public static List<float> GetConfigChances(string peltType)
        {
            string listStr = peltType switch
            {
                "Hare" => Configuration.ChanceConfigs.extraHarePeltChance.Value,
                "Wolve" => Configuration.ChanceConfigs.extraWolvePeltChance.Value,
                "Gold" => Configuration.ChanceConfigs.extraGoldPeltChance.Value,
                "Raven" => ChanceConfigsTribal.extraRavenEpidermisesChance.Value,
                "Coyote" => ChanceConfigsTribal.extraCoyotePeltChance.Value,
                "Moth" => ChanceConfigsTribal.extraMothMoltChance.Value,
                "Deer" => ChanceConfigsTribal.extraDeerPeltChance.Value,
                "Crocadile" => ChanceConfigsTribal.extraCrocadileHideChance.Value,
                "Beaver" => BeaverConfig.extraBeaverPeltChance.Value,
                "Lobster" => NevernamedConfig.extraLobsterPeltChance.Value,
                "Spider" => NevernamedConfig.extraSpiderSkinChance.Value,
                "Human" => BundleConfig.extraHumanRemainsChance.Value,
                "Shark" => BundleConfig.extraSharkLeatherChance.Value,
                "Tiger" => BundleConfig.extraTigerPeltChance.Value,
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
                "Blood" => ChanceConfigsTemple.extraBloodVialChance.Value,
                "Bone" => ChanceConfigsTemple.extraBoneFossilChance.Value,
                "Energy" => ChanceConfigsTemple.extraEnergyCapsuleChance.Value,
                "Gem" => ChanceConfigsTemple.extraGemHolderChance.Value,
                _ => "",
            };

            List<float> chances = new List<float>();
            List<string> newList = listStr.Split(',').ToList();
            foreach (string percentage in newList)
            {
                string newPercentage = percentage.Replace(" ", "").Replace("%", "");
                int newNewPercentage = int.TryParse(newPercentage, out newNewPercentage) ? newNewPercentage : 0;
                float percentageCast = (float)newNewPercentage / 100;
                chances.Add(percentageCast);
            }
            return chances;
        }

        public static bool chanceSuccessful(float percentage, string Type)
        {
            float num = UnityEngine.Random.Range(0.00f, 1.00f);
            Console.WriteLine($"Doing RNG for {Type}; The success Percentage given was {percentage}, the Rolled value is {num}.");
            if (num <= percentage) {
                Console.WriteLine("The Aforementioned roll has succeeded");
            } else {
                Console.WriteLine("The Aforementioned roll has failed");
            }
            return num <= percentage;
        }
    }
}