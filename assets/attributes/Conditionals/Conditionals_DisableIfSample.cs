using ShadyInspector;
using UnityEngine;

public class Conditionals_DisableIfSample : ScriptableObject, ISampleCodeProvider
{
    public bool visible;

    [DisableIf(nameof(visible))]
    public float val;
}