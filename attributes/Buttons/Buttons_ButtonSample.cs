using ShadyInspector;
using UnityEngine;

public class Buttons_ButtonSample : ScriptableObject, ISampleCodeProvider
{
    [Button("Click me!")]
    private void DoButton()
    {
        Debug.Log("Button clicked!");
    }

    [Button(ButtonSizes.Large)]
    private void DoButtonWithParameters(Vector3 vec, string str = "default value")
    {
        Debug.Log($"Button with parameters: {vec} {str}");
    }
}