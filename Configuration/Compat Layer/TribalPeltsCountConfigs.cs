using BepInEx.Configuration;

namespace DraftingMod.Compat_Layer
{
	public class TribalPeltsCountConfigs
	{
		public static ConfigFile Config;
		
		public static ConfigEntry<int> extraRavens;
		public static ConfigEntry<int> extraCoyotes;
		public static ConfigEntry<int> extraMoths;
		public static ConfigEntry<int> extraDeers;
		public static ConfigEntry<int> extraCrocadiles;

		public static void Init()
		{
			// Handle Tribal Pelts -- Base
			extraRavens = Config.Bind<int>(DraftingMod.PluginGuid + ".pelt.counts",
				"How many extra ravens for the entree?",
				1,
				"How many extra ravens should be given for the entree?");
			extraCoyotes = Config.Bind<int>(DraftingMod.PluginGuid + ".pelt.counts",
				"How many extra coyotes for the entree?",
				1,
				"How many extra coyotes should be given for the entree?");
			extraMoths = Config.Bind<int>(DraftingMod.PluginGuid + ".pelt.counts",
				"How many extra moths for the entree?",
				1,
				"How many extra moths should be given for the entree?");
			extraDeers = Config.Bind<int>(DraftingMod.PluginGuid + ".pelt.counts",
				"How many extra deers for the entree?",
				1,
				"How many extra deers should be given for the entree?");
			extraCrocadiles = Config.Bind<int>(DraftingMod.PluginGuid + ".pelt.counts",
				"How many extra crocadiles for the entree?",
				1,
				"How many extra crocadiles should be given for the entree?");
		}
	}
}