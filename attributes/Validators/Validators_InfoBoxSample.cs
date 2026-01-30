using System;
using ShadyInspector;
using UnityEngine;

public class Validators_InfoBoxSample : ScriptableObject, ISampleCodeProvider
{
    [Title("InfoBox Message Types")]
    [InfoBox("Default info box")]
    public int a;

    [InfoBox("None info box", ShadyMessageType.None)]
    public int b;

    [InfoBox("Warning info box", ShadyMessageType.Warning)]
    public int c;

    [InfoBox("Error info box", ShadyMessageType.Error)]
    public int d;

    [InfoBox("$" + nameof(DynamicInfo), visibleIf: nameof(VisibleInEditMode))]
    public Vector3 vec;

    private string DynamicInfo => "Dynamic info box: " + DateTime.Now.ToLongTimeString();

    private bool VisibleInEditMode => !Application.isPlaying;
}