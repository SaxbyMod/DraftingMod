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
			extraAirPeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Air", "15%", "Compat - More Pelts - Chance");
			extraBatteryPeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Battery", "20%", "Compat - More Pelts - Chance");
			extraBearPeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Bear", "10%", "Compat - More Pelts - Chance");
			extraBeaverPeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Beaver", "2.5%", "Compat - More Pelts - Chance");
			extraBonePeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Bone", "20%", "Compat - More Pelts - Chance");
			extraBuffaloPeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Buffalo", "5%", "Compat - More Pelts - Chance");
			extraFishPeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Fish", "15%", "Compat - More Pelts - Chance");
			extraGeckoPeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Gecko", "15%", "Compat - More Pelts - Chance");
			extraLightPeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Light", "0.01%", "Compat - More Pelts - Chance");
			extraMoxPeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Mox", "25%", "Compat - More Pelts - Chance");
			extraRGoldPeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Rotten Gold", "15%", "Compat - More Pelts - Chance");
			extraRHarePeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Rotten Hare", "45%, 25%, 5%, 0.25%", "Compat - More Pelts - Chance");
			extraRWolvePeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Rotten Wolve", "25%", "Compat - More Pelts - Chance");
			extraSBatteryPeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Super Battery", "0.05%", "Compat - More Pelts - Chance");
			extraSHarePeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Super Gold", "0.005%", "Compat - More Pelts - Chance");
			extraWizardPeltChance = AddXAdditionalLogic.GenerateXAdditionalChance(Config, "Wizard", "20%", "Compat - More Pelts - Chance");
		}
	}
}