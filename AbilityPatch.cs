using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;

namespace Mod_PandaReaddAbilityMod
{
    internal class AbilityPatch
    {
        public static void OnStartCore()
        {
            SourceManager sources = Core.Instance.sources;
            foreach (SourceElement.Row row in sources.elements.rows)
            {
                string alias = row.alias;
                string text = alias;
                AbilityPatch.AbilityRewrite(row);
            }
        }

        public static void AbilityRewrite(SourceElement.Row ele)
        {
            string[] array = new string[]
            {
                "sword_"
            };

            string[] array2 = new string[]
            {
                "Meteor",
                "Earthquake"
            };

            foreach (string text in array)
            {
                if (ele.alias.Contains(text) && ele.alias != text)
                {
                    ele.tag = ele.tag.Where(s => s != "noRandomAbility").ToArray();
                }
            }

            foreach (string text in array2)
            {
                if (ele.alias.Contains(text) && ele.alias.StartsWith("Sp"))
                {
                    ele.tag = ele.tag.Where(s => s != "noRandomAbility").ToArray();
                }
            }
        }

    }
}
