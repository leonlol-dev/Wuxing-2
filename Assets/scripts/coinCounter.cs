using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinCounter : MonoBehaviour {
    public int points = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //creates the score text in the top left,
    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 200, 40), "Coins: " + points);  
    }
}
