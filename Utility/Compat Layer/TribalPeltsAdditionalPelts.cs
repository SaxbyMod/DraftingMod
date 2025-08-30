using System.Collections.Generic;
using DiskCardGame;
using DraftingMod.Compat_Layer;

namespace DraftingMod.Utility.Compat_Layer
{
	public class TribalPeltsAdditionalPelts
	{
		public static DeckInfo TribalPelts (DeckInfo deckInfo) {
			List<float> chanceRavens = Chance.GetConfigChances("Raven");
			List<float> chanceCoyotes = Chance.GetConfigChances("Coyote");
			List<float> chanceMoths = Chance.GetConfigChances("Moth");
			List<float> chanceDeers = Chance.GetConfigChances("Deer");
			List<float> chanceCrocadiles = Chance.GetConfigChances("Crocadile");
			
			// Handle Raven Pelts
            if (chanceRavens.Count < TribalPeltsCountConfigs.extraRavens.Value || chanceRavens.Count > TribalPeltsCountConfigs.extraRavens.Value || TribalPeltsCountConfigs.extraRavens.Value > chanceRavens.Count || TribalPeltsCountConfigs.extraRavens.Value < chanceRavens.Count)
            {
	            DraftingMod.Log.LogError("Error; not enough or too many percentages provided for Ravens");
            }
            else
            {
	            foreach (float chance in chanceRavens)
	            {
		            if (Chance.chanceSuccessful(chance))
		            {
			            deckInfo.AddCard(CardLoader.GetCardByName(DraftingMod.TribalPeltsPrefix + "Vanila_Bird_Pelt"));
		            }
	            }
            }
            
            // Handle Coyote Pelts
            if (chanceCoyotes.Count < TribalPeltsCountConfigs.extraCoyotes.Value || chanceCoyotes.Count > TribalPeltsCountConfigs.extraCoyotes.Value || TribalPeltsCountConfigs.extraCoyotes.Value > chanceCoyotes.Count || TribalPeltsCountConfigs.extraCoyotes.Value < chanceCoyotes.Count)
            {
	            DraftingMod.Log.LogError("Error; not enough or too many percentages provided for Coyotes");
            }
            else
            {
	            foreach (float chance in chanceCoyotes)
	            {
		            if (Chance.chanceSuccessful(chance))
		            {
			            deckInfo.AddCard(CardLoader.GetCardByName(DraftingMod.TribalPeltsPrefix + "Vanila_Canine_Pelt"));
		            }
	            }
            }
            
            // Handle Moth Pelts
            if (chanceMoths.Count < TribalPeltsCountConfigs.extraMoths.Value || chanceMoths.Count > TribalPeltsCountConfigs.extraMoths.Value || TribalPeltsCountConfigs.extraMoths.Value > chanceMoths.Count || TribalPeltsCountConfigs.extraMoths.Value < chanceMoths.Count)
            {
	            DraftingMod.Log.LogError("Error; not enough or too many percentages provided for Moths");
            }
            else
            {
	            foreach (float chance in chanceMoths)
	            {
		            if (Chance.chanceSuccessful(chance))
		            {
			            deckInfo.AddCard(CardLoader.GetCardByName(DraftingMod.TribalPeltsPrefix + "Vanila_Insect_Pelt"));
		            }
	            }
            }
            
            // Handle Deer Pelts
            if (chanceDeers.Count < TribalPeltsCountConfigs.extraDeers.Value || chanceDeers.Count > TribalPeltsCountConfigs.extraDeers.Value || TribalPeltsCountConfigs.extraDeers.Value > chanceDeers.Count || TribalPeltsCountConfigs.extraDeers.Value < chanceDeers.Count)
            {
	            DraftingMod.Log.LogError("Error; not enough or too many percentages provided for Moths");
            }
            else
            {
	            foreach (float chance in chanceDeers)
	            {
		            if (Chance.chanceSuccessful(chance))
		            {
			            deckInfo.AddCard(CardLoader.GetCardByName(DraftingMod.TribalPeltsPrefix + "Vanila_Hooved_Pelt"));
		            }
	            }
            }
            
            // Handle Crocadile Pelts
            if (chanceCrocadiles.Count < TribalPeltsCountConfigs.extraCrocadiles.Value || chanceCrocadiles.Count > TribalPeltsCountConfigs.extraCrocadiles.Value || TribalPeltsCountConfigs.extraCrocadiles.Value > chanceCrocadiles.Count || TribalPeltsCountConfigs.extraCrocadiles.Value < chanceCrocadiles.Count)
            {
	            DraftingMod.Log.LogError("Error; not enough or too many percentages provided for Moths");
            }
            else
            {
	            foreach (float chance in chanceCrocadiles)
	            {
		            if (Chance.chanceSuccessful(chance))
		            {
			            deckInfo.AddCard(CardLoader.GetCardByName(DraftingMod.TribalPeltsPrefix + "Vanila_Reptile_Pelt"));
		            }
	            }
            }
            
            return deckInfo;
		}
	}
}