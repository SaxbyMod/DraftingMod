using System.Collections.Generic;
using DiskCardGame;

namespace DraftingMod.Utility.Compat_Layer.Tribal_Pelts.Extensions
{
	public class Beaver
	{
		public static DeckInfo BeaverExtension(DeckInfo deckInfo)
		{
			List<float> chanceBeavers = Chance.GetConfigChances("Beaver");
			
			// Handle Beaver Pelts
			if (chanceBeavers.Count < Configuration.Compat_Layer.Tribal_Pelts.Extensions.Beaver.extraBeavers.Value || chanceBeavers.Count > Configuration.Compat_Layer.Tribal_Pelts.Extensions.Beaver.extraBeavers.Value || Configuration.Compat_Layer.Tribal_Pelts.Extensions.Beaver.extraBeavers.Value > chanceBeavers.Count || Configuration.Compat_Layer.Tribal_Pelts.Extensions.Beaver.extraBeavers.Value < chanceBeavers.Count)
			{
				DraftingMod.Log.LogError("Error; not enough or too many percentages provided for Moths");
			}
			else
			{
				foreach (float chance in chanceBeavers)
				{
					if (Chance.chanceSuccessful(chance))
					{
						deckInfo.AddCard(CardLoader.GetCardByName(DraftingMod.TribalPeltsPrefix + "_Overlaps_Rodent_Pelt"));
					}
				}
			}
			
			return deckInfo;
		}
	}
}