using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoomBox : MonoBehaviour
{
    public AudioSource[] music;
    private bool hasEntered;
    public int songNumber;


    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.GetComponent<rock>() && !hasEntered)
        {

            hasEntered = true;
            music[songNumber].Play();
            //playing = true;

        }

        else if (hasEntered)
        { 
            music[songNumber].Stop();
            hasEntered = false;
            songNumber++;
            if(songNumber >= music.Length)
            {
                songNumber = 0;
            }
        }



    }
}
