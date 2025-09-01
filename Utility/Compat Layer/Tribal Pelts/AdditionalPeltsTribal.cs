using AnsiConsolePlugin.Util;
using System.Collections.Generic;
using DiskCardGame;
using DraftingMod.Configuration.Compat_Layer.Tribal_Pelts;
using DraftingMod.Utility.Compat_Layer.Tribal_Pelts.Extensions;
using System;

namespace DraftingMod.Utility.Compat_Layer.Tribal_Pelts
{
	public class AdditionalPeltsTribal
	{
		public static DeckInfo TribalPelts (DeckInfo deckInfo) {
			List<float> chanceRavens = Chance.GetConfigChances("Raven");
			List<float> chanceCoyotes = Chance.GetConfigChances("Coyote");
			List<float> chanceMoths = Chance.GetConfigChances("Moth");
			List<float> chanceDeers = Chance.GetConfigChances("Deer");
			List<float> chanceCrocadiles = Chance.GetConfigChances("Crocadile");
			
            deckInfo = AddXAdditionalLogic.GenerateXAdditionalPelt(CountConfigsTribal.extraRavens, chanceRavens, deckInfo, DraftingMod.TribalPeltsGuid + "_Vanilla_Bird_Pelt");
            deckInfo = AddXAdditionalLogic.GenerateXAdditionalPelt(CountConfigsTribal.extraCoyotes, chanceCoyotes, deckInfo, DraftingMod.TribalPeltsGuid + "_Vanilla_Canine_Pelt");
            deckInfo = AddXAdditionalLogic.GenerateXAdditionalPelt(CountConfigsTribal.extraMoths, chanceMoths, deckInfo, DraftingMod.TribalPeltsGuid + "_Vanilla_Insect_Pelt");
            deckInfo = AddXAdditionalLogic.GenerateXAdditionalPelt(CountConfigsTribal.extraDeers, chanceDeers, deckInfo, DraftingMod.TribalPeltsGuid + "_Vanilla_Hooved_Pelt");
            deckInfo = AddXAdditionalLogic.GenerateXAdditionalPelt(CountConfigsTribal.extraCrocadiles, chanceCrocadiles, deckInfo, DraftingMod.TribalPeltsGuid + "_Vanilla_Reptile_Pelt");
            
            // Handle Tribal Pelts Extensions
            if (BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey(DraftingMod.NevernamedsSigilariumGuid) || BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey(DraftingMod.BundleOfTotemsGuid) || BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey(DraftingMod.VerminTribeGuid))
            {
	            Console.WriteLine($"{GetColorFromTypeFunctions.GetColorFromString("Blue", "Bold")}Do I see the extension enabled? I do, I do!! ({ANSICodeLists.ResetColor}{GetColorFromTypeFunctions.GetColorFromString("Magenta", "Italic")}Beaver Pelts{ANSICodeLists.ResetColor}{GetColorFromTypeFunctions.GetColorFromString("Blue", "Bold")}){ANSICodeLists.ResetColor}");
	            deckInfo = BeaverUtil.BeaverExtension(deckInfo);
            }
            if (BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey(DraftingMod.NevernamedsSigilariumGuid))
            {
	            Console.WriteLine($"{GetColorFromTypeFunctions.GetColorFromString("Blue", "Bold")}Do I see the extension enabled? I do, I do!! ({ANSICodeLists.ResetColor}{GetColorFromTypeFunctions.GetColorFromString("Magenta", "Italic")}Nevernamed's Sigilarium Pelts{ANSICodeLists.ResetColor}{GetColorFromTypeFunctions.GetColorFromString("Blue", "Bold")}){ANSICodeLists.ResetColor}");
	            deckInfo = NevernamedUtil.NevernamedExtension(deckInfo);
            }
            if (BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey(DraftingMod.BundleOfTotemsGuid))
            {
	            Console.WriteLine($"{GetColorFromTypeFunctions.GetColorFromString("Blue", "Bold")}Do I see the extension enabled? I do, I do!! ({ANSICodeLists.ResetColor}{GetColorFromTypeFunctions.GetColorFromString("Magenta", "Italic")}Bundle Of Totems Pelts{ANSICodeLists.ResetColor}{GetColorFromTypeFunctions.GetColorFromString("Blue", "Bold")}){ANSICodeLists.ResetColor}");
	            deckInfo = BundleUtil.BundleExtension(deckInfo);
            }
            if (BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey(DraftingMod.MushroomTribesGuid))
            {
	            Console.WriteLine($"{GetColorFromTypeFunctions.GetColorFromString("Blue", "Bold")}Do I see the extension enabled? I do, I do!! ({ANSICodeLists.ResetColor}{GetColorFromTypeFunctions.GetColorFromString("Magenta", "Italic")}Mushroom Tribes Pelts{ANSICodeLists.ResetColor}{GetColorFromTypeFunctions.GetColorFromString("Blue", "Bold")}){ANSICodeLists.ResetColor}");
	            deckInfo = MushroomUtil.MushroomExtension(deckInfo);
            }
            
            return deckInfo;
		}
	}
}