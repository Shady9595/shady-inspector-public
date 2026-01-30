using ShadyInspector;
using UnityEngine;

public class Misc_OnValueChangedSample : ScriptableObject, ISampleCodeProvider
{
    [OnValueChanged(nameof(OnMaterialChanged))]
    public Material mat;

    private void OnMaterialChanged()
    {
        Debug.Log("Material changed!");
    }
}