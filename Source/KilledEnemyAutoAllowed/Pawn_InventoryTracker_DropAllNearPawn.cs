using HarmonyLib;
using Verse;

namespace KilledEnemyAutoAllowed;

[HarmonyPatch(typeof(Pawn_InventoryTracker), nameof(Pawn_InventoryTracker.DropAllNearPawn))]
internal static class Pawn_InventoryTracker_DropAllNearPawn
{
    public static void Prefix(ref bool forbid, ref bool unforbid)
    {
        forbid = false;
        unforbid = true;
    }
}