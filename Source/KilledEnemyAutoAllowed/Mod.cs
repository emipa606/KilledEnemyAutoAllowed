using System.Reflection;
using HarmonyLib;
using Verse;

namespace KilledEnemyAutoAllowed;

[StaticConstructorOnStartup]
public static class Mod
{
    static Mod()
    {
        new Harmony("Mlie.KilledEnemyAutoAllowed").PatchAll(Assembly.GetExecutingAssembly());
    }
}