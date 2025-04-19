using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;

namespace Mod_PandaReaddAbilityMod
{
    [HarmonyPatch(typeof(CharaAbility))]
    [HarmonyPatch(nameof(CharaAbility.BuildRandomAbilityList))]
    internal class CharaAbility_BuildRandomAbilityList_Patch
    {
        static void Prefix(ref bool adv)
        {
            adv = true;
        }
    }
}
