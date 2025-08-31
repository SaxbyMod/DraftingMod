using BepInEx.Configuration;
using DraftingMod.Utility;

namespace DraftingMod.Configuration.Compat_Layer.Tribal_Pelts.Extensions
{
	public class MushroomConfig
	{
		public static ConfigFile Config;
		
		public static ConfigEntry<int> extraBlasters;
		public static ConfigEntry<int> extraBlocks;
		public static ConfigEntry<int> extraBloopers;
		public static ConfigEntry<int> extraBobOmbs;
		public static ConfigEntry<int> extraBoos;
		public static ConfigEntry<int> extraChainChomps;
		public static ConfigEntry<int> extraCheepCheeps;
		public static ConfigEntry<int> extraConkdors;
		public static ConfigEntry<int> extraDragons;
		public static ConfigEntry<int> extraDryBones;
		public static ConfigEntry<int> extraGoombas;
		public static ConfigEntry<int> extraKoopas;
		public static ConfigEntry<int> extraPiranhas;
		public static ConfigEntry<int> extraPokeys;
		public static ConfigEntry<int> extraPowerUps;
		public static ConfigEntry<int> extraRams;
		public static ConfigEntry<int> extraShroobs;
		public static ConfigEntry<int> extraShyGuys;
		public static ConfigEntry<int> extraSpikes;
		public static ConfigEntry<int> extraStars;
		public static ConfigEntry<int> extraTanukis;
		public static ConfigEntry<int> extraThwomps;
		public static ConfigEntry<int> extraWaddlewings;
		public static ConfigEntry<int> extraWigglers;
		
		public static void MushroomExtensionCount()
		{
			extraBlasters = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Blaster", 1);
			extraBlocks = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Block", 1);
			extraBloopers = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Blooper", 1);
			extraBobOmbs = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Bob-Omb", 1);
			extraBoos = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Boo", 1);
			extraChainChomps = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Chain Chomp", 1);
			extraCheepCheeps = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Cheep Cheep", 1);
			extraConkdors = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Conkdor", 1);
			extraDragons = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Dragon", 1);
			extraDryBones = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Dry Bone", 1);
			extraGoombas = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Goomba", 1);
			extraKoopas = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Koopa", 1);
			extraPiranhas = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Piranha", 1);
			extraPokeys = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Pokey", 1);
			extraPowerUps = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Power Up", 1);
			extraRams = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Ram", 1);
			extraShroobs = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Shroob", 1);
			extraShyGuys = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Shy Guy", 1);
			extraSpikes = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Spike", 1);
			extraStars = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Star", 1);
			extraTanukis = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Tanuki", 1);
			extraThwomps = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Thwomp", 1);
			extraWaddlewings = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Waddlewing", 1);
			extraWigglers = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Wiggler", 1);
		}
		
		public static ConfigEntry<string> extraBlasterPeltChance;
		public static ConfigEntry<string> extraBlockPeltChance;
		public static ConfigEntry<string> extraBlooperPeltChance;
		public static ConfigEntry<string> extraBobOmbPeltChance;
		public static ConfigEntry<string> extraBooPeltChance;
		public static ConfigEntry<string> extraChainChompPeltChance;
		public static ConfigEntry<string> extraCheepCheepPeltChance;
		public static ConfigEntry<string> extraConkdorPeltChance;
		public static ConfigEntry<string> extraDragonPeltChance;
		public static ConfigEntry<string> extraDryBonePeltChance;
		public static ConfigEntry<string> extraGoombaPeltChance;
		public static ConfigEntry<string> extraKoopaPeltChance;
		public static ConfigEntry<string> extraPiranhaPeltChance;
		public static ConfigEntry<string> extraPokeyPeltChance;
		public static ConfigEntry<string> extraPowerUpPeltChance;
		public static ConfigEntry<string> extraRamPeltChance;
		public static ConfigEntry<string> extraShroobPeltChance;
		public static ConfigEntry<string> extraShyGuyPeltChance;
		public static ConfigEntry<string> extraSpikePeltChance;
		public static ConfigEntry<string> extraStarPeltChance;
		public static ConfigEntry<string> extraTanukiPeltChance;
		public static ConfigEntry<string> extraThwompPeltChance;
		public static ConfigEntry<string> extraWaddlewingPeltChance;
		public static ConfigEntry<string> extraWigglerPeltChance;
		
		public static void MushroomExtensionChance()
		{
			extraBlasterPeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Blaster", "25%");
			extraBlockPeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Block", "25%");
			extraBlooperPeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Blooper", "25%");
			extraBobOmbPeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Bob-Omb", "25%");
			extraBooPeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Boo", "25%");
			extraChainChompPeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Chain Chomp", "25%");
			extraCheepCheepPeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Cheep Cheep", "25%");
			extraConkdorPeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Conkdor", "25%");
			extraDragonPeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Dragon", "25%");
			extraDryBonePeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Dry Bone", "25%");
			extraGoombaPeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Goomba", "25%");
			extraKoopaPeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Koopa", "25%");
			extraPiranhaPeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Piranha", "25%");
			extraPokeyPeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Pokey", "25%");
			extraPowerUpPeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Power Up", "25%");
			extraRamPeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Ram", "25%");
			extraShroobPeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Shroob", "25%");
			extraShyGuyPeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Shy Guy", "25%");
			extraSpikePeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Spike", "25%");
			extraStarPeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Star", "25%");
			extraTanukiPeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Tanuki", "25%");
			extraThwompPeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Thwomp", "25%");
			extraWaddlewingPeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Waddlewing", "25%");
			extraWigglerPeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Wiggler", "25%");
		}
	}
}