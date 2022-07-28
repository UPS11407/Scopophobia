using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebugColorLerp : MonoBehaviour
{
    public Text _text;

    public Lighting _lighting;

    void Update()
    {
        _text.text = _lighting.lerpScale.ToString();
    }
}
