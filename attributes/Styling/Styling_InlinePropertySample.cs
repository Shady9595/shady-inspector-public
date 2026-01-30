using System;
using ShadyInspector;
using UnityEngine;

public class Styling_InlinePropertySample : ScriptableObject, ISampleCodeProvider
{
    public MinMax rangeFoldout;

    [InlineProperty(LabelWidth = 40)]
    public MinMax rangeInline;

    [Serializable]
    public class MinMax
    {
        public int min;
        public int max;
    }
}