using HarmonyLib;
using RimWorld;
using Verse;

namespace KilledEnemyDontPushOutThings
{
    [HarmonyPatch(typeof(ForbidUtility), "SetForbiddenIfOutsideHomeArea")]
    internal class Patch3
    {
        private static bool Prefix(ref Thing t)
        {
            if (!t.Spawned)
            {
                Log.Error("SetForbiddenIfOutsideHomeArea unspawned thing " + t);
            }

            return false;
        }
    }
}