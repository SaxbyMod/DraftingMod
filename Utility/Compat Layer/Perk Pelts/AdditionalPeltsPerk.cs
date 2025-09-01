using AnsiConsolePlugin.Util;
using DiskCardGame;
using System.Collections.Generic;
using DraftingMod.Configuration;
using DraftingMod.Configuration.Compat_Layer.Perk_Pelts;
using System;
using DraftingMod.Utility;

namespace DraftingMod.Utility.Compat_Layer.Perk_Pelts
{
	public class AdditionalPeltsPerk
	{
		public static DeckInfo PerkPelts (DeckInfo deckInfo) {
			List<float> chanceRats = Chance.GetConfigChances("Rat");
			List<float> chanceTrees = Chance.GetConfigChances("Tree");
			
            deckInfo = AddXAdditionalLogic.GenerateXAdditionalPelt(CountConfigsPerk.extraRats, chanceRats, deckInfo, DraftingMod.PerkPeltsPrefix + "_PerkToken");
            deckInfo = AddXAdditionalLogic.GenerateXAdditionalPelt(CountConfigsPerk.extraTrees, chanceTrees, deckInfo, DraftingMod.PerkPeltsPrefix + "_PerkBase");
            
            return deckInfo;
		}
	}
}