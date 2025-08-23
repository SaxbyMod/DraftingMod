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
                "Hare" => DraftingMod.extraHareChance.Value,
                "Wolve" => DraftingMod.extraWolveChance.Value,
                "Gold" => DraftingMod.extraGoldChance.Value,
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