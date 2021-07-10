using HarmonyLib;
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
}