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
	            Console.WriteLine($"{ColorLists.BoldColorList[4]}Do I see the extension enabled? I do, I do!! ({ColorLists.ResetColor}{ColorLists.ItalicColorList[5]}Beaver Pelts{ColorLists.ResetColor}{ColorLists.BoldColorList[4]}){ColorLists.ResetColor}");
	            deckInfo = BeaverUtil.BeaverExtension(deckInfo);
            }
            if (BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey(DraftingMod.NevernamedsSigilariumGuid))
            {
	            Console.WriteLine($"{ColorLists.BoldColorList[4]}Do I see the extension enabled? I do, I do!! ({ColorLists.ResetColor}{ColorLists.ItalicColorList[5]}Nevernamed's Sigilarium Pelts{ColorLists.ResetColor}{ColorLists.BoldColorList[4]}){ColorLists.ResetColor}");
	            deckInfo = NevernamedUtil.NevernamedExtension(deckInfo);
            }
            if (BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey(DraftingMod.BundleOfTotemsGuid))
            {
	            Console.WriteLine($"{ColorLists.BoldColorList[4]}Do I see the extension enabled? I do, I do!! ({ColorLists.ResetColor}{ColorLists.ItalicColorList[5]}Bundle Of Totems Pelts{ColorLists.ResetColor}{ColorLists.BoldColorList[4]}){ColorLists.ResetColor}");
	            deckInfo = BundleUtil.BundleExtension(deckInfo);
            }
            if (BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey(DraftingMod.MushroomTribesGuid))
            {
	            Console.WriteLine($"{ColorLists.BoldColorList[4]}Do I see the extension enabled? I do, I do!! ({ColorLists.ResetColor}{ColorLists.ItalicColorList[5]}Mushroom Tribes Pelts{ColorLists.ResetColor}{ColorLists.BoldColorList[4]}){ColorLists.ResetColor}");
	            deckInfo = MushroomUtil.MushroomExtension(deckInfo);
            }
            
            return deckInfo;
		}
	}
}