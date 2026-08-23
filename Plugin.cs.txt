using BepInEx;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;
using Reactor;
using UnityEngine;

namespace AbsoluteHostMod
{
    [BepInPlugin(Id, Name, Version)]
    [BepInProcess("Among Us.exe")]
    [ReactorPluginSide(PluginSide.Both)]
    public class Plugin : BasePlugin
    {
        public const string Id = "com.starlight.absolutehostmod";
        public const string Name = "AbsoluteHostMod";
        public const string Version = "1.0.0";

        public static Harmony Harmony { get; } = new Harmony(Id);

        public override void Load()
        {
            Harmony.PatchAll();
            Log.LogInfo($"{Name} v{Version} loaded");
        }
    }
}
