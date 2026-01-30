using ShadyInspector;
using UnityEngine;

public class Conditionals_EnableIfSample : ScriptableObject, ISampleCodeProvider
{
    public bool visible;

    [EnableIf(nameof(visible))]
    public float val;
}