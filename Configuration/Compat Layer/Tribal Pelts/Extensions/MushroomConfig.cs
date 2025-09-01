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
			extraBlasters = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Blaster", 1, "Compat - Tribal Pelts - Mushroom Pelts - Count");
			extraBlocks = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Block", 1, "Compat - Tribal Pelts - Mushroom Pelts - Count");
			extraBloopers = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Blooper", 1, "Compat - Tribal Pelts - Mushroom Pelts - Count");
			extraBobOmbs = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Bob-Omb", 1, "Compat - Tribal Pelts - Mushroom Pelts - Count");
			extraBoos = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Boo", 1, "Compat - Tribal Pelts - Mushroom Pelts - Count");
			extraChainChomps = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Chain Chomp", 1, "Compat - Tribal Pelts - Mushroom Pelts - Count");
			extraCheepCheeps = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Cheep Cheep", 1, "Compat - Tribal Pelts - Mushroom Pelts - Count");
			extraConkdors = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Conkdor", 1, "Compat - Tribal Pelts - Mushroom Pelts - Count");
			extraDragons = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Dragon", 1, "Compat - Tribal Pelts - Mushroom Pelts - Count");
			extraDryBones = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Dry Bone", 1, "Compat - Tribal Pelts - Mushroom Pelts - Count");
			extraGoombas = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Goomba", 1, "Compat - Tribal Pelts - Mushroom Pelts - Count");
			extraKoopas = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Koopa", 1, "Compat - Tribal Pelts - Mushroom Pelts - Count");
			extraPiranhas = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Piranha", 1, "Compat - Tribal Pelts - Mushroom Pelts - Count");
			extraPokeys = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Pokey", 1, "Compat - Tribal Pelts - Mushroom Pelts - Count");
			extraPowerUps = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Power Up", 1, "Compat - Tribal Pelts - Mushroom Pelts - Count");
			extraRams = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Ram", 1, "Compat - Tribal Pelts - Mushroom Pelts - Count");
			extraShroobs = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Shroob", 1, "Compat - Tribal Pelts - Mushroom Pelts - Count");
			extraShyGuys = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Shy Guy", 1, "Compat - Tribal Pelts - Mushroom Pelts - Count");
			extraSpikes = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Spike", 1, "Compat - Tribal Pelts - Mushroom Pelts - Count");
			extraStars = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Star", 1, "Compat - Tribal Pelts - Mushroom Pelts - Count");
			extraTanukis = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Tanuki", 1, "Compat - Tribal Pelts - Mushroom Pelts - Count");
			extraThwomps = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Thwomp", 1, "Compat - Tribal Pelts - Mushroom Pelts - Count");
			extraWaddlewings = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Waddlewing", 1, "Compat - Tribal Pelts - Mushroom Pelts - Count");
			extraWigglers = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Wiggler", 1, "Compat - Tribal Pelts - Mushroom Pelts - Count");
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
			extraBlasterPeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Blaster", "15%", "Compat - Tribal Pelts - Mushroom Pelts - Chance");
			extraBlockPeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Block", "15%", "Compat - Tribal Pelts - Mushroom Pelts - Chance");
			extraBlooperPeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Blooper", "15%", "Compat - Tribal Pelts - Mushroom Pelts - Chance");
			extraBobOmbPeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Bob-Omb", "15%", "Compat - Tribal Pelts - Mushroom Pelts - Chance");
			extraBooPeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Boo", "15%", "Compat - Tribal Pelts - Mushroom Pelts - Chance");
			extraChainChompPeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Chain Chomp", "15%", "Compat - Tribal Pelts - Mushroom Pelts - Chance");
			extraCheepCheepPeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Cheep Cheep", "15%", "Compat - Tribal Pelts - Mushroom Pelts - Chance");
			extraConkdorPeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Conkdor", "15%", "Compat - Tribal Pelts - Mushroom Pelts - Chance");
			extraDragonPeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Dragon", "15%", "Compat - Tribal Pelts - Mushroom Pelts - Chance");
			extraDryBonePeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Dry Bone", "15%", "Compat - Tribal Pelts - Mushroom Pelts - Chance");
			extraGoombaPeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Goomba", "15%", "Compat - Tribal Pelts - Mushroom Pelts - Chance");
			extraKoopaPeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Koopa", "15%", "Compat - Tribal Pelts - Mushroom Pelts - Chance");
			extraPiranhaPeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Piranha", "15%", "Compat - Tribal Pelts - Mushroom Pelts - Chance");
			extraPokeyPeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Pokey", "15%", "Compat - Tribal Pelts - Mushroom Pelts - Chance");
			extraPowerUpPeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Power Up", "15%", "Compat - Tribal Pelts - Mushroom Pelts - Chance");
			extraRamPeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Ram", "15%", "Compat - Tribal Pelts - Mushroom Pelts - Chance");
			extraShroobPeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Shroob", "15%", "Compat - Tribal Pelts - Mushroom Pelts - Chance");
			extraShyGuyPeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Shy Guy", "15%", "Compat - Tribal Pelts - Mushroom Pelts - Chance");
			extraSpikePeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Spike", "15%", "Compat - Tribal Pelts - Mushroom Pelts - Chance");
			extraStarPeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Star", "15%", "Compat - Tribal Pelts - Mushroom Pelts - Chance");
			extraTanukiPeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Tanuki", "15%", "Compat - Tribal Pelts - Mushroom Pelts - Chance");
			extraThwompPeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Thwomp", "15%", "Compat - Tribal Pelts - Mushroom Pelts - Chance");
			extraWaddlewingPeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Waddlewing", "15%", "Compat - Tribal Pelts - Mushroom Pelts - Chance");
			extraWigglerPeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Wiggler", "15%", "Compat - Tribal Pelts - Mushroom Pelts - Chance");
		}
	}
}