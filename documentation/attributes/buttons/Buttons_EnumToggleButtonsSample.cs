using System;
using UnityEngine;
using ShadyInspector;

public class Buttons_EnumToggleButtonsSample :  ScriptableObject, ISampleCodeProvider
{   
    public string SampleSource => @"using System;
using UnityEngine;
using ShadyInspector;

public class Buttons_EnumToggleButtonsSample : ScriptableObject
{   
    [EnumToggleButtons] public SomeEnum someEnum;
    [EnumToggleButtons] public SomeFlags someFlags;

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
}";
    [EnumToggleButtons] public SomeEnum someEnum;
    [EnumToggleButtons] public SomeFlags someFlags;

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