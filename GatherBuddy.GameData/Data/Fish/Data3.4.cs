using GatherBuddy.Enums;

namespace GatherBuddy.Data;

public static partial class Fish
{
    // @formatter:off
    private static void ApplySoulSurrender(this GameData data)
    {
        data.Apply     (16742, Patch.SoulSurrender) // Dimorphodon
            .Mooch     (data, 12712, 12805)
            .Bite      (HookSet.Powerful, BiteType.Legendary)
            .Transition(data, 1)
            .Weather   (data, 6);
        data.Apply     (16743, Patch.SoulSurrender) // Basking Shark
            .Mooch     (data, 28634, 12753)
            .Bite      (HookSet.Powerful, BiteType.Legendary)
            .Transition(data, 4)
            .Weather   (data, 1);
        data.Apply     (16744, Patch.SoulSurrender) // Allagan Bladeshark
            .Mooch     (data, 30136, 12776)
            .Bite      (HookSet.Powerful, BiteType.Legendary)
            .Transition(data, 3)
            .Weather   (data, 9);
        data.Apply     (16745, Patch.SoulSurrender) // Hailfinder
            .Mooch     (data, 12708, 12724)
            .Bite      (HookSet.Precise, BiteType.Legendary)
            .Transition(data, 16, 15)
            .Weather   (data, 16);
        data.Apply     (16746, Patch.SoulSurrender) // Flarefish
            .Mooch     (data, 28634, 12715)
            .Bite      (HookSet.Powerful, BiteType.Legendary)
            .Time      (600, 1080)
            .Weather   (data, 16);
        data.Apply     (16747, Patch.SoulSurrender) // Twin-tongued Carp
            .Bait      (data, 12711)
            .Bite      (HookSet.Powerful, BiteType.Legendary)
            .Time      (720, 960)
            .Transition(data, 3, 4, 11)
            .Weather   (data, 1);
        data.Apply     (16748, Patch.SoulSurrender) // Madam Butterfly
            .Mooch     (data, 12705, 12757)
            .Bite      (HookSet.Powerful, BiteType.Legendary)
            .Time      (1260, 120)
            .Weather   (data, 1);
        data.Apply     (16749, Patch.SoulSurrender) // Moggle Mogpom
            .Bait      (data, 12711)
            .Bite      (HookSet.Precise, BiteType.Legendary)
            .Time      (600, 780)
            .Transition(data, 6)
            .Weather   (data, 1);
        data.Apply     (16750, Patch.SoulSurrender) // Cirrostratus
            .Bait      (data, 12712)
            .Bite      (HookSet.Powerful, BiteType.Legendary)
            .Time      (600, 780)
            .Weather   (data, 2, 1);
        data.Apply     (16751, Patch.SoulSurrender) // Hraesvelgr's Tear
            .Bait      (data, 12709)
            .Bite      (HookSet.Precise, BiteType.Legendary)
            .Time      (120, 360);
        data.Apply     (16752, Patch.SoulSurrender) // Aetherochemical Compound #666
            .Mooch     (data, 12710, 12776)
            .Bite      (HookSet.Precise, BiteType.Legendary);
        data.Apply     (16753, Patch.SoulSurrender) // Hundred-eyed Axolotl
            .Mooch     (data, 12705, 12777)
            .Bite      (HookSet.Precise, BiteType.Legendary)
            .Time      (360, 600);
        data.Apply     (16754, Patch.SoulSurrender) // Bobgoblin Bass
            .Mooch     (data, 12706, 12780)
            .Bite      (HookSet.Powerful, BiteType.Legendary)
            .Time      (120, 360)
            .Transition(data, 7)
            .Weather   (data, 8);
        data.Apply     (16756, Patch.SoulSurrender) // Merciless
            .Mooch     (data, 2607, 12715)
            .Bite      (HookSet.Powerful, BiteType.Legendary)
            .Transition(data, 15, 16)
            .Weather   (data, 16);
    }
    // @formatter:on
}
