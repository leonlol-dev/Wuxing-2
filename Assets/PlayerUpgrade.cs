using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUpgrade : MonoBehaviour
{
    public int upgrade;
    public bool alreadyUpgraded = false;
    [SerializeField]
    private PlayerMovement playerMovement;

    private void Start()
    {
        playerMovement = this.gameObject.GetComponent<PlayerMovement>();
    }
    // Update is called once per frame
    void Update()
    {
        //Switch Notes
        // 1 = wind
        // 2 = fire
        // 3 = earth
        // 4 = water
        // 5 = error msg
        // default = base

        switch(upgrade)
        {
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;

        }
        
    }
}
