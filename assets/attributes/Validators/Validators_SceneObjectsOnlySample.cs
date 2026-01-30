using ShadyInspector;
using UnityEngine;

public class Validators_SceneObjectsOnlySample : ScriptableObject, ISampleCodeProvider
{
    [SceneObjectsOnly]
    public GameObject obj;
}