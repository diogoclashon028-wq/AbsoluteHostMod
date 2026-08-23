using HarmonyLib;

namespace AbsoluteHostMod.Patches
{
    [HarmonyPatch]
    public static class CrewmatePatches
    {
        [HarmonyPatch(typeof(GameOptionsData), nameof(GameOptionsData.PlayerSpeedMod), MethodType.Getter)]
        [HarmonyPostfix]
        public static void ExpandSpeed(ref float __result)
        {
            __result = System.Math.Clamp(__result, 0.1f, 10f);
        }

        [HarmonyPatch(typeof(GameOptionsData), nameof(GameOptionsData.CrewLightMod), MethodType.Getter)]
        [HarmonyPostfix]
        public static void ExpandCrewVision(ref float __result)
        {
            __result = System.Math.Clamp(__result, 0f, 10f);
        }
    }
}
