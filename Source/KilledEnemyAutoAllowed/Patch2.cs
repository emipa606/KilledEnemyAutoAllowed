using HarmonyLib;
using Verse;

namespace KilledEnemyDontPushOutThings
{
    [HarmonyPatch(typeof(Pawn_InventoryTracker), "DropAllNearPawn")]
    internal class Patch2
    {
        private static void Prefix(ref bool forbid, ref bool unforbid)
        {
            forbid = false;
            unforbid = true;
        }
    }
}