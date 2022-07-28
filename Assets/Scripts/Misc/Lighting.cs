using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lighting : MonoBehaviour
{
    public Color _earlyLighting;
    public Color _nightLighting;

    public Color _lateLighting;
    public Color _darkLighting;

    public float _transitionSpeed;
    public bool transitionOne = false;
    public bool transitionTwo = false;
    public bool transitionThree = false;
    public  float lerpScale = 0;

    void Start()
    {
        RenderSettings.ambientLight = _earlyLighting;
    }

    private void FixedUpdate()
    {
        if (transitionOne && RenderSettings.ambientLight != _nightLighting)
        {
            RenderSettings.ambientLight = Color.Lerp(_earlyLighting, _nightLighting, lerpScale);
            lerpScale += _transitionSpeed;
        }
        else
        {
            transitionOne = false;
        }

        if(transitionTwo && RenderSettings.ambientLight != _lateLighting)
        {
            RenderSettings.ambientLight = Color.Lerp(_nightLighting, _lateLighting, lerpScale);
            lerpScale += _transitionSpeed;
        }
        else
        {
            transitionTwo = false;
        }

        if (transitionThree && RenderSettings.ambientLight != _darkLighting)
        {
            RenderSettings.ambientLight = Color.Lerp(_lateLighting, _darkLighting, lerpScale);
            lerpScale += _transitionSpeed;
        }
        else
        {
            transitionThree = false;
        }
    }
}
