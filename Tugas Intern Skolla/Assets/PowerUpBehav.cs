using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpBehav : MonoBehaviour
{
    public PowerUpContainer powerUpContainer;
    // Start is called before the first frame update
    void Start()
    {
        powerUpContainer = GameObject.FindObjectOfType<PowerUpContainer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider col){
        if(col.gameObject.tag == "Player")
        {
            powerUpContainer.isPowerOn = true;
            powerUpContainer.time=4f;
            Destroy(gameObject);
        }
    }
}
