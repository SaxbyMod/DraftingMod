using AnsiConsolePlugin.Util;
using HarmonyLib;
using DiskCardGame;
using System.Collections.Generic;
using DraftingMod.Utility;
using System;

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

            Console.WriteLine($"{GetColorFromTypeFunctions.GetColorFromString("White", "HighIntensityBold")}If for whatever the fuck reason the following appears twice, the LATTER section is what applies to the run, in present I have no clue how to resolve this.{ANSICodeLists.ResetColor}");
            __instance = AdditionalPelts.AddAdditionalPelts(__instance);
            return false;
        }
    }
}