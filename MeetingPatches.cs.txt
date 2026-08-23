using HarmonyLib;

namespace AbsoluteHostMod.Patches
{
    [HarmonyPatch]
    public static class MeetingPatches
    {
        [HarmonyPatch(typeof(GameOptionsData), nameof(GameOptionsData.DiscussionTime), MethodType.Getter)]
        [HarmonyPostfix]
        public static void ExpandDiscussionTime(ref int __result)
        {
            __result = System.Math.Clamp(__result, 0, 999);
        }

        [HarmonyPatch(typeof(GameOptionsData), nameof(GameOptionsData.VotingTime), MethodType.Getter)]
        [HarmonyPostfix]
        public static void ExpandVotingTime(ref int __result)
        {
            __result = System.Math.Clamp(__result, 0, 999);
        }

        [HarmonyPatch(typeof(GameOptionsData), nameof(GameOptionsData.NumEmergencyMeetings), MethodType.Getter)]
        [HarmonyPostfix]
        public static void ExpandEmergencyMeetings(ref int __result)
        {
            __result = System.Math.Clamp(__result, 0, 99);
        }
    }
}
