using HarmonyLib;
using Verse;

namespace KilledEnemyDontPushOutThings;

[HarmonyPatch(typeof(Pawn_InventoryTracker), "DropAllNearPawn")]
internal class Pawn_InventoryTracker_DropAllNearPawn
{
    private static void Prefix(ref bool forbid, ref bool unforbid)
    {
        forbid = false;
        unforbid = true;
    }
}