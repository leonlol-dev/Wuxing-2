using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{
    public float damage = 1.0f;
    public float range = 100f;
    public float power = 55.0f;
    public float multiplier = 3.0f;

    public float fireRate = 1f;
    private float nextTimeToFire = 0f;

    public Camera fpsCam;
    public Animator animator;

    //Rock
    public GameObject rock;
    public GameObject spawn;

    //Sound
    private AudioSource sound;
    private float pitchValue = 1.0f;

    //Player
    public GameObject player;
    public bool walking;
    


    private void Start()
    {
        //Initalise audio source using this.gameObject
        sound = this.gameObject.GetComponent<AudioSource>();
    }


    // Update is called once per frame
    void Update()
    {
  

        //If player is moving boolean
        if (player.GetComponent<PlayerMovement>().z > 0.0f || player.GetComponent<PlayerMovement>().x > 0.0f || player.GetComponent<PlayerMovement>().x < 0.0f)
        {
            walking = true;
        }
        
        else
        {
            walking = false;
        }

        //Get velocity
        power = player.GetComponent<PlayerMovement>().speed;

        if (Input.GetButton("Fire1") && Time.time >= nextTimeToFire )
        {
            nextTimeToFire = Time.time + 1f / fireRate;
            pitchValue = Random.Range(1.0f, 1.25f);
            sound.pitch = pitchValue;
            sound.Play();
            Shoot();

        }

        if (Input.GetButtonDown("Fire2"))
        {
            if (animator.GetBool("zoom") == true)
            {
                animator.SetBool("zoom", false);
            }

            else
            {
                animator.SetBool("zoom", true);

            }

        }
    }

    void Shoot()
    {
        
        Rigidbody rb = Instantiate(rock, spawn.transform.position, Quaternion.identity).GetComponent<Rigidbody>();
      
        rb.AddForce(transform.forward * 55f, ForceMode.Impulse);

        if (walking)
        {
            //Debug.Log("w");
            rb.AddForce(transform.forward * (power * multiplier), ForceMode.Impulse);
        }

        rb.AddForce(transform.up * 8f, ForceMode.Impulse);








        //RaycastHit hit;
        //if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        //{
        //    Debug.Log(hit.transform.name);

        //    enemy enemy = hit.transform.GetComponent<enemy>();
        //    BoomBox boombox = hit.transform.GetComponent<BoomBox>();

        //    if (enemy != null)
        //    {
        //        //enemy.TakeDamage(damage);
        //    }

        //    if (boombox != null)
        //    {
        //        boombox.playMusic();
        //    }
        //}


    }
}
