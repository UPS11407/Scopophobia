using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goons : MonoBehaviour
{
    public Transform _player;

    private MeshRenderer[] _renderers;

    private bool updatedThisFrame;

    void Start()
    {
        _renderers = GetComponentsInChildren<MeshRenderer>();
    }

    void FixedUpdate()
    {
        updatedThisFrame = false;
        TurnTowardsPlayer();
    }

    void TurnTowardsPlayer()
    {
        //Since I placed eyes on the wrong side of the goons I gotta swap left and back vectors to orient properly
        transform.LookAt(_player.position);
        transform.rotation *= Quaternion.FromToRotation(Vector3.left, Vector3.back);
    }

    //Disables the rendered and sets the last disable frame to the current frame
    public void DisableRenderer()
    {
        foreach(MeshRenderer renderer in _renderers)
        {
            renderer.enabled = false;
        }
        
        updatedThisFrame = true;
    }

    private void LateUpdate()
    {
        if (!updatedThisFrame)
        {
            foreach (MeshRenderer renderer in _renderers)
            {
                renderer.enabled = true;
            }
        }
    }
}
