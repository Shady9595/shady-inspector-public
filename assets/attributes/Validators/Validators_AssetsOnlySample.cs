using ShadyInspector;
using UnityEngine;

public class Validators_AssetsOnlySample : ScriptableObject, ISampleCodeProvider
{
    [AssetsOnly]
    public GameObject obj;
}