using HarmonyLib;
using Verse;

namespace KilledEnemyDontPushOutThings;

[StaticConstructorOnStartup]
public static class Mod
{
    static Mod()
    {
        new Harmony("Mlie.KilledEnemyAutoAllowed").PatchAll();
    }
}