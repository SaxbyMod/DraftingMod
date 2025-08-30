using System.Collections.Generic;
using DiskCardGame;
using DraftingMod.Configuration.Compat_Layer.Tribal_Pelts;
using DraftingMod.Utility.Compat_Layer.Tribal_Pelts.Extensions;

namespace DraftingMod.Utility.Compat_Layer.Tribal_Pelts
{
	public class AdditionalPelts
	{
		public static DeckInfo TribalPelts (DeckInfo deckInfo) {
			List<float> chanceRavens = Chance.GetConfigChances("Raven");
			List<float> chanceCoyotes = Chance.GetConfigChances("Coyote");
			List<float> chanceMoths = Chance.GetConfigChances("Moth");
			List<float> chanceDeers = Chance.GetConfigChances("Deer");
			List<float> chanceCrocadiles = Chance.GetConfigChances("Crocadile");
			
			// Handle Raven Pelts
            if (chanceRavens.Count < CountConfigs.extraRavens.Value || chanceRavens.Count > CountConfigs.extraRavens.Value || CountConfigs.extraRavens.Value > chanceRavens.Count || CountConfigs.extraRavens.Value < chanceRavens.Count)
            {
	            DraftingMod.Log.LogError("Error; not enough or too many percentages provided for Ravens");
            }
            else
            {
	            foreach (float chance in chanceRavens)
	            {
		            if (Chance.chanceSuccessful(chance))
		            {
			            deckInfo.AddCard(CardLoader.GetCardByName(DraftingMod.TribalPeltsPrefix + "_Vanilla_Bird_Pelt"));
		            }
	            }
            }
            
            // Handle Coyote Pelts
            if (chanceCoyotes.Count < CountConfigs.extraCoyotes.Value || chanceCoyotes.Count > CountConfigs.extraCoyotes.Value || CountConfigs.extraCoyotes.Value > chanceCoyotes.Count || CountConfigs.extraCoyotes.Value < chanceCoyotes.Count)
            {
	            DraftingMod.Log.LogError("Error; not enough or too many percentages provided for Coyotes");
            }
            else
            {
	            foreach (float chance in chanceCoyotes)
	            {
		            if (Chance.chanceSuccessful(chance))
		            {
			            deckInfo.AddCard(CardLoader.GetCardByName(DraftingMod.TribalPeltsPrefix + "_Vanilla_Canine_Pelt"));
		            }
	            }
            }
            
            // Handle Moth Pelts
            if (chanceMoths.Count < CountConfigs.extraMoths.Value || chanceMoths.Count > CountConfigs.extraMoths.Value || CountConfigs.extraMoths.Value > chanceMoths.Count || CountConfigs.extraMoths.Value < chanceMoths.Count)
            {
	            DraftingMod.Log.LogError("Error; not enough or too many percentages provided for Moths");
            }
            else
            {
	            foreach (float chance in chanceMoths)
	            {
		            if (Chance.chanceSuccessful(chance))
		            {
			            deckInfo.AddCard(CardLoader.GetCardByName(DraftingMod.TribalPeltsPrefix + "_Vanilla_Insect_Pelt"));
		            }
	            }
            }
            
            // Handle Deer Pelts
            if (chanceDeers.Count < CountConfigs.extraDeers.Value || chanceDeers.Count > CountConfigs.extraDeers.Value || CountConfigs.extraDeers.Value > chanceDeers.Count || CountConfigs.extraDeers.Value < chanceDeers.Count)
            {
	            DraftingMod.Log.LogError("Error; not enough or too many percentages provided for Moths");
            }
            else
            {
	            foreach (float chance in chanceDeers)
	            {
		            if (Chance.chanceSuccessful(chance))
		            {
			            deckInfo.AddCard(CardLoader.GetCardByName(DraftingMod.TribalPeltsPrefix + "_Vanilla_Hooved_Pelt"));
		            }
	            }
            }
            
            // Handle Crocadile Pelts
            if (chanceCrocadiles.Count < CountConfigs.extraCrocadiles.Value || chanceCrocadiles.Count > CountConfigs.extraCrocadiles.Value || CountConfigs.extraCrocadiles.Value > chanceCrocadiles.Count || CountConfigs.extraCrocadiles.Value < chanceCrocadiles.Count)
            {
	            DraftingMod.Log.LogError("Error; not enough or too many percentages provided for Moths");
            }
            else
            {
	            foreach (float chance in chanceCrocadiles)
	            {
		            if (Chance.chanceSuccessful(chance))
		            {
			            deckInfo.AddCard(CardLoader.GetCardByName(DraftingMod.TribalPeltsPrefix + "_Vanilla_Reptile_Pelt"));
		            }
	            }
            }
            
            // Handle Tribal Pelts Extensions
            if (BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey(DraftingMod.NGUID) || BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey(DraftingMod.LGUID) || BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey(DraftingMod.VGUID))
            {
	            DraftingMod.Log.LogMessage("Do I see the extension enabled? I do, I do!! (Beaver Pelt)");
	            deckInfo = Beaver.BeaverExtension(deckInfo);
            }
            if (BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey(DraftingMod.NGUID))
            {
	            DraftingMod.Log.LogMessage("Do I see the extension enabled? I do, I do!! (Nevernamed's Sigilarium Pelts)");
	            deckInfo = Nevernamed.NevernamedExtension(deckInfo);
            }
            if (BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey(DraftingMod.LGUID))
            {
	            DraftingMod.Log.LogMessage("Do I see the extension enabled? I do, I do!! (Bundle Of Totems Pelts)");
	            deckInfo = Bundle.BundleExtension(deckInfo);
            }
            
            return deckInfo;
		}
	}
}