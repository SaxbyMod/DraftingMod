using AnsiConsolePlugin.Util;
using HarmonyLib;
using DiskCardGame;
using System.Collections.Generic;
using DraftingMod.Utility;
using System;

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
	        
	        Console.WriteLine($"{GetColorFromTypeFunctions.GetColorFromString("White", "HighIntensityBold")}If for whatever the fuck reason the following appears twice, the LATTER section is what applies to the run, in present I have no clue how to resolve this.{ANSICodeLists.ResetColor}");
	        __instance.currentRun.playerDeck = AdditionalPelts.AddAdditionalPelts(__instance.currentRun.playerDeck);
        }
    }
}