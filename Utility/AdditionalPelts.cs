using AnsiConsolePlugin.Util;
using DiskCardGame;
using System.Collections.Generic;
using DraftingMod.Configuration;
using System;
using DraftingMod.Utility;

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
	            Console.WriteLine($"{GetColorFromTypeFunctions.GetColorFromString("Blue", "Bold")}Do I see The other DLL? I do, I do see the other DLL! ({ANSICodeLists.ResetColor}{GetColorFromTypeFunctions.GetColorFromString("Magenta", "Italic")}Tribal Pelts{ANSICodeLists.ResetColor}{GetColorFromTypeFunctions.GetColorFromString("Blue", "Bold")}){ANSICodeLists.ResetColor}");
	            deckInfo = Compat_Layer.Tribal_Pelts.AdditionalPeltsTribal.TribalPelts(deckInfo);
            }
            if (BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey(DraftingMod.TemplePeltsGuid))
            {
	            Console.WriteLine($"{GetColorFromTypeFunctions.GetColorFromString("Blue", "Bold")}Do I see The other DLL? I do, I do see the other DLL! ({ANSICodeLists.ResetColor}{GetColorFromTypeFunctions.GetColorFromString("Magenta", "Italic")}Temple Pelts{ANSICodeLists.ResetColor}{GetColorFromTypeFunctions.GetColorFromString("Blue", "Bold")}){ANSICodeLists.ResetColor}");
	            deckInfo = Compat_Layer.Temple_Pelts.AdditionalPeltsTemple.TemplePelts(deckInfo);
            }
            if (BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey(DraftingMod.MorePeltsGuid))
            {
	            Console.WriteLine($"{GetColorFromTypeFunctions.GetColorFromString("Blue", "Bold")}Do I see The other DLL? I do, I do see the other DLL! ({ANSICodeLists.ResetColor}{GetColorFromTypeFunctions.GetColorFromString("Magenta", "Italic")}More Pelts{ANSICodeLists.ResetColor}{GetColorFromTypeFunctions.GetColorFromString("Blue", "Bold")}){ANSICodeLists.ResetColor}");
	            deckInfo = Compat_Layer.More_Pelts.AdditionalPeltsMore.MorePelts(deckInfo);
            }
            if (BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey(DraftingMod.PerkPeltsGuid))
            {
	            Console.WriteLine($"{GetColorFromTypeFunctions.GetColorFromString("Blue", "Bold")}Do I see The other DLL? I do, I do see the other DLL! ({ANSICodeLists.ResetColor}{GetColorFromTypeFunctions.GetColorFromString("Magenta", "Italic")}Perk Pelts{ANSICodeLists.ResetColor}{GetColorFromTypeFunctions.GetColorFromString("Blue", "Bold")}){ANSICodeLists.ResetColor}");
	            deckInfo = Compat_Layer.Perk_Pelts.AdditionalPeltsPerk.PerkPelts(deckInfo);
            }
            
            return deckInfo;
		}
	}
}