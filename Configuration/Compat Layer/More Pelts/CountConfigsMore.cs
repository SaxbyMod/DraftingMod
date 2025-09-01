using BepInEx.Configuration;
using DraftingMod.Utility;

namespace DraftingMod.Configuration.Compat_Layer.More_Pelts
{
	public class CountConfigsMore
	{
		public static ConfigFile Config;
        
		// Config Vars
		public static ConfigEntry<int> extraAirs;
		public static ConfigEntry<int> extraBatterys;
		public static ConfigEntry<int> extraBears;
		public static ConfigEntry<int> extraBeavers;
		public static ConfigEntry<int> extraBones;
		public static ConfigEntry<int> extraBuffalos;
		public static ConfigEntry<int> extraFishs;
		public static ConfigEntry<int> extraGeckos;
		public static ConfigEntry<int> extraLights;
		public static ConfigEntry<int> extraMoxs;
		public static ConfigEntry<int> extraRGolds;
		public static ConfigEntry<int> extraRHares;
		public static ConfigEntry<int> extraRWolves;
		public static ConfigEntry<int> extraSBatterys;
		public static ConfigEntry<int> extraSHares;
		public static ConfigEntry<int> extraWizards;

		public static void Init()
		{
			extraAirs = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Air", 1, "Compat - More Pelts - Count");
			extraBatterys = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Battery", 1, "Compat - More Pelts - Count");
			extraBears = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Bear", 1, "Compat - More Pelts - Count");
			extraBeavers = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Beaver", 1, "Compat - More Pelts - Count");
			extraBones = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Bone", 1, "Compat - More Pelts - Count");
			extraBuffalos = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Buffalo", 1, "Compat - More Pelts - Count");
			extraFishs = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Fish", 1, "Compat - More Pelts - Count");
			extraGeckos = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Gecko", 1, "Compat - More Pelts - Count");
			extraLights = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Light", 1, "Compat - More Pelts - Count");
			extraMoxs = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Mox", 1, "Compat - More Pelts - Count");
			extraRGolds = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Rotten Gold", 1, "Compat - More Pelts - Count");
			extraRHares = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Rotten Hare", 4, "Compat - More Pelts - Count");
			extraRWolves = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Rotten Wolve", 1, "Compat - More Pelts - Count");
			extraSBatterys = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Super Battery", 1, "Compat - More Pelts - Count");
			extraSHares = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Super Gold", 1, "Compat - More Pelts - Count");
			extraWizards = AddXAdditionalLogic.GenerateXAdditionalCount(Config, "Wizard", 1, "Compat - More Pelts - Count");
		}
	}
}