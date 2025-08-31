using System.Collections.Generic;
using DiskCardGame;
using DraftingMod.Configuration.Compat_Layer.Tribal_Pelts.Extensions;

namespace DraftingMod.Utility.Compat_Layer.Tribal_Pelts.Extensions
{
	public class NevernamedUtil
	{
		public static DeckInfo NevernamedExtension(DeckInfo deckInfo)
		{
			List<float> chanceLobsters = Chance.GetConfigChances("Lobster");
			List<float> chanceSpiders = Chance.GetConfigChances("Spider");
			
			deckInfo = AddXAdditionalLogic.GenerateXAdditionalPelt(NevernamedConfig.extraLobsters, chanceLobsters, deckInfo, DraftingMod.TribalPeltsGuid + "_Nevernameds_Sigilarium_Crustacean_Pelt");
			deckInfo = AddXAdditionalLogic.GenerateXAdditionalPelt(NevernamedConfig.extraSpiders, chanceSpiders, deckInfo, DraftingMod.TribalPeltsGuid + "_Nevernameds_Sigilarium_Arachnid_Pelt");
			
			return deckInfo;
		}
	}
}