using DraftingMod.Compat_Layer;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DraftingMod.Utility
{
    public class Chance
    {
        public static List<float> GetConfigChances(string peltType)
        {
            string listStr = peltType switch
            {
                "Hare" => ChanceConfigs.extraHareChance.Value,
                "Wolve" => ChanceConfigs.extraWolveChance.Value,
                "Gold" => ChanceConfigs.extraGoldChance.Value,
                "Raven" => TribalPeltsChanceConfigs.extraRavenEpidermisesChance.Value,
                "Coyote" => TribalPeltsChanceConfigs.extraCoyotePeltChance.Value,
                "Moth" => TribalPeltsChanceConfigs.extraMothMoltChance.Value,
                "Deer" => TribalPeltsChanceConfigs.extraDeerPeltChance.Value,
                "Crocadile" => TribalPeltsChanceConfigs.extraCrocadileHideChance.Value,
                _ => ""
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