using ShadyInspector;
using UnityEngine;

public class Decorators_DisplayAsStringSample : ScriptableObject, ISampleCodeProvider
{
    [DisplayAsString]
    public string hello = "world";

    [DisplayAsString, HideLabel]
    public Texture2D texture;
}