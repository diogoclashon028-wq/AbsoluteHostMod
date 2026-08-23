using HarmonyLib;

namespace AbsoluteHostMod.Patches
{
    [HarmonyPatch]
    public static class ImpostorPatches
    {
        [HarmonyPatch(typeof(GameOptionsData), nameof(GameOptionsData.SetInt))]
        [HarmonyPrefix]
        public static void RemoveImpostorCountClamp(GameOptionsData __instance, ref IntOptionNames option, ref int value)
        {
            if (option == IntOptionNames.NumImpostors)
            {
                int maxPlayers = LobbyPatches.LobbyCapacityPatches.MaxLobbySize;
                value = System.Math.Clamp(value, 1, maxPlayers - 1);
            }
        }

        [HarmonyPatch(typeof(GameOptionsData), nameof(GameOptionsData.KillCooldown), MethodType.Getter)]
        [HarmonyPostfix]
        public static void AllowZeroKillCooldown(ref float __result)
        {
            if (__result < 0f) __result = 0f;
        }

        [HarmonyPatch(typeof(GameOptionsData), nameof(GameOptionsData.ImpostorLightMod), MethodType.Getter)]
        [HarmonyPostfix]
        public static void ExpandImpostorVision(ref float __result)
        {
            const float maxVision = 10f;
            if (__result > maxVision) __result = maxVision;
        }

        [HarmonyPatch(typeof(GameOptionsData), nameof(GameOptionsData.KillDistance), MethodType.Getter)]
        [HarmonyPostfix]
        public static void ExpandKillDistance(ref float __result)
        {
            const float maxKillDistance = 999f;
            if (__result > maxKillDistance) __result = maxKillDistance;
        }
    }
}
