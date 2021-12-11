using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rock : MonoBehaviour
{

    

    // Update is called once per frame
    void Update()
    {
        //Destroy timer after 5 seconds, the rock gameobject will disappear
        DestroyTimer();

    }

    private void DestroyTimer()
    {
        Destroy(this.gameObject, 5);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.GetComponent<enemy>())
        {
            collision.gameObject.GetComponent<enemy>().health--;
        }
    }
}
