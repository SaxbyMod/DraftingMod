using DiskCardGame;
using System.Collections.Generic;
using DraftingMod.Configuration.Compat_Layer.More_Pelts;
using System;

namespace DraftingMod.Utility.Compat_Layer.More_Pelts
{
	public class AdditionalPeltsMore
	{
		public static DeckInfo MorePelts(DeckInfo deckInfo)
		{
			List<float> chancesAirs = Chance.GetConfigChances("Air");
			List<float> chancesBatterys = Chance.GetConfigChances("Battery");
			List<float> chancesBears = Chance.GetConfigChances("Bear");
			List<float> chancesBeavers = Chance.GetConfigChances("BeaverB");
			List<float> chancesBones = Chance.GetConfigChances("BoneB");
			List<float> chancesBuffalos = Chance.GetConfigChances("Buffalo");
			List<float> chancesFishs = Chance.GetConfigChances("Fish");
			List<float> chancesGeckos = Chance.GetConfigChances("Gecko");
			List<float> chancesLights = Chance.GetConfigChances("Light");
			List<float> chancesMoxs = Chance.GetConfigChances("Mox");
			List<float> chancesRGolds = Chance.GetConfigChances("RGold");
			List<float> chancesRHares = Chance.GetConfigChances("RHare");
			List<float> chancesRWolves = Chance.GetConfigChances("RWolve");
			List<float> chancesSBatterys = Chance.GetConfigChances("SBattery");
			List<float> chancesSHares = Chance.GetConfigChances("SHare");
			List<float> chancesWizards = Chance.GetConfigChances("Wizard");
            
			deckInfo = AddXAdditionalLogic.GenerateXAdditionalPelt(CountConfigsMore.extraAirs, chancesAirs, deckInfo, DraftingMod.MorePeltsGuid + "_Air Pelt");
			deckInfo = AddXAdditionalLogic.GenerateXAdditionalPelt(CountConfigsMore.extraBatterys, chancesBatterys, deckInfo, DraftingMod.MorePeltsGuid + "_Battery");
			deckInfo = AddXAdditionalLogic.GenerateXAdditionalPelt(CountConfigsMore.extraBears, chancesBears, deckInfo, DraftingMod.MorePeltsGuid + "_Bear Pelt");
			deckInfo = AddXAdditionalLogic.GenerateXAdditionalPelt(CountConfigsMore.extraBeavers, chancesBeavers, deckInfo, DraftingMod.MorePeltsGuid + "_Beaver Pelt");
			deckInfo = AddXAdditionalLogic.GenerateXAdditionalPelt(CountConfigsMore.extraBones, chancesBones, deckInfo, DraftingMod.MorePeltsGuid + "_Bone Pelt");
			deckInfo = AddXAdditionalLogic.GenerateXAdditionalPelt(CountConfigsMore.extraBuffalos, chancesBuffalos, deckInfo, DraftingMod.MorePeltsGuid + "_Buffalo Pelt");
			deckInfo = AddXAdditionalLogic.GenerateXAdditionalPelt(CountConfigsMore.extraFishs, chancesFishs, deckInfo, DraftingMod.MorePeltsGuid + "_Fish Pelt");
			deckInfo = AddXAdditionalLogic.GenerateXAdditionalPelt(CountConfigsMore.extraGeckos, chancesGeckos, deckInfo, DraftingMod.MorePeltsGuid + "_Gecko Pelt");
			deckInfo = AddXAdditionalLogic.GenerateXAdditionalPelt(CountConfigsMore.extraLights, chancesLights, deckInfo, DraftingMod.MorePeltsGuid + "_Light Pelt");
			deckInfo = AddXAdditionalLogic.GenerateXAdditionalPelt(CountConfigsMore.extraMoxs, chancesMoxs, deckInfo, DraftingMod.MorePeltsGuid + "_Mox Scroll");
			deckInfo = AddXAdditionalLogic.GenerateXAdditionalPelt(CountConfigsMore.extraRGolds, chancesRGolds, deckInfo, DraftingMod.MorePeltsGuid + "_Rotten Golden Pelt");
			deckInfo = AddXAdditionalLogic.GenerateXAdditionalPelt(CountConfigsMore.extraRHares, chancesRHares, deckInfo, DraftingMod.MorePeltsGuid + "_Rotten Pelt");
			deckInfo = AddXAdditionalLogic.GenerateXAdditionalPelt(CountConfigsMore.extraRWolves, chancesRWolves, deckInfo, DraftingMod.MorePeltsGuid + "_Rotten Wolf Pelt");
			deckInfo = AddXAdditionalLogic.GenerateXAdditionalPelt(CountConfigsMore.extraSBatterys, chancesRGolds, deckInfo, DraftingMod.MorePeltsGuid + "_Super Battery");
			deckInfo = AddXAdditionalLogic.GenerateXAdditionalPelt(CountConfigsMore.extraSHares, chancesRHares, deckInfo, DraftingMod.MorePeltsGuid + "_Super Pelt");
			deckInfo = AddXAdditionalLogic.GenerateXAdditionalPelt(CountConfigsMore.extraWizards, chancesWizards, deckInfo, DraftingMod.MorePeltsGuid + "_Wizard Pelt");
            
			return deckInfo;
		}
	}
}