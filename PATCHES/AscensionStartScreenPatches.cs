using HarmonyLib;
using DiskCardGame;

namespace DraftingMod.PATCHES
{
    public class AscensionStartScreenPatches
    {
        // Patch the Ascension starterdeck screen
        [HarmonyPrefix, HarmonyPatch(typeof(AscensionStartScreen), nameof(AscensionStartScreen.OnNewRunSelected))]
        public static bool PrefixOnNewRunSelected(AscensionStartScreen __instance)
        {
            CommandLineTextDisplayer.PlayCommandLineClickSound();
            if (__instance.RunExists)
            {
                Singleton<AscensionMenuScreens>.Instance.SwitchToScreen(AscensionMenuScreens.Screen.NewRunConfirm);
                __instance.newRunConfirmButton.screenToReturnTo = AscensionMenuScreens.Screen.SelectChallenges;
            }
            else
            {
                Singleton<AscensionMenuScreens>.Instance.SwitchToScreen(AscensionMenuScreens.Screen.SelectChallenges);
            }

            return false;
        }
    }
}