using ShadyInspector;
using UnityEngine;

public class Decorators_SwitchSample : ScriptableObject, ISampleCodeProvider
{
    [Switch]
    public bool test = true;

    [Switch]
    public bool temp = false;
}
