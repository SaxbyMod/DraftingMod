using AnsiConsolePlugin.Util;
using DiskCardGame;
using HarmonyLib;
using System.Collections.Generic;
using DraftingMod.Utility;
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

                Console.WriteLine($"{GetColorFromTypeFunctions.GetColorFromString("White", "HighIntensityBold")}If for whatever the fuck reason the following appears twice, the LATTER section is what applies to the run, in present I have no clue how to resolve this.{ANSICodeLists.ResetColor}");
                __instance.playerDeck = AdditionalPelts.AddAdditionalPelts(__instance.playerDeck);
            }
        }
    }
}