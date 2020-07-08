using HarmonyLib;
using RimWorld;
using Verse;

namespace KilledEnemyDontPushOutThings
{
    [StaticConstructorOnStartup]
    public static class Mod
    {
        public const string Name = "KilledEnemyAutoAllowed";
        static Mod()
        {
            new Harmony("Mlie.KilledEnemyAutoAllowed").PatchAll();
        }
    }
    [HarmonyPatch(typeof(Pawn_EquipmentTracker), "DropAllEquipment")]
    class Patch1
    {
        static void Prefix(ref IntVec3 pos, ref bool forbid)
        {
            forbid = false;
        }
    }    
    [HarmonyPatch(typeof(Pawn_InventoryTracker), "DropAllNearPawn")]
    class Patch2
    {
        static void Prefix(ref IntVec3 pos, ref bool forbid, ref bool unforbid)
        {
            forbid = false;
            unforbid = true;
        }
    }
    [HarmonyPatch(typeof(ForbidUtility), "SetForbiddenIfOutsideHomeArea")]
    class Patch3
    {
        static bool Prefix(ref Thing t)
        {
            if (!t.Spawned)
            {
                Log.Error("SetForbiddenIfOutsideHomeArea unspawned thing " + t, false);
            }
            return false;
        }
    }
}