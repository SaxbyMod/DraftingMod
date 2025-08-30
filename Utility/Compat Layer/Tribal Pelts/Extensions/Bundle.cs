using System.Collections.Generic;
using DiskCardGame;

namespace DraftingMod.Utility.Compat_Layer.Tribal_Pelts.Extensions
{
	public class Bundle
	{
		public static DeckInfo BundleExtension(DeckInfo deckInfo)
		{
			List<float> chanceHumans = Chance.GetConfigChances("Human");
			List<float> chanceSharks = Chance.GetConfigChances("Shark");
			List<float> chanceTigers = Chance.GetConfigChances("Tiger");

			// Handle Human Pelts
			if (chanceHumans.Count < Configuration.Compat_Layer.Tribal_Pelts.Extensions.Bundle.extraHumans.Value || chanceHumans.Count > Configuration.Compat_Layer.Tribal_Pelts.Extensions.Bundle.extraHumans.Value || Configuration.Compat_Layer.Tribal_Pelts.Extensions.Bundle.extraHumans.Value > chanceHumans.Count ||
			    Configuration.Compat_Layer.Tribal_Pelts.Extensions.Bundle.extraHumans.Value < chanceHumans.Count)
			{
				DraftingMod.Log.LogError("Error; not enough or too many percentages provided for Moths");
			}
			else
			{
				foreach (float chance in chanceHumans)
				{
					if (Chance.chanceSuccessful(chance))
					{
						deckInfo.AddCard(CardLoader.GetCardByName(DraftingMod.TribalPeltsPrefix + "_Bundle_Of_Totems_Undead_Pelt"));
					}
				}
			}

			// Handle Shark Pelts
			if (chanceSharks.Count < Configuration.Compat_Layer.Tribal_Pelts.Extensions.Bundle.extraSharks.Value || chanceSharks.Count > Configuration.Compat_Layer.Tribal_Pelts.Extensions.Bundle.extraSharks.Value || Configuration.Compat_Layer.Tribal_Pelts.Extensions.Bundle.extraSharks.Value > chanceSharks.Count ||
			    Configuration.Compat_Layer.Tribal_Pelts.Extensions.Bundle.extraSharks.Value < chanceSharks.Count)
			{
				DraftingMod.Log.LogError("Error; not enough or too many percentages provided for Moths");
			}
			else
			{
				foreach (float chance in chanceSharks)
				{
					if (Chance.chanceSuccessful(chance))
					{
						deckInfo.AddCard(CardLoader.GetCardByName(DraftingMod.TribalPeltsPrefix + "_Bundle_Of_Totems_Aquatic_Pelt"));
					}
				}
			}

			// Handle Tiger Pelts
			if (chanceTigers.Count < Configuration.Compat_Layer.Tribal_Pelts.Extensions.Bundle.extraTigers.Value || chanceTigers.Count > Configuration.Compat_Layer.Tribal_Pelts.Extensions.Bundle.extraTigers.Value || Configuration.Compat_Layer.Tribal_Pelts.Extensions.Bundle.extraTigers.Value > chanceTigers.Count ||
			    Configuration.Compat_Layer.Tribal_Pelts.Extensions.Bundle.extraTigers.Value < chanceTigers.Count)
			{
				DraftingMod.Log.LogError("Error; not enough or too many percentages provided for Moths");
			}
			else
			{
				foreach (float chance in chanceTigers)
				{
					if (Chance.chanceSuccessful(chance))
					{
						deckInfo.AddCard(CardLoader.GetCardByName(DraftingMod.TribalPeltsPrefix + "_Bundle_Of_Totems_Feline_Pelt"));
					}
				}
			}

			return deckInfo;
		}
	}
}