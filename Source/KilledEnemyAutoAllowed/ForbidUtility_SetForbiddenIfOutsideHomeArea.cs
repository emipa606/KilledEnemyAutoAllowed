using HarmonyLib;
using RimWorld;
using Verse;

namespace KilledEnemyAutoAllowed;

[HarmonyPatch(typeof(ForbidUtility), nameof(ForbidUtility.SetForbiddenIfOutsideHomeArea))]
internal static class ForbidUtility_SetForbiddenIfOutsideHomeArea
{
    public static bool Prefix(ref Thing t)
    {
        if (!t.Spawned)
        {
            Log.Error($"SetForbiddenIfOutsideHomeArea unspawned thing {t}");
        }

        return false;
    }
}