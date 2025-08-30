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
	        
	        AdditionalPelts.AddAdditionalPelts(__instance.currentRun.playerDeck);
        }
    }
}