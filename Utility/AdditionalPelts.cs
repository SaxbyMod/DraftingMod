using DiskCardGame;
using System.Collections.Generic;
using DraftingMod.Configuration;
using System;

namespace DraftingMod.Utility
{
	public class AdditionalPelts
	{
		public static DeckInfo AddAdditionalPelts(DeckInfo deckInfo)
		{
			List<float> chancesHares = Chance.GetConfigChances("Hare");
            List<float> chancesWolves = Chance.GetConfigChances("Wolve");
            List<float> chancesGolds = Chance.GetConfigChances("Gold");
            
            deckInfo = AddXAdditionalLogic.GenerateXAdditionalPelt(CountConfigs.extraHares, chancesHares, deckInfo, "PeltHare");
            deckInfo = AddXAdditionalLogic.GenerateXAdditionalPelt(CountConfigs.extraWolves, chancesWolves, deckInfo, "PeltWolf");
            deckInfo = AddXAdditionalLogic.GenerateXAdditionalPelt(CountConfigs.extraGolds, chancesGolds, deckInfo, "PeltGolden");
            
            if (BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey(DraftingMod.TribalPeltsGuid))
            {
	            Console.WriteLine("Do I see The other DLL? I do, I do see the other DLL! (Tribal Pelts)");
	            Compat_Layer.Tribal_Pelts.AdditionalPeltsTribal.TribalPelts(deckInfo);
            }
            if (BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey(DraftingMod.TemplePeltsGuid))
            {
	            Console.WriteLine("Do I see The other DLL? I do, I do see the other DLL! (Temple Pelts)");
	            Compat_Layer.Temple_Pelts.AdditionalPeltsTemple.TemplePelts(deckInfo);
            }
            
            return deckInfo;
		}
	}
}