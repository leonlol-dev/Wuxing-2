using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindWeapon : MonoBehaviour
{
    public AudioSource audiosource;
    public AudioClip woosh;
    public AudioClip wind;

    public bool alreadyUpgraded = false;
    public float dashSpeed;
    public float dashTime;
    public float fireRate = 4f;

    [SerializeField]
    private PlayerMovement playerMovement;
    private float nextTimeToFire = 0f;



    // Start is called before the first frame update
    void Start()
    {
        playerMovement = this.gameObject.GetComponentInParent<PlayerMovement>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!alreadyUpgraded)
        {
            playerMovement.speed = playerMovement.speed + playerMovement.upgradeSpeed;
            playerMovement.windUpgrade = true;
            alreadyUpgraded = true;
        }

        if (Input.GetButton("Fire1") && Time.time >= nextTimeToFire)
        {
            nextTimeToFire = Time.time + 1f / fireRate;
            StartCoroutine(Dash());
            
        

        }


    }

    IEnumerator Dash()
    {
        audiosource.Play();
        float startTime = Time.time;
        while(Time.time < startTime + dashTime)
        {
            
            playerMovement.controller.Move(playerMovement.move * dashSpeed * Time.deltaTime);
            yield return null;
        }
    }
}
