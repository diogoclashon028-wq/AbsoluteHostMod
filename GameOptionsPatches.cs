using System;
using AmongUs.GameOptions;
using HarmonyLib;

namespace AbsoluteHostMod.Patches
{
    [HarmonyPatch]
    public static class GameOptionsPatches
    {
        public const int MaxLobbySize = 160;

        [HarmonyPatch(typeof(NormalGameOptionsV10), nameof(NormalGameOptionsV10.Deserialize))]
        [HarmonyPostfix]
        public static void OverrideOptions(ref NormalGameOptionsV10 __result)
        {
            if (__result == null) return;

            __result.MaxPlayers = MaxLobbySize;
            __result.NumImpostors = Math.Clamp(__result.NumImpostors, 1, MaxLobbySize - 1);

            __result.KillCooldown = 0f;
            __result.PlayerSpeedMod = Math.Clamp(__result.PlayerSpeedMod, 0.1f, 10f);
            __result.CrewLightMod = Math.Clamp(__result.CrewLightMod, 0f, 10f);
            __result.ImpostorLightMod = Math.Clamp(__result.ImpostorLightMod, 0f, 10f);

            __result.NumEmergencyMeetings = Math.Clamp(__result.NumEmergencyMeetings, 0, 99);
            __result.EmergencyCooldown = Math.Clamp(__result.EmergencyCooldown, 0, 999);
        }
    }
}
