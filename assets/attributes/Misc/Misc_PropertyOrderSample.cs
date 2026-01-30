using ShadyInspector;
using UnityEngine;

public class Misc_PropertyOrderSample : ScriptableObject, ISampleCodeProvider
{
    public float first;

    [PropertyOrder(0)]
    public float second;
}