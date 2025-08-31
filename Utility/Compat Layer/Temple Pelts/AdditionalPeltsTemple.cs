using DiskCardGame;
using System.Collections.Generic;
using DraftingMod.Configuration.Compat_Layer.Temple_Pelts;
using System;

namespace DraftingMod.Utility.Compat_Layer.Temple_Pelts
{
	public class AdditionalPeltsTemple
	{
		public static DeckInfo TemplePelts(DeckInfo deckInfo)
		{
			List<float> chancesBlood = Chance.GetConfigChances("Blood");
			List<float> chancesBone = Chance.GetConfigChances("Bone");
			List<float> chancesEnergy = Chance.GetConfigChances("Energy");
			List<float> chancesGem = Chance.GetConfigChances("Gem");

			try
			{
				deckInfo = AddXAdditionalLogic.GenerateXAdditionalPelt(CountConfigsTemple.extraBloods, chancesBlood, deckInfo, DraftingMod.TemplePeltsGuid + "_Vanilla_Blood_Vials");
			}
			catch
			{
				Console.WriteLine("Blood Vial Not Found");
			}
			try
			{
				deckInfo = AddXAdditionalLogic.GenerateXAdditionalPelt(CountConfigsTemple.extraBones, chancesBone, deckInfo, DraftingMod.TemplePeltsGuid + "_Vanilla_Bone_Fossils");
			}
			catch
			{
				Console.WriteLine("Bone Fossil Not Found");
			}
			try
			{
				deckInfo = AddXAdditionalLogic.GenerateXAdditionalPelt(CountConfigsTemple.extraEnergys, chancesEnergy, deckInfo, DraftingMod.TemplePeltsGuid + "_Vanilla_Energy_Capsules");
			}
			catch
			{
				Console.WriteLine("Energy Capsule Not Found");
			}
			try
			{
				deckInfo = AddXAdditionalLogic.GenerateXAdditionalPelt(CountConfigsTemple.extraGems, chancesGem, deckInfo, DraftingMod.TemplePeltsGuid + "_Vanilla_Gem_Holders");
			}
			catch
			{
				Console.WriteLine("Gem Holder Not Found");
			}

			return deckInfo;
		}
	}
}