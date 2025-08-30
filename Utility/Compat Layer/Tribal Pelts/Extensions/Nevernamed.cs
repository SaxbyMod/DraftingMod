using System.Collections.Generic;
using DiskCardGame;

namespace DraftingMod.Utility.Compat_Layer.Tribal_Pelts.Extensions
{
	public class Nevernamed
	{
		public static DeckInfo NevernamedExtension(DeckInfo deckInfo)
		{
			List<float> chanceLobsters = Chance.GetConfigChances("Lobster");
			List<float> chanceSpiders = Chance.GetConfigChances("Spider");
			
			// Handle Lobster Pelts
			if (chanceLobsters.Count < Configuration.Compat_Layer.Tribal_Pelts.Extensions.Nevernamed.extraLobsters.Value || chanceLobsters.Count > Configuration.Compat_Layer.Tribal_Pelts.Extensions.Nevernamed.extraLobsters.Value || Configuration.Compat_Layer.Tribal_Pelts.Extensions.Nevernamed.extraLobsters.Value > chanceLobsters.Count || Configuration.Compat_Layer.Tribal_Pelts.Extensions.Nevernamed.extraLobsters.Value < chanceLobsters.Count)
			{
				DraftingMod.Log.LogError("Error; not enough or too many percentages provided for Moths");
			}
			else
			{
				foreach (float chance in chanceLobsters)
				{
					if (Chance.chanceSuccessful(chance))
					{
						deckInfo.AddCard(CardLoader.GetCardByName(DraftingMod.TribalPeltsPrefix + "_Nevernameds_Sigilarium_Crustacean_Pelt"));
					}
				}
			}
			
			// Handle Spider Pelts
			if (chanceSpiders.Count < Configuration.Compat_Layer.Tribal_Pelts.Extensions.Nevernamed.extraSpiders.Value || chanceSpiders.Count > Configuration.Compat_Layer.Tribal_Pelts.Extensions.Nevernamed.extraSpiders.Value || Configuration.Compat_Layer.Tribal_Pelts.Extensions.Nevernamed.extraSpiders.Value > chanceSpiders.Count || Configuration.Compat_Layer.Tribal_Pelts.Extensions.Nevernamed.extraSpiders.Value < chanceSpiders.Count)
			{
				DraftingMod.Log.LogError("Error; not enough or too many percentages provided for Moths");
			}
			else
			{
				foreach (float chance in chanceSpiders)
				{
					if (Chance.chanceSuccessful(chance))
					{
						deckInfo.AddCard(CardLoader.GetCardByName(DraftingMod.TribalPeltsPrefix + "_Nevernameds_Sigilarium_Arachnid_Pelt"));
					}
				}
			}
			
			return deckInfo;
		}
	}
}