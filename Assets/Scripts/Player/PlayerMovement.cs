using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float _speed = 3f;

    private Rigidbody rigid;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if(transform.localEulerAngles.y > 90 && transform.eulerAngles.y < 270)
        {
            if (Input.GetKey(KeyCode.W))
            {
                rigid.velocity = new Vector3(0, 0, -1) * _speed;
            }
            else if (Input.GetKey(KeyCode.S))
            {
                rigid.velocity = new Vector3(0, 0, 1) * _speed;
            }
            else
            {
                rigid.velocity = new Vector3(0, 0, 0);
            }
        }
        else
        {
            if (Input.GetKey(KeyCode.W))
            {
                rigid.velocity = new Vector3(0, 0, 1) * _speed;
            }
            else if (Input.GetKey(KeyCode.S))
            {
                rigid.velocity = new Vector3(0, 0, -1) * _speed;
            }
            else
            {
                rigid.velocity = new Vector3(0, 0, 0);
            }
        }
	}
}
