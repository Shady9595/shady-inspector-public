using ShadyInspector;
using UnityEngine;

public class Validators_ValidateInputSample : ScriptableObject, ISampleCodeProvider
{
    [ValidateInput(nameof(ValidateTexture))]
    public Texture tex;

    [ValidateInput(nameof(ValidateNumber))]
    public int number;

    private ShadyValidationResult ValidateTexture()
    {
        if (tex == null) return ShadyValidationResult.Error("Tex is null");
        if (!tex.isReadable) return ShadyValidationResult.Warning("Tex must be readable");
        return ShadyValidationResult.Valid;
    }

    private ShadyValidationResult ValidateNumber()
    {
        if (number == 1)
        {
            return ShadyValidationResult.Valid;
        }

        return ShadyValidationResult.Error("Number must be equal 1")
            .WithFix(() => number = 1, "Set to 1");
    }
}