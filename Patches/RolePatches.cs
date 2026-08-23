using HarmonyLib;

namespace AbsoluteHostMod.Patches
{
    [HarmonyPatch]
    public static class RolePatches
    {
        [HarmonyPatch(typeof(EngineerRole), nameof(EngineerRole.NumVents), MethodType.Getter)]
        [HarmonyPostfix]
        public static void EngineerUnlimitedVents(ref int __result) => __result = 999;

        [HarmonyPatch(typeof(EngineerRole), nameof(EngineerRole.UsesLeft), MethodType.Getter)]
        [HarmonyPostfix]
        public static void EngineerUnlimitedUses(ref int __result) => __result = 999;

        [HarmonyPatch(typeof(ScientistRole), nameof(ScientistRole.VitalsCooldown), MethodType.Getter)]
        [HarmonyPostfix]
        public static void ScientistZeroVitalsCooldown(ref float __result) => __result = 0f;

        [HarmonyPatch(typeof(ScientistRole), nameof(ScientistRole.BatteryCharge), MethodType.Getter)]
        [HarmonyPostfix]
        public static void ScientistInfiniteBattery(ref float __result) => __result = float.MaxValue;

        [HarmonyPatch(typeof(TrackerRole), nameof(TrackerRole.UpdateInterval), MethodType.Getter)]
        [HarmonyPostfix]
        public static void TrackerRealtime(ref float __result) => __result = 0f;

        [HarmonyPatch(typeof(NoisemakerRole), nameof(NoisemakerRole.AlertCooldown), MethodType.Getter)]
        [HarmonyPostfix]
        public static void NoisemakerZeroCooldown(ref float __result) => __result = 0f;

        [HarmonyPatch(typeof(GuardianAngelRole), nameof(GuardianAngelRole.ProtectDuration), MethodType.Getter)]
        [HarmonyPostfix]
        public static void GuardianAngelInfiniteShield(ref float __result) => __result = float.MaxValue;

        [HarmonyPatch(typeof(GuardianAngelRole), nameof(GuardianAngelRole.ProtectCooldown), MethodType.Getter)]
        [HarmonyPostfix]
        public static void GuardianAngelZeroCooldown(ref float __result) => __result = 0f;

        [HarmonyPatch(typeof(ShapeshifterRole), nameof(ShapeshifterRole.ShapeshiftCooldown), MethodType.Getter)]
        [HarmonyPostfix]
        public static void ShapeshifterZeroCooldown(ref float __result) => __result = 0f;

        [HarmonyPatch(typeof(ShapeshifterRole), nameof(ShapeshifterRole.ShapeshiftDuration), MethodType.Getter)]
        [HarmonyPostfix]
        public static void ShapeshifterInfiniteDuration(ref float __result) => __result = float.MaxValue;

        [HarmonyPatch(typeof(PhantomRole), nameof(PhantomRole.InvisibleDuration), MethodType.Getter)]
        [HarmonyPostfix]
        public static void PhantomInfiniteInvisibility(ref float __result) => __result = float.MaxValue;

        [HarmonyPatch(typeof(PhantomRole), nameof(PhantomRole.InvisibleCooldown), MethodType.Getter)]
        [HarmonyPostfix]
        public static void PhantomZeroCooldown(ref float __result) => __result = 0f;
    }
}
