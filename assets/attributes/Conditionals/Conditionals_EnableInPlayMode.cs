using ShadyInspector;
using UnityEngine;

public class Conditionals_EnableInPlayMode : ScriptableObject, ISampleCodeProvider
{
    [EnableInPlayMode]
    public float val;
}