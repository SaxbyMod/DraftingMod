using DiskCardGame;
using HarmonyLib;
using System.Collections.Generic;
using Unity.Audio;

namespace SmallTweak_Hydra.PATCHES
{
    [HarmonyPatch]
    internal static class RunstatePatches
    {
        // Patch Initializer for Deck and Items in Act 1
        [HarmonyPrefix, HarmonyPatch(typeof(RunState), nameof(RunState.InitializeStarterDeckAndItems))]
        public static bool PrefixInitializeStarterDeckAndItems(RunState __instance)
        {
            // Handles Finale Return; Base Game Code
            if (StoryEventsData.EventCompleted(StoryEvent.Part3Completed))
            {
                if (SaveManager.SaveFile.LastRun != null && SaveManager.SaveFile.LastRun.completed)
                {
                    __instance.playerDeck = SaveManager.SaveFile.LastRun.playerDeck;
                    List<CardInfo> cardsToRemove = __instance.playerDeck.Cards.FindAll((CardInfo x) => x.SpecialAbilities.Contains(SpecialTriggeredAbility.TalkingCardChooser) || x.HasAbility(Ability.RandomConsumable));
                    __instance.playerDeck.Cards.RemoveAll((CardInfo x) => cardsToRemove.Contains(x));
                    __instance.playerDeck.ClearBoons();
                }
                if (__instance.playerDeck.Cards.Count < 5)
                {
                    __instance.playerDeck = new DeckInfo();
                    __instance.playerDeck.FillWithRandomPart1Cards(3);
                }
            }
            
            // Handles if the Tutorial was Completed and based on that determines the items; Base Game Code
            else if (StoryEventsData.EventCompleted(StoryEvent.TutorialRunCompleted))
            {
                __instance.playerDeck.InitializeAsPlayerDeck();
                __instance.consumables.Add("SquirrelBottle");
                if (StoryEventsData.EventCompleted(StoryEvent.SpecialDaggerDiscovered))
                {
                    __instance.consumables.Add("SpecialDagger");
                }
                else
                {
                    __instance.consumables.Add("Pliers");
                }
                if (StoryEventsData.EventCompleted(StoryEvent.FishHookUnlocked))
                {
                    __instance.consumables.Add("FishHook");
                }
            }
            
            // Handles every run after Tutorial; Modified
            else
            {
                __instance.playerDeck.Cards.Clear();
                __instance.playerDeck.AddCard(CardLoader.GetCardByName("PeltHare"));
                __instance.playerDeck.AddCard(CardLoader.GetCardByName("PeltHare"));
                __instance.playerDeck.AddCard(CardLoader.GetCardByName("PeltHare"));
                __instance.playerDeck.AddCard(CardLoader.GetCardByName("PeltHare"));
            }
            
            // Handles TotemTops; Base Game Code
            if (StoryEventsData.EventCompleted(StoryEvent.SquirrelHeadDiscovered))
            {
                __instance.totemTops.Add(Tribe.Squirrel);
                if (StoryEventsData.EventCompleted(StoryEvent.BeeFigurineFound))
                {
                    __instance.totemTops.Add(Tribe.Insect);
                }
            }
            
            return false;
        }
        
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
            return false;
        }
    }
}