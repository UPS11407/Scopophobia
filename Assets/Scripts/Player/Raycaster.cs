using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycaster : MonoBehaviour
{
    public LayerMask _layer;

    private GameObject target;

    void Update()
    {
        RaycastHit[] rayHit;
        rayHit = Physics.RaycastAll(transform.position, transform.TransformDirection(Vector3.forward), 10f, _layer);

        foreach(RaycastHit hit in rayHit)
        {
            Debug.Log("Hit: " + hit.collider.gameObject.name);
            hit.collider.gameObject.GetComponent<Goons>().DisableRenderer();
        }
    }
}
