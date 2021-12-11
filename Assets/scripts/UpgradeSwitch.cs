using UnityEngine;

public class UpgradeSwitch : MonoBehaviour
{
    public int selectedUpgrade;
    public GameObject player;
    public WindWeapon windweapon;

    public bool wind;
    public bool rock;
    public bool water;
    public bool fire;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        windweapon = gameObject.transform.GetChild(2).gameObject.GetComponent<WindWeapon>();
        SelectUpgrade();
    }

    // Update is called once per frame
    void Update()
    {
        int previousSelectedUpgrade = selectedUpgrade;

        //For testing purposes; you can switch between upgrades using 1-4 on keyboard. This will be disabled and changed into when you pick up each upgrade.
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            //No weapon
            selectedUpgrade = 0;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2) && transform.childCount >= 2)
        {
            //Rock Upgrade
            selectedUpgrade = 1;

            //Reset states
            player.GetComponent<PlayerMovement>().windUpgrade = false;
            windweapon.alreadyUpgraded = false;
            player.GetComponent<PlayerMovement>().speed = player.GetComponent<PlayerMovement>().speed - player.GetComponent<PlayerMovement>().defaultSpeed;
        }

        if (Input.GetKeyDown(KeyCode.Alpha3) && transform.childCount >= 3)
        {
            //Wind Upgrade
            selectedUpgrade = 2;
        }

        //if(wind && transform.childCount >= 3)
        //{
        //    selectedUpgrade = 2;
        //}

        if (previousSelectedUpgrade != selectedUpgrade)
        {
            SelectUpgrade();
        }
    }

    void SelectUpgrade()
    {
        // Upgrade References
        // 0 = Nothing
        // 1 = Rock
        // 2 = Wind
        // 3 = Fire
        // 4 = Water


        int i = 0;
        foreach (Transform upgrade in transform)
        {
            if (i == selectedUpgrade)
                upgrade.gameObject.SetActive(true);
            else
                upgrade.gameObject.SetActive(false);
            i++;
        }
    }
}
