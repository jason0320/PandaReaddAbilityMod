using BepInEx;
using HarmonyLib;
using Mod_PandaReaddAbilityMod;
using UnityEngine;

namespace Mod_PandaInvokeMod
{

    [BepInPlugin("panda.readdability.mod", "Panda's Readd Ability Mod", "1.0.0.0")]
    public class Mod_PandaReaddAbilityMod : BaseUnityPlugin
    {
        private void Start()
        {
            var harmony = new Harmony("Panda's Readd Ability Mod");
            harmony.PatchAll();
        }
        public void OnStartCore()
        {
            AbilityPatch.OnStartCore();
        }
    }
}