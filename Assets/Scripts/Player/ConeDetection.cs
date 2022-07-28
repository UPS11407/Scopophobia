using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConeDetection : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.layer == 7)
        {
            other.gameObject.GetComponent<Goons>().DisableRenderer();
        }
    }
}
