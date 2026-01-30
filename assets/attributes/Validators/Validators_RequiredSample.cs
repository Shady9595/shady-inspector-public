using System.Linq;
using ShadyInspector;
using UnityEngine;
using Resources = UnityEngine.Resources;

public class Validators_RequiredSample : ScriptableObject, ISampleCodeProvider
{
    [Required(FixAction = nameof(FixMaterial), FixActionName = "Find in Resources")]
    public Material material;

    private void FixMaterial()
    {
        material = Resources.FindObjectsOfTypeAll<Material>().FirstOrDefault();
    }
}