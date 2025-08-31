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
	            Console.WriteLine("Do I see the extension enabled? I do, I do!! (Beaver Pelt)");
	            deckInfo = BeaverUtil.BeaverExtension(deckInfo);
            }
            if (BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey(DraftingMod.NevernamedsSigilariumGuid))
            {
	            Console.WriteLine("Do I see the extension enabled? I do, I do!! (Nevernamed's Sigilarium Pelts)");
	            deckInfo = NevernamedUtil.NevernamedExtension(deckInfo);
            }
            if (BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey(DraftingMod.BundleOfTotemsGuid))
            {
	            Console.WriteLine("Do I see the extension enabled? I do, I do!! (Bundle Of Totems Pelts)");
	            deckInfo = BundleUtil.BundleExtension(deckInfo);
            }
            if (BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey(DraftingMod.MushroomTribesGuid))
            {
	            Console.WriteLine("Do I see the extension enabled? I do, I do!! (Bundle Of Totems Pelts)");
	            deckInfo = MushroomUtil.MushroomExtension(deckInfo);
            }
            
            return deckInfo;
		}
	}
}