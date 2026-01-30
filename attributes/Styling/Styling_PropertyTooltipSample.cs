using System;
using ShadyInspector;
using UnityEngine;

public class Styling_PropertyTooltipSample : ScriptableObject, ISampleCodeProvider
{
    [PropertyTooltip("This is tooltip")]
    public Rect rect;

    [PropertyTooltip("$" + nameof(DynamicTooltip))]
    public Vector3 vec;

    public string DynamicTooltip => DateTime.Now.ToShortTimeString();
}