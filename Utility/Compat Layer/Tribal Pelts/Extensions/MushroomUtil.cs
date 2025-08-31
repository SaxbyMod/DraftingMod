using System.Collections.Generic;
using DiskCardGame;
using DraftingMod.Configuration.Compat_Layer.Tribal_Pelts.Extensions;

namespace DraftingMod.Utility.Compat_Layer.Tribal_Pelts.Extensions
{
	public class MushroomUtil
	{
		public static DeckInfo MushroomExtension(DeckInfo deckInfo)
		{
			List<float> chanceBlasters = Chance.GetConfigChances("Blaster");;
			List<float> chanceBlocks = Chance.GetConfigChances("Block");;
			List<float> chanceBloopers = Chance.GetConfigChances("Blooper");;
			List<float> chanceBobOmbs = Chance.GetConfigChances("Bob-Omb");;
			List<float> chanceBoos = Chance.GetConfigChances("Boo");;
			List<float> chanceChainChomps = Chance.GetConfigChances("Chain Chomp");;
			List<float> chanceCheepCheeps = Chance.GetConfigChances("Cheep Cheep");;
			List<float> chanceConkdors = Chance.GetConfigChances("Conkdor");;
			List<float> chanceDragons = Chance.GetConfigChances("Dragon");;
			List<float> chanceDryBones = Chance.GetConfigChances("Dry Bone");;
			List<float> chanceGoombas = Chance.GetConfigChances("Goomba");;
			List<float> chanceKoopas = Chance.GetConfigChances("Koopa");;
			List<float> chancePiranhas = Chance.GetConfigChances("Piranha");;
			List<float> chancePokeys = Chance.GetConfigChances("Pokey");;
			List<float> chancePowerUps = Chance.GetConfigChances("Power Up");;
			List<float> chanceRams = Chance.GetConfigChances("Ram");;
			List<float> chanceShroobs = Chance.GetConfigChances("Shroob");;
			List<float> chanceShyGuys = Chance.GetConfigChances("Shy Guy");;
			List<float> chanceSpikes = Chance.GetConfigChances("Spike");;
			List<float> chanceStars = Chance.GetConfigChances("Star");;
			List<float> chanceTanukis = Chance.GetConfigChances("Tanuki");;
			List<float> chanceThwomps = Chance.GetConfigChances("Thwomp");;
			List<float> chanceWaddlewings = Chance.GetConfigChances("Waddlewing");;
			List<float> chanceWigglers = Chance.GetConfigChances("Wiggler");;

			deckInfo = AddXAdditionalLogic.GenerateXAdditionalPelt(MushroomConfig.extraBlasters, chanceBlasters, deckInfo, DraftingMod.TribalPeltsGuid + "_Mushroom_Blaster_Pelt");
			deckInfo = AddXAdditionalLogic.GenerateXAdditionalPelt(MushroomConfig.extraBlocks, chanceBlocks, deckInfo, DraftingMod.TribalPeltsGuid + "_Mushroom_Block_Pelt");
			deckInfo = AddXAdditionalLogic.GenerateXAdditionalPelt(MushroomConfig.extraBloopers, chanceBloopers, deckInfo, DraftingMod.TribalPeltsGuid + "_Mushroom_Blooper_Pelt");
			deckInfo = AddXAdditionalLogic.GenerateXAdditionalPelt(MushroomConfig.extraBobOmbs, chanceBobOmbs, deckInfo, DraftingMod.TribalPeltsGuid + "_Mushroom_Bob_Omb_Pelt");
			deckInfo = AddXAdditionalLogic.GenerateXAdditionalPelt(MushroomConfig.extraBoos, chanceBoos, deckInfo, DraftingMod.TribalPeltsGuid + "_Mushroom_Boo_Pelt");
			deckInfo = AddXAdditionalLogic.GenerateXAdditionalPelt(MushroomConfig.extraChainChomps, chanceChainChomps, deckInfo, DraftingMod.TribalPeltsGuid + "_Mushroom_Chain_Chomp_Pelt");
			deckInfo = AddXAdditionalLogic.GenerateXAdditionalPelt(MushroomConfig.extraCheepCheeps, chanceCheepCheeps, deckInfo, DraftingMod.TribalPeltsGuid + "_Mushroom_Cheep_Cheep_Pelt");
			deckInfo = AddXAdditionalLogic.GenerateXAdditionalPelt(MushroomConfig.extraConkdors, chanceConkdors, deckInfo, DraftingMod.TribalPeltsGuid + "_Mushroom_Conkdor_Pelt");
			deckInfo = AddXAdditionalLogic.GenerateXAdditionalPelt(MushroomConfig.extraDragons, chanceDragons, deckInfo, DraftingMod.TribalPeltsGuid + "_Mushroom_Dragon_Pelt");
			deckInfo = AddXAdditionalLogic.GenerateXAdditionalPelt(MushroomConfig.extraDryBones, chanceDryBones, deckInfo, DraftingMod.TribalPeltsGuid + "_Mushroom_Dry_Bones_Pelt");
			deckInfo = AddXAdditionalLogic.GenerateXAdditionalPelt(MushroomConfig.extraGoombas, chanceGoombas, deckInfo, DraftingMod.TribalPeltsGuid + "_Mushroom_Goomba_Pelt");
			deckInfo = AddXAdditionalLogic.GenerateXAdditionalPelt(MushroomConfig.extraKoopas, chanceKoopas, deckInfo, DraftingMod.TribalPeltsGuid + "_Mushroom_Koopa_Pelt");
			deckInfo = AddXAdditionalLogic.GenerateXAdditionalPelt(MushroomConfig.extraPiranhas, chancePiranhas, deckInfo, DraftingMod.TribalPeltsGuid + "_Mushroom_Piranha_Plant_Pelt");
			deckInfo = AddXAdditionalLogic.GenerateXAdditionalPelt(MushroomConfig.extraPokeys, chancePokeys, deckInfo, DraftingMod.TribalPeltsGuid + "_Mushroom_Pokey_Pelt");
			deckInfo = AddXAdditionalLogic.GenerateXAdditionalPelt(MushroomConfig.extraPowerUps, chancePowerUps, deckInfo, DraftingMod.TribalPeltsGuid + "_Mushroom_Power_Up_Pelt");
			deckInfo = AddXAdditionalLogic.GenerateXAdditionalPelt(MushroomConfig.extraRams, chanceRams, deckInfo, DraftingMod.TribalPeltsGuid + "_Mushroom_Ram_Pelt");
			deckInfo = AddXAdditionalLogic.GenerateXAdditionalPelt(MushroomConfig.extraShroobs, chanceShroobs, deckInfo, DraftingMod.TribalPeltsGuid + "_Mushroom_Shroob_Pelt");
			deckInfo = AddXAdditionalLogic.GenerateXAdditionalPelt(MushroomConfig.extraShyGuys, chanceShyGuys, deckInfo, DraftingMod.TribalPeltsGuid + "_Mushroom_Shy_Guy_Pelt");
			deckInfo = AddXAdditionalLogic.GenerateXAdditionalPelt(MushroomConfig.extraSpikes, chanceSpikes, deckInfo, DraftingMod.TribalPeltsGuid + "_Mushroom_Spike_Pelt");
			deckInfo = AddXAdditionalLogic.GenerateXAdditionalPelt(MushroomConfig.extraStars, chanceStars, deckInfo, DraftingMod.TribalPeltsGuid + "_Mushroom_Star_Pelt");
			deckInfo = AddXAdditionalLogic.GenerateXAdditionalPelt(MushroomConfig.extraTanukis, chanceTanukis, deckInfo, DraftingMod.TribalPeltsGuid + "_Mushroom_Tanuki_Pelt");
			deckInfo = AddXAdditionalLogic.GenerateXAdditionalPelt(MushroomConfig.extraThwomps, chanceThwomps, deckInfo, DraftingMod.TribalPeltsGuid + "_Mushroom_Thwomp_Pelt");
			deckInfo = AddXAdditionalLogic.GenerateXAdditionalPelt(MushroomConfig.extraWaddlewings, chanceWaddlewings, deckInfo, DraftingMod.TribalPeltsGuid + "_Mushroom_Waddlewing_Pelt");
			deckInfo = AddXAdditionalLogic.GenerateXAdditionalPelt(MushroomConfig.extraWigglers, chanceWigglers, deckInfo, DraftingMod.TribalPeltsGuid + "_Mushroom_Wiggler_Pelt");
			
			return deckInfo;
		}
	}
}