using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    public GameObject money;
    public bool hasEnter;
    // Start is called before the first frame update
    void Start()
    {
        hasEnter = false;
    }

    // Update is called once per frame
    void Update()
    {
        money.transform.Rotate(0, 0, 500 * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Player"&&!hasEnter )
        {
            Destroy(this.gameObject, 0.1f);






        }
    }


















}
