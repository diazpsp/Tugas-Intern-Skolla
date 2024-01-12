using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBehav : CoinElement
{
    // Start is called before the first frame update
    void OnTriggerEnter(){
        CoinApp.controller.OnTriggerCoin();
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
