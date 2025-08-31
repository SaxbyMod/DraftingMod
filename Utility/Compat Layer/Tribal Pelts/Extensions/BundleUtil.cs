using System.Collections.Generic;
using DiskCardGame;
using DraftingMod.Configuration.Compat_Layer.Tribal_Pelts.Extensions;

namespace DraftingMod.Utility.Compat_Layer.Tribal_Pelts.Extensions
{
	public class BundleUtil
	{
		public static DeckInfo BundleExtension(DeckInfo deckInfo)
		{
			List<float> chanceHumans = Chance.GetConfigChances("Human");
			List<float> chanceSharks = Chance.GetConfigChances("Shark");
			List<float> chanceTigers = Chance.GetConfigChances("Tiger");

			deckInfo = AddXAdditionalLogic.GenerateXAdditionalPelt(BundleConfig.extraHumans, chanceHumans, deckInfo, DraftingMod.TribalPeltsGuid + "_Bundle_Of_Totems_Undead_Pelt");
			deckInfo = AddXAdditionalLogic.GenerateXAdditionalPelt(BundleConfig.extraSharks, chanceSharks, deckInfo, DraftingMod.TribalPeltsGuid + "_Bundle_Of_Totems_Aquatic_Pelt");
			deckInfo = AddXAdditionalLogic.GenerateXAdditionalPelt(BundleConfig.extraTigers, chanceTigers, deckInfo, DraftingMod.TribalPeltsGuid + "_Bundle_Of_Totems_Feline_Pelt");

			return deckInfo;
		}
	}
}