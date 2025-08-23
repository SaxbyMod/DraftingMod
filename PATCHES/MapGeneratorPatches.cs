using HarmonyLib;
using DiskCardGame;
using System.Collections.Generic;

namespace DraftingMod.PATCHES
{
    public class MapGeneratorPatches
    {
        // FUCKING PUT A TRADER AT THE START OF MY RUNNNNNNNN!!!!!!!!!!!!
        [HarmonyPrefix, HarmonyPatch(typeof(MapGenerator), nameof(MapGenerator.ForceFirstNodeTraderForAscension))]
        public static bool PrefixForceFirstNodeTraderForAscension(int rowIndex, MapGenerator __instance, ref bool __result)
        {
	        __result = rowIndex == 1 && RunState.Run.regionTier == 0;
            return false;
        }
    }
}