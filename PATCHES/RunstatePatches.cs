using DiskCardGame;
using HarmonyLib;
using System.Collections.Generic;
using DraftingMod.Utility;
using UnityEngine;
using System;

namespace DraftingMod.PATCHES
{
    [HarmonyPatch]
    internal static class RunstatePatches
    {
        // Patch Initializer for Deck and Items in Act 1
        [HarmonyPostfix, HarmonyPatch(typeof(RunState), nameof(RunState.InitializeStarterDeckAndItems))]
        public static void PostfixInitializeStarterDeckAndItems(RunState __instance)
        {
            if (!StoryEventsData.EventCompleted(StoryEvent.TutorialRunCompleted) && !StoryEventsData.EventCompleted(StoryEvent.Part3Completed))
            {
                __instance.playerDeck.Cards.Clear();
                __instance.playerDeck.AddCard(CardLoader.GetCardByName("PeltHare"));
                __instance.playerDeck.AddCard(CardLoader.GetCardByName("PeltHare"));
                __instance.playerDeck.AddCard(CardLoader.GetCardByName("PeltHare"));
                __instance.playerDeck.AddCard(CardLoader.GetCardByName("PeltHare"));

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
			                __instance.playerDeck.AddCard(CardLoader.GetCardByName("PeltHare"));
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
			                __instance.playerDeck.AddCard(CardLoader.GetCardByName("PeltWolf"));
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
			                __instance.playerDeck.AddCard(CardLoader.GetCardByName("PeltGolden"));
		                }
	                }
                }
            }
        }
    }
}