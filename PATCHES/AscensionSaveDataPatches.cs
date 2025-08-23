using HarmonyLib;
using DiskCardGame;
using System.Collections.Generic;
using DraftingMod.Utility;

namespace DraftingMod.PATCHES
{
    public class AscensionSaveDataPatches
    {
		// Patch the Ascension deck RQ
        [HarmonyPostfix, HarmonyPatch(typeof(AscensionSaveData), nameof(AscensionSaveData.NewRun))]
        public static void PostfixNewRun(List<CardInfo> starterDeck, AscensionSaveData __instance)
        {
	        __instance.currentRun.playerDeck = new DeckInfo();
	        __instance.currentRun.playerDeck.AddCard(CardLoader.GetCardByName("PeltHare"));
	        __instance.currentRun.playerDeck.AddCard(CardLoader.GetCardByName("PeltHare"));
	        __instance.currentRun.playerDeck.AddCard(CardLoader.GetCardByName("PeltHare"));
	        __instance.currentRun.playerDeck.AddCard(CardLoader.GetCardByName("PeltHare"));
	        
	        List<float> chancesHares = Chance.GetConfigChances("Hare");
	        List<float> chancesWolves = Chance.GetConfigChances("Wolve");
	        List<float> chancesGolds = Chance.GetConfigChances("Gold");

	        if (chancesHares.Count < CountConfigs.extraHares.Value)
	        {
		        DraftingMod.Log.LogError("Error; not enough percentages provided for Hares");
	        }
	        else
	        {
		        foreach (float chance in chancesHares)
		        {
			        if (Chance.chanceSuccessful(chance))
			        {
				        __instance.currentRun.playerDeck.AddCard(CardLoader.GetCardByName("PeltHare"));
			        }
		        }
	        }
	        if (chancesWolves.Count < CountConfigs.extraWolves.Value)
	        {
		        DraftingMod.Log.LogError("Error; not enough percentages provided for Wolves");
	        }
	        else
	        {
		        foreach (float chance in chancesWolves)
		        {
			        if (Chance.chanceSuccessful(chance))
			        {
				        __instance.currentRun.playerDeck.AddCard(CardLoader.GetCardByName("PeltWolf"));
			        }
		        }
	        }
	        if (chancesGolds.Count < CountConfigs.extraGolds.Value)
	        {
		        DraftingMod.Log.LogError("Error; not enough percentages provided for Golds");
	        }
	        else
	        {
		        foreach (float chance in chancesGolds)
		        {
			        if (Chance.chanceSuccessful(chance))
			        {
				        __instance.currentRun.playerDeck.AddCard(CardLoader.GetCardByName("PeltGolden"));
			        }
		        }
	        }
        }
    }
}