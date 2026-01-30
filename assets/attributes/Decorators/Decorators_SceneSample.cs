using System.Collections.Generic;
using ShadyInspector;
using UnityEngine;

public class Decorators_SceneSample : ScriptableObject, ISampleCodeProvider
{
    [Scene] public string scene;

    [Scene] public List<string> scenes;
}