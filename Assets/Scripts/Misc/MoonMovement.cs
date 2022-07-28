using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonMovement : MonoBehaviour
{
    public Transform _player;
    private Vector3 distance = new Vector3(0f, 40.44f, 30.48f);

    private void Update()
    {
        transform.position = new Vector3(_player.position.x + distance.x, _player.position.y + distance.y, _player.position.z + distance.z);
    }
}
