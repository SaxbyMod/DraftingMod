using System.Collections.Generic;
using DiskCardGame;
using DraftingMod.Configuration.Compat_Layer.Tribal_Pelts.Extensions;

namespace DraftingMod.Utility.Compat_Layer.Tribal_Pelts.Extensions
{
	public class BeaverUtil
	{
		public static DeckInfo BeaverExtension(DeckInfo deckInfo)
		{
			List<float> chanceBeavers = Chance.GetConfigChances("Beaver");

			deckInfo = AddXAdditionalLogic.GenerateXAdditionalPelt(BeaverConfig.extraBeavers, chanceBeavers, deckInfo, DraftingMod.TribalPeltsGuid + "_Overlaps_Rodent_Pelt");
			
			return deckInfo;
		}
	}
}