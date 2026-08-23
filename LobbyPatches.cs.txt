using HarmonyLib;

namespace AbsoluteHostMod.Patches
{
    [HarmonyPatch]
    public static class LobbyCapacityPatches
    {
        public const int MaxLobbySize = 160;

        [HarmonyPatch(typeof(GameSettingMenu), nameof(GameSettingMenu.Start))]
        [HarmonyPostfix]
        public static void RemoveUiCap(GameSettingMenu __instance)
        {
            if (__instance.MaxPlayersSlider != null)
            {
                __instance.MaxPlayersSlider.ValueRange = new(1, MaxLobbySize);
                __instance.MaxPlayersSlider.Increment = 1;
            }
        }

        [HarmonyPatch(typeof(GameOptionsData), nameof(GameOptionsData.MaxPlayers), MethodType.Getter)]
        [HarmonyPostfix]
        public static void ForceMaxPlayers(ref int __result)
        {
            if (__result < MaxLobbySize)
                __result = MaxLobbySize;
        }
    }
}
