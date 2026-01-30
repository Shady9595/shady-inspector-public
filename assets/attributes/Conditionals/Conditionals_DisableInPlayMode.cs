using ShadyInspector;
using UnityEngine;

public class Conditionals_DisableInPlayMode : ScriptableObject, ISampleCodeProvider
{
    [DisableInPlayMode]
    public float val;
}