using ShadyInspector;
using UnityEngine;

public class Conditionals_HideInPlayMode : ScriptableObject, ISampleCodeProvider
{
    [HideInPlayMode]
    public float val;
}