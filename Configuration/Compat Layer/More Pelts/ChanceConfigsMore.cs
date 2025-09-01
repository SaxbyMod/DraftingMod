using BepInEx.Configuration;
using DraftingMod.Utility;

namespace DraftingMod.Configuration.Compat_Layer.More_Pelts
{
	public class ChanceConfigsMore
	{
		public static ConfigFile Config;
        
		// Config Vars
		public static ConfigEntry<string> extraAirPeltChance;
		public static ConfigEntry<string> extraBatteryPeltChance;
		public static ConfigEntry<string> extraBearPeltChance;
		public static ConfigEntry<string> extraBeaverPeltChance;
		public static ConfigEntry<string> extraBonePeltChance;
		public static ConfigEntry<string> extraBuffaloPeltChance;
		public static ConfigEntry<string> extraFishPeltChance;
		public static ConfigEntry<string> extraGeckoPeltChance;
		public static ConfigEntry<string> extraLightPeltChance;
		public static ConfigEntry<string> extraMoxPeltChance;
		public static ConfigEntry<string> extraRGoldPeltChance;
		public static ConfigEntry<string> extraRHarePeltChance;
		public static ConfigEntry<string> extraRWolvePeltChance;
		public static ConfigEntry<string> extraSBatteryPeltChance;
		public static ConfigEntry<string> extraSHarePeltChance;
		public static ConfigEntry<string> extraWizardPeltChance;

		public static void Init()
		{
			extraAirPeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Air", "5%", "Compat - More Pelts - Chance");
			extraBatteryPeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Battery", "10%", "Compat - More Pelts - Chance");
			extraBearPeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Bear", "1%", "Compat - More Pelts - Chance");
			extraBeaverPeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Beaver", "1.5%", "Compat - More Pelts - Chance");
			extraBonePeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Bone", "10%", "Compat - More Pelts - Chance");
			extraBuffaloPeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Buffalo", "0.5%", "Compat - More Pelts - Chance");
			extraFishPeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Fish", "1.5%", "Compat - More Pelts - Chance");
			extraGeckoPeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Gecko", "1.5%", "Compat - More Pelts - Chance");
			extraLightPeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Light", "0.001%", "Compat - More Pelts - Chance");
			extraMoxPeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Mox", "15%", "Compat - More Pelts - Chance");
			extraRGoldPeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Rotten Gold", "1.5%", "Compat - More Pelts - Chance");
			extraRHarePeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Rotten Hare", "35%, 5%, 0.5%, 0.25%", "Compat - More Pelts - Chance");
			extraRWolvePeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Rotten Wolve", "15%", "Compat - More Pelts - Chance");
			extraSBatteryPeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Super Battery", "0.005%", "Compat - More Pelts - Chance");
			extraSHarePeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Super Gold", "0.0005%", "Compat - More Pelts - Chance");
			extraWizardPeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Wizard", "10%", "Compat - More Pelts - Chance");
		}
	}
}