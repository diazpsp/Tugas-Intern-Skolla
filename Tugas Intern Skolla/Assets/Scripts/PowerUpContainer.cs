using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PowerUpContainer : MonoBehaviour
{
    public bool isPowerOn;

    public float time ;
    public TMP_Text powerUpText;
   
    // Start is called before the first frame update
    void Start()
    {
     
    }

    void Update()
    {   
        
        if(isPowerOn){
            
            time -= Time.deltaTime;
            powerUpText.text = (time).ToString("Power Up Time: "+(int)time);

        }
        
        if (time < 0)
        {
            time= 0;
            powerUpText.text = ("");
            isPowerOn = false;
        }
    }
   
   
}
