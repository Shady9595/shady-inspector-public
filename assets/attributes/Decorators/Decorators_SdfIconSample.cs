using ShadyInspector;
using UnityEngine;

public class Decorators_SdfIconSample : ScriptableObject, ISampleCodeProvider
{
    [SdfIcon(SdfIconType.Alarm)]
    public string hello = "world";

    [SdfIcon(SdfIconType.Bicycle)]
    public Texture2D texture;
}
