using System.Collections.Generic;
using PermitSaveEditor.Objects;

namespace PermitSaveEditor.Data;

public static class Extensions
{
    public static Objects.Color ToObjectsColor(this System.Windows.Media.Color color)
        => new(color.R / 255.0, color.G / 255.0, color.B / 255.0, color.A / 255.0);

    public static void UnlockAll(this List<bool> list)
    {
        for (var i = 0; i < list.Count; i++)
            list[i] = true;
    }

    public static void HealAll(this List<NpcHealthDataList> list)
        => list.ForEach(x =>
        {
            x.CureDelayCnt = 0;
            x.IsCure = false;
            x.IsSick = false;
            x.NpcHP = 10;
        });
}