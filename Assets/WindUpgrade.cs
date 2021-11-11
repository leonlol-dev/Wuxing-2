using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindUpgrade : MonoBehaviour
{
    public ParticleSystem wind;

    [SerializeField]
    private AudioSource upgradeSound;
    private UpgradeSwitch upgradeSwitch;
    private GameObject player;
    public GameObject windGun;
    private Renderer rend;
    private bool hasEntered;

    // Start is called before the first frame update
    void Start()
    {
     
        //Find Player with the script with upgradeSwitch.
        upgradeSwitch = GameObject.FindWithTag("UpgradeSwitch").GetComponent<UpgradeSwitch>();

        //Find Player
        player = GameObject.FindWithTag("Player");

        //Find Audio Source already on this GameObject.
        upgradeSound = this.gameObject.GetComponent<AudioSource>();

        //Find Renderer
        rend = this.gameObject.GetComponent<Renderer>();

        windGun = upgradeSwitch.transform.GetChild(2).gameObject;
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player" && !hasEntered)
        {
            //Player can't access it twice by mistake.
            hasEntered = true;

            //Set windgun active
            windGun.SetActive(true);

            //Play SFX.
            upgradeSound.Play();

            //Disable renderer.
            rend.enabled = false;

            //Stop particle system
            wind.Stop();

            //Delete with a delay (2nd parameter is time).
            Destroy(this.gameObject, 2.0f);
            
        }
    }

}
