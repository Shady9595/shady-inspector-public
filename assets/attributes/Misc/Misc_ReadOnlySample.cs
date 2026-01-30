using ShadyInspector;
using UnityEngine;

public class Misc_ReadOnlySample : ScriptableObject, ISampleCodeProvider
{
    [ReadOnly]
    public Vector3 vec;
}