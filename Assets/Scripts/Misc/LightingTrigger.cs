using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightingTrigger : MonoBehaviour
{
    public enum Transition
    {
        One,
        Two,
        Three,
        Four
    }

    public Transition _transition;

    private void OnTriggerEnter(Collider other)
    {
        if (_transition == Transition.One)
        {
            transform.parent.GetComponent<Lighting>().transitionOne = true;
            transform.parent.GetComponent<Lighting>().lerpScale = 0;
            Destroy(gameObject);
        }
        else if(_transition == Transition.Two)
        {
            transform.parent.GetComponent<Lighting>().transitionTwo = true;
            transform.parent.GetComponent<Lighting>().lerpScale = 0;
            Destroy(gameObject);
        }
        else if(_transition == Transition.Three)
        {
            transform.parent.GetComponent<Lighting>().transitionThree = true;
            transform.parent.GetComponent<Lighting>().lerpScale = 0;
            Destroy(gameObject);
        }
    }
}
