using HarmonyLib;
using Verse;

namespace KilledEnemyAutoAllowed;

[HarmonyPatch(typeof(Pawn_EquipmentTracker), nameof(Pawn_EquipmentTracker.DropAllEquipment))]
internal class Pawn_EquipmentTracker_DropAllEquipment
{
    private static void Prefix(ref bool forbid)
    {
        forbid = false;
    }
}