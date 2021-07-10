using HarmonyLib;
using Verse;

namespace KilledEnemyDontPushOutThings
{
    [HarmonyPatch(typeof(Pawn_EquipmentTracker), "DropAllEquipment")]
    internal class Patch1
    {
        private static void Prefix(ref bool forbid)
        {
            forbid = false;
        }
    }
}