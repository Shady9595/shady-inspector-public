using ShadyInspector;
using UnityEngine;

public class Conditionals_HideIfSample : ScriptableObject, ISampleCodeProvider
{
    public bool visible;

    [HideIf(nameof(visible))]
    public float val;
}