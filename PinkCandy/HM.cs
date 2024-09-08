using HarmonyLib;
using InventorySystem.Items.Usables.Scp330;

namespace PCD
{
    [HarmonyPatch(typeof(CandyPink), "SpawnChanceWeight", MethodType.Getter)]
    public class PinkCandyPatch
    {
        public static void Postfix(ref float __result)
        {
            float candyWeight = PCD.Plugin.ConfigINE.Config.CandyWeight;
            __result = candyWeight;
        }
    }
}
