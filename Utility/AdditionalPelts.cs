using DiskCardGame;
using System.Collections.Generic;

namespace DraftingMod.Utility
{
	public class AdditionalPelts
	{
		public static DeckInfo AddAdditionalPelts(DeckInfo deckInfo)
		{
			List<float> chancesHares = Chance.GetConfigChances("Hare");
            List<float> chancesWolves = Chance.GetConfigChances("Wolve");
            List<float> chancesGolds = Chance.GetConfigChances("Gold");
			
            // Handle Hare Pelts
            if (chancesHares.Count < CountConfigs.extraHares.Value || chancesHares.Count > CountConfigs.extraHares.Value || CountConfigs.extraHares.Value > chancesHares.Count || CountConfigs.extraHares.Value < chancesHares.Count)
            {
	            DraftingMod.Log.LogError("Error; not enough or too many percentages provided for Hares");
            }
            else
            {
	            foreach (float chance in chancesHares)
	            {
		            if (Chance.chanceSuccessful(chance))
		            {
			            deckInfo.AddCard(CardLoader.GetCardByName("PeltHare"));
		            }
	            }
            }
            // Handle Wolf Pelts
            if (chancesWolves.Count < CountConfigs.extraWolves.Value || chancesWolves.Count > CountConfigs.extraWolves.Value || CountConfigs.extraWolves.Value > chancesWolves.Count || CountConfigs.extraWolves.Value < chancesWolves.Count)
            {
	            DraftingMod.Log.LogError("Error; not enough or too many percentages provided for Wolves");
            }
            else
            {
	            foreach (float chance in chancesWolves)
	            {
		            if (Chance.chanceSuccessful(chance))
		            {
			            deckInfo.AddCard(CardLoader.GetCardByName("PeltWolf"));
		            }
	            }
            }
            // Handle Gold Pelts
            if (chancesGolds.Count < CountConfigs.extraGolds.Value || chancesGolds.Count > CountConfigs.extraGolds.Value || CountConfigs.extraGolds.Value > chancesGolds.Count || CountConfigs.extraGolds.Value < chancesGolds.Count)
            {
	            DraftingMod.Log.LogError("Error; not enough or too many percentages provided for Golds");
            }
            else
            {
	            foreach (float chance in chancesGolds)
	            {
		            if (Chance.chanceSuccessful(chance))
		            {
			            deckInfo.AddCard(CardLoader.GetCardByName("PeltGolden"));
		            }
	            }
            }
            
            if (BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey(DraftingMod.TribalPeltsPrefix))
            {
	            DraftingMod.Log.LogMessage("Do I see The other DLL? I do, I do see the other DLL! (Tribal Pelts)");
	            Compat_Layer.TribalPeltsAdditionalPelts.TribalPelts(deckInfo);
            }
            
            return deckInfo;
		}
	}
}