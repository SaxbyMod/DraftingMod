using HarmonyLib;
using DiskCardGame;
using System.Collections.Generic;
using DraftingMod.Utility;

namespace DraftingMod.PATCHES
{
    public class DeckInfoPatches
    {
		// Patch Tutorial Starter Deck Maker
        [HarmonyPrefix, HarmonyPatch(typeof(DeckInfo), nameof(DeckInfo.InitializeAsPlayerDeck))]
        public static bool PrefixInitializeAsPlayerDeck(DeckInfo __instance)
        {
            if (StoryEventsData.EventCompleted(StoryEvent.CageCardDiscovered) && !StoryEventsData.EventCompleted(StoryEvent.WolfCageBroken))
            {
                __instance.AddCard(CardLoader.GetCardByName("PeltHare"));
            }
            else if (StoryEventsData.EventCompleted(StoryEvent.TalkingWolfCardDiscovered))
            {
                __instance.AddCard(CardLoader.GetCardByName("PeltHare"));
            }
            else
            {
                __instance.AddCard(CardLoader.GetCardByName("PeltHare"));
            }
            if (StoryEventsData.EventCompleted(StoryEvent.StinkbugCardDiscovered))
            {
                __instance.AddCard(CardLoader.GetCardByName("PeltHare"));
            }
            else
            {
                __instance.AddCard(CardLoader.GetCardByName("PeltHare"));
            }
            __instance.AddCard(CardLoader.GetCardByName("PeltHare"));
            __instance.AddCard(CardLoader.GetCardByName("PeltHare"));
            
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
			            __instance.AddCard(CardLoader.GetCardByName("PeltHare"));
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
			            __instance.AddCard(CardLoader.GetCardByName("PeltWolf"));
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
			            __instance.AddCard(CardLoader.GetCardByName("PeltGolden"));
		            }
	            }
            }
            return false;
        }
    }
}