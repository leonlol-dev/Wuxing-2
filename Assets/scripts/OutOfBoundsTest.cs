using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBoundsTest : MonoBehaviour
{
    public GameObject player;
    public AudioSource playSound;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        playSound = GetComponent<AudioSource> ();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("entered");
            player.GetComponent<CharacterController>().enabled = false;
            player.transform.position = new Vector3(-2, 4, -18);
            player.GetComponent<CharacterController>().enabled = true;
            playSound.Play();
        }
    }
}
