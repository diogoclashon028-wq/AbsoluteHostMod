using AmongUs.GameOptions;
using HarmonyLib;

namespace AbsoluteHostMod.Patches
{
    [HarmonyPatch]
    public static class RolePatches
    {
        [HarmonyPatch(typeof(EngineerRoleOptionsV10), nameof(EngineerRoleOptionsV10.Deserialize))]
        [HarmonyPostfix]
        public static void EngineerPostfix(EngineerRoleOptionsV10 __instance)
        {
            __instance.EngineerCooldown = 0f;
            __instance.EngineerInVentMaxTime = 999f;
        }

        [HarmonyPatch(typeof(ScientistRoleOptionsV10), nameof(ScientistRoleOptionsV10.Deserialize))]
        [HarmonyPostfix]
        public static void ScientistPostfix(ScientistRoleOptionsV10 __instance)
        {
            __instance.ScientistCooldown = 0f;
            __instance.ScientistBatteryCharge = 999f;
        }

        [HarmonyPatch(typeof(TrackerRoleOptionsV10), nameof(TrackerRoleOptionsV10.Deserialize))]
        [HarmonyPostfix]
        public static void TrackerPostfix(TrackerRoleOptionsV10 __instance)
        {
            __instance.TrackerCooldown = 0f;
            __instance.TrackerDuration = 999f;
            __instance.TrackerDelay = 0f;
        }

        [HarmonyPatch(typeof(NoisemakerRoleOptionsV10), nameof(NoisemakerRoleOptionsV10.Deserialize))]
        [HarmonyPostfix]
        public static void NoisemakerPostfix(NoisemakerRoleOptionsV10 __instance)
        {
            __instance.NoisemakerAlertDuration = 0f;
        }

        [HarmonyPatch(typeof(GuardianAngelRoleOptionsV10), nameof(GuardianAngelRoleOptionsV10.Deserialize))]
        [HarmonyPostfix]
        public static void GuardianAngelPostfix(GuardianAngelRoleOptionsV10 __instance)
        {
            __instance.GuardianAngelCooldown = 0f;
            __instance.ProtectionDurationSeconds = 999f;
        }

        [HarmonyPatch(typeof(ShapeshifterRoleOptionsV10), nameof(ShapeshifterRoleOptionsV10.Deserialize))]
        [HarmonyPostfix]
        public static void ShapeshifterPostfix(ShapeshifterRoleOptionsV10 __instance)
        {
            __instance.ShapeshifterCooldown = 0f;
            __instance.ShapeshifterDuration = 999f;
        }

        [HarmonyPatch(typeof(PhantomRoleOptionsV10), nameof(PhantomRoleOptionsV10.Deserialize))]
        [HarmonyPostfix]
        public static void PhantomPostfix(PhantomRoleOptionsV10 __instance)
        {
            __instance.PhantomCooldown = 0f;
            __instance.PhantomDuration = 999f;
        }
    }
}
