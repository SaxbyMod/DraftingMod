using DraftingMod.Configuration;
using DraftingMod.Configuration.Compat_Layer.Tribal_Pelts;
using DraftingMod.Configuration.Compat_Layer.Tribal_Pelts.Extensions;
using System.Collections.Generic;
using System.Linq;
using ChanceConfigs = DraftingMod.Configuration.Compat_Layer.Tribal_Pelts.ChanceConfigs;

namespace DraftingMod.Utility
{
    public class Chance
    {
        public static List<float> GetConfigChances(string peltType)
        {
            string listStr = peltType switch
            {
                "Hare" => Configuration.ChanceConfigs.extraHareChance.Value,
                "Wolve" => Configuration.ChanceConfigs.extraWolveChance.Value,
                "Gold" => Configuration.ChanceConfigs.extraGoldChance.Value,
                "Raven" => ChanceConfigs.extraRavenEpidermisesChance.Value,
                "Coyote" => ChanceConfigs.extraCoyotePeltChance.Value,
                "Moth" => ChanceConfigs.extraMothMoltChance.Value,
                "Deer" => ChanceConfigs.extraDeerPeltChance.Value,
                "Crocadile" => ChanceConfigs.extraCrocadileHideChance.Value,
                "Beaver" => Beaver.extraBeaverPeltChance.Value,
                "Lobster" => Nevernamed.extraLobsterPeltChance.Value,
                "Spider" => Nevernamed.extraSpiderSkinChance.Value,
                "Human" => Bundle.extraHumanRemainsChance.Value,
                "Shark" => Bundle.extraSharkLeatherChance.Value,
                "Tiger" => Bundle.extraTigerPeltChance.Value,
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

        public static bool chanceSuccessful(float percentage)
        {
            float num = UnityEngine.Random.Range(0.00f, 1.00f);
            return num <= percentage;
        }
    }
}