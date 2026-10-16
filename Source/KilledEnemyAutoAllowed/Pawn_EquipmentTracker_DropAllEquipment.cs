using HarmonyLib;
using Verse;

namespace KilledEnemyAutoAllowed;

[HarmonyPatch(typeof(Pawn_EquipmentTracker), nameof(Pawn_EquipmentTracker.DropAllEquipment))]
internal static class Pawn_EquipmentTracker_DropAllEquipment
{
    public static void Prefix(ref bool forbid)
    {
        forbid = false;
    }
}