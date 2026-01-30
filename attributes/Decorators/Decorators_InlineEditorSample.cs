using ShadyInspector;
using UnityEngine;

public class Decorators_InlineEditorSample : ScriptableObject, ISampleCodeProvider
{
    [InlineEditor]
    public Material mat;
}