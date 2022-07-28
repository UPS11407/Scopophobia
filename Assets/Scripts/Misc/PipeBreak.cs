using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeBreak : MonoBehaviour
{
    public GameObject _pipe;
    public GameObject _audio;

    private GameObject player;

    void Start()
    {
        player = GameObject.Find("Player");
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer == 3)
        {
            _audio.GetComponent<AudioSource>().Play();

            ChangePipe();
            RunScene();
            Destroy(gameObject);
        }
    }

    void RunScene()
    {
        player.GetComponent<PlayerMovement>().enabled = false;
        player.GetComponent<CameraMovement>().enabled = false;

        player.GetComponent<MeshRenderer>().enabled = false;

        player.transform.rotation = Quaternion.Euler(69.26f, 0, 0);

        player.GetComponent<Rigidbody>().useGravity = true;
        player.GetComponent<Rigidbody>().mass = 60f;
        player.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
    }

    void ChangePipe()
    {
        _pipe.transform.localPosition = new Vector3(-4.78f, -10.9f, 112.42f);
        _pipe.transform.localRotation = Quaternion.Euler(0, 90, -60);
    }
}
