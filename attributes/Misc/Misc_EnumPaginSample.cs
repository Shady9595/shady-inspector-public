using System;
using ShadyInspector;
using UnityEngine;

public class Misc_EnumPagingSample : ScriptableObject, ISampleCodeProvider
{
    [EnumPaging] public SomeEnum someEnum;
    [EnumPaging] public SomeFlags someFlags;

    public enum SomeEnum
    {
        One,
        Two,
        Three
    }

    [Flags] public enum SomeFlags
    {
        A = 1 << 0,
        B = 1 << 1,
        C = 1 << 2,
        AB = A | B,
        BC = B | C,
    }
}