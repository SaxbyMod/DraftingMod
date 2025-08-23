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

                List<float> chancesHares = Chance.GetConfigChances("Hare");
                List<float> chancesWolves = Chance.GetConfigChances("Wolve");
                List<float> chancesGolds = Chance.GetConfigChances("Gold");

                if (chancesHares.Count < DraftingMod.extraHares.Value)
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
                if (chancesWolves.Count < DraftingMod.extraWolves.Value)
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
                if (chancesGolds.Count < DraftingMod.extraGolds.Value)
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
            
            List<float> chancesHares = Chance.GetConfigChances("Hare");
            List<float> chancesWolves = Chance.GetConfigChances("Wolve");
            List<float> chancesGolds = Chance.GetConfigChances("Gold");

            if (chancesHares.Count < DraftingMod.extraHares.Value)
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
            if (chancesWolves.Count < DraftingMod.extraWolves.Value)
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
            if (chancesGolds.Count < DraftingMod.extraGolds.Value)
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
        
        // Check if we can Force the sucker
        private static bool ForceFirstNodeTraderForAscension(int rowIndex)
        {
	        return SaveFile.IsAscension && rowIndex == 1 && RunState.Run.regionTier == 0 && AscensionSaveData.Data.numRunsSinceReachedFirstBoss < 2;
        }
        private static bool ForceFirstNodeTrader(int rowIndex)
        {
	        return rowIndex == 1 && RunState.Run.regionTier == 0;
        }
        
        // FUCKING PUT A TRADER AT THE START OF MY RUNNNNNNNN!!!!!!!!!!!!
        [HarmonyPrefix, HarmonyPatch(typeof(MapGenerator), nameof(MapGenerator.CreateNode))]
        public static bool PrefixCreateCard(int x, int y, List<NodeData> nodesInRow, List<NodeData> previousNodes, int mapLength, MapGenerator __instance, ref NodeData __result)
        {
			NodeData nodeData = null;
			if (y == 0)
			{
				nodeData = new NodeData();
			}
			else if ((!(y + 2 == mapLength) && SaveFile.IsAscension && y % 3 == 0) || y + 1 == mapLength)
			{
				if (y + 1 == mapLength)
				{
					nodeData = new BossBattleNodeData();
					(nodeData as BossBattleNodeData).bossType = RunState.CurrentMapRegion.bosses[UnityEngine.Random.Range(0, RunState.CurrentMapRegion.bosses.Count)];
					(nodeData as BossBattleNodeData).specialBattleId = BossBattleSequencer.GetSequencerIdForBoss((nodeData as BossBattleNodeData).bossType);
				}
				else if (nodesInRow.Exists((NodeData n) => n is CardBattleNodeData) || AscensionSaveData.Data.ChallengeIsActive(AscensionChallenge.AllTotems))
				{
					nodeData = new TotemBattleNodeData();
				}
				else
				{
					nodeData = new CardBattleNodeData();
				}
				(nodeData as CardBattleNodeData).difficulty = RunState.Run.regionTier * 6 + (y + 1) / 3 - 1;
			}
			else if (!(y + 2 == mapLength) && SaveFile.IsAscension && y % 3 == 1)
			{
				if (ForceFirstNodeTraderForAscension(y))
				{
					nodeData = new TradePeltsNodeData();
				}
				else if (UnityEngine.Random.value < ((RunState.CurrentRegionTier > 1) ? 0.66f : 0.33f))
				{
					nodeData = MapGenerator.ChooseSpecialNodeFromPossibilities(new List<NodeData>
					{
						new BuyPeltsNodeData(),
						new TradePeltsNodeData(),
						new DeckTrialNodeData(),
						new BoulderChoiceNodeData()
					}, y, previousNodes, nodesInRow);
				}
				if (nodeData == null)
				{
					nodeData = new CardChoicesNodeData();
					if (nodesInRow.Exists((NodeData n) => n is CardChoicesNodeData && (n as CardChoicesNodeData).choicesType == CardChoicesType.Random))
					{
						List<CardChoicesType> list = new List<CardChoicesType>();
						if (!nodesInRow.Exists((NodeData n) => n is CardChoicesNodeData && (n as CardChoicesNodeData).choicesType == CardChoicesType.Cost))
						{
							list.Add(CardChoicesType.Cost);
						}
						if (!nodesInRow.Exists((NodeData n) => n is CardChoicesNodeData && (n as CardChoicesNodeData).choicesType == CardChoicesType.Tribe) && MapGenerator.TribeBasedChoiceUnlocked)
						{
							list.Add(CardChoicesType.Tribe);
						}
						if (!nodesInRow.Exists((NodeData n) => n is CardChoicesNodeData && (n as CardChoicesNodeData).choicesType == CardChoicesType.Deathcard))
						{
							if (!previousNodes.Exists((NodeData n) => n is CardChoicesNodeData && (n as CardChoicesNodeData).choicesType == CardChoicesType.Deathcard) && SaveManager.SaveFile.GetChoosableDeathcardMods().Count >= 9)
							{
								list.Add(CardChoicesType.Deathcard);
							}
						}
						if (list.Count > 0)
						{
							(nodeData as CardChoicesNodeData).choicesType = list[UnityEngine.Random.Range(0, list.Count)];
						}
					}
				}
			}
			else
			{
				if (ForceFirstNodeTrader(y))
				{
					nodeData = new TradePeltsNodeData();
				}
				else
				{
					nodeData = MapGenerator.ChooseSpecialNodeFromPossibilities(new List<NodeData>
					{
						new CardMergeNodeData(),
						new GainConsumablesNodeData(),
						new BuildTotemNodeData(),
						new DuplicateMergeNodeData(),
						new CardRemoveNodeData(),
						new CardStatBoostNodeData(),
						new CopyCardNodeData()
					}, y, previousNodes, nodesInRow);
				}
			} 
			if (nodeData == null)
			{
				nodeData = new CardChoicesNodeData();
			}
			nodeData.gridX = x;
			nodeData.gridY = y;
			nodeData.id = MapGenerator.GetNewID();
			__result = nodeData;
			return false;
        }
        
        // Patch the Ascension deck RQ
        [HarmonyPrefix, HarmonyPatch(typeof(AscensionSaveData), nameof(AscensionSaveData.NewRun))]
        public static bool PrefixNewRun(List<CardInfo> starterDeck, AscensionSaveData __instance)
        {
			// Base Game Code;
	        __instance.currentRunSeed = Environment.TickCount;
	        __instance.currentOuroborosDeaths = 0;
	        __instance.currentRun = new RunState();
	        __instance.currentRun.Initialize();
	        __instance.RollCurrentRunRegionOrder();
	        __instance.oilPaintingState.TryAdvanceRewardIndex();
	        __instance.oilPaintingState.puzzleSolution = OilPaintingPuzzle.GenerateSolution(true);
	        __instance.currentRun.playerDeck = new DeckInfo();
	        
	        // Drafting Mod Stuff
	        __instance.currentRun.playerDeck.AddCard(CardLoader.GetCardByName("PeltHare"));
	        __instance.currentRun.playerDeck.AddCard(CardLoader.GetCardByName("PeltHare"));
	        __instance.currentRun.playerDeck.AddCard(CardLoader.GetCardByName("PeltHare"));
	        __instance.currentRun.playerDeck.AddCard(CardLoader.GetCardByName("PeltHare"));
	        
	        List<float> chancesHares = Chance.GetConfigChances("Hare");
	        List<float> chancesWolves = Chance.GetConfigChances("Wolve");
	        List<float> chancesGolds = Chance.GetConfigChances("Gold");

	        if (chancesHares.Count < DraftingMod.extraHares.Value)
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
	        if (chancesWolves.Count < DraftingMod.extraWolves.Value)
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
	        if (chancesGolds.Count < DraftingMod.extraGolds.Value)
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
	        
	        // Items; Base Game
	        __instance.currentRun.consumables.Add("SquirrelBottle");
	        if (__instance.GetNumChallengesOfTypeActive(AscensionChallenge.LessConsumables) < 2)
	        {
		        __instance.currentRun.consumables.Add("Pliers");
	        }
	        if (!__instance.ChallengeIsActive(AscensionChallenge.NoHook))
	        {
		        if (__instance.currentRun.consumables.Count == __instance.currentRun.MaxConsumables)
		        {
			        __instance.currentRun.consumables.RemoveAt(__instance.currentRun.consumables.Count - 1);
		        }
		        __instance.currentRun.consumables.Add("FishHook");
	        }
	        if (__instance.ChallengeIsActive(AscensionChallenge.LessLives))
	        {
		        __instance.currentRun.maxPlayerLives = (__instance.currentRun.playerLives = 1);
	        }

	        return false;
        }
        
        // Modified NewRunSelected
        private static void OnNewRunSelected(AscensionStartScreen __instance)
        {
	        CommandLineTextDisplayer.PlayCommandLineClickSound();
	        if (__instance.RunExists)
	        {
		        Singleton<AscensionMenuScreens>.Instance.SwitchToScreen(AscensionMenuScreens.Screen.NewRunConfirm);
		        __instance.newRunConfirmButton.screenToReturnTo = AscensionMenuScreens.Screen.SelectChallenges;
	        }
	        else
	        {
		        Singleton<AscensionMenuScreens>.Instance.SwitchToScreen(AscensionMenuScreens.Screen.SelectChallenges);
	        }
        }
        
        // Patch the Ascension starterdeck screen
        [HarmonyPostfix, HarmonyPatch(typeof(AscensionMenuScreens), nameof(AscensionMenuScreens.Start))]
        public static bool PrefixOnNewRunSelected(AscensionStartScreen __instance)
        {
		        AscensionMenuInteractable ascensionMenuInteractable = __instance.newRunText;
			ascensionMenuInteractable.CursorSelectStarted = (Action<MainInputInteractable>)Delegate.Combine(ascensionMenuInteractable.CursorSelectStarted, new Action<MainInputInteractable>(delegate(MainInputInteractable i)
			{
				OnNewRunSelected(__instance);
			}));
			AscensionMenuInteractable ascensionMenuInteractable2 = __instance.continueRunText;
			ascensionMenuInteractable2.CursorSelectStarted = (Action<MainInputInteractable>)Delegate.Combine(ascensionMenuInteractable2.CursorSelectStarted, new Action<MainInputInteractable>(delegate(MainInputInteractable i)
			{
				__instance.OnContinueSelected();
			}));
			AscensionMenuInteractable ascensionMenuInteractable3 = __instance.statsText;
			ascensionMenuInteractable3.CursorSelectStarted = (Action<MainInputInteractable>)Delegate.Combine(ascensionMenuInteractable3.CursorSelectStarted, new Action<MainInputInteractable>(delegate(MainInputInteractable i)
			{
				__instance.OnStatsSelected();
			}));
			AscensionMenuInteractable ascensionMenuInteractable4 = __instance.unlocksText;
			ascensionMenuInteractable4.CursorSelectStarted = (Action<MainInputInteractable>)Delegate.Combine(ascensionMenuInteractable4.CursorSelectStarted, new Action<MainInputInteractable>(delegate(MainInputInteractable i)
			{
				__instance.OnUnlocksSelected();
			}));
			AscensionMenuInteractable ascensionMenuInteractable5 = __instance.exitText;
			ascensionMenuInteractable5.CursorSelectStarted = (Action<MainInputInteractable>)Delegate.Combine(ascensionMenuInteractable5.CursorSelectStarted, new Action<MainInputInteractable>(delegate(MainInputInteractable i)
			{
				__instance.OnExitSelected();
			}));
			AscensionMenuInteractable ascensionMenuInteractable6 = __instance.quitAppText;
			ascensionMenuInteractable6.CursorSelectStarted = (Action<MainInputInteractable>)Delegate.Combine(ascensionMenuInteractable6.CursorSelectStarted, new Action<MainInputInteractable>(delegate(MainInputInteractable i)
			{
				__instance.OnQuitAppSelected();
			}));
			__instance.UpdateChallengeLevelText();
			return false;
        }
    }
}