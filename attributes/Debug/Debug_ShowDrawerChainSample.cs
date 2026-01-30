using ShadyInspector;
using UnityEngine;

public class Debug_ShowDrawerChainSample : ScriptableObject, ISampleCodeProvider
{
    [ShowDrawerChain]
    [Indent]
    [PropertySpace]
    [Title("Custom Title")]
    [GUIColor(1.0f, 0.8f, 0.8f)]
    public Vector3 vec;
}