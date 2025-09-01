using DiskCardGame;
using BepInEx.Configuration;
using System.Collections.Generic;

namespace DraftingMod.Utility
{
	public class AddXAdditionalLogic
	{
		public static DeckInfo GenerateXAdditionalPelt(ConfigEntry<int> COUNT, List<float> Chances, DeckInfo deckInfo, string cardName)
		{
			if (Chances.Count < COUNT.Value || Chances.Count > COUNT.Value || COUNT.Value > Chances.Count || COUNT.Value < Chances.Count)
			{
				DraftingMod.Log.LogError($"{ColorLists.HighlighterColorText[1]}Error; not enough or too many percentages provided for {cardName}{ColorLists.ResetColor}");
			}
			else
			{
				foreach (float chance in Chances)
				{
					if (Chance.chanceSuccessful(chance, cardName))
					{
						deckInfo.AddCard(CardLoader.GetCardByName(cardName));
					}
				}
			}
			
			return deckInfo;
		}
		
		public static ConfigEntry<int> GenerateXAdditionalCount(ConfigFile Config, string Type, int Default, string Section)
		{
			return Config.Bind<int>(Section,
				$"How many extra {Type}s for the entree?",
				Default,
				$"How many extra {Type}s should be given for the entree?");
		}
		
		public static ConfigEntry<string> GenerateXAdditionalChance(ConfigFile Config, string Type, string Default, string Section)
		{
			return Config.Bind<string>(Section,
				$"What should the chances for each {Type} entree be?",
				Default,
				"Give me a list of percentages seperated by commas for each pelt asked for in the counts section. EX; If there were four write `30%, 20%, 10%, 5%` note it doesn't have to be these precisely but must be formatted as such.");
		}
	}
}