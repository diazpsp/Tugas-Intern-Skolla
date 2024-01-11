using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CoinView : CoinElement
{
    
    // Start is called before the first frame update
   
    
    void OnTriggerEnter(){
        CoinApp.controller.OnTriggerCoin();
        Destroy(gameObject);
    }
    
}
