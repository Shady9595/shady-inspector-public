using ShadyInspector;
using UnityEngine;

[DeclareHorizontalGroup("horizontal")]
[DeclareVerticalGroup("horizontal/vars")]
[DeclareVerticalGroup("horizontal/buttons")]
public class Groups_VerticalGroupSample : ScriptableObject, ISampleCodeProvider
{
    [Group("horizontal/vars")] public float a;
    [Group("horizontal/vars")] public float b;

    [Button, Group("horizontal/buttons")]
    public void ButtonA()
    {
    }

    [Button, Group("horizontal/buttons")]
    public void ButtonB()
    {
    }
}