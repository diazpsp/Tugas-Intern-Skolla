using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CoinController: CoinElement
{
   
    // Start is called before the first frame update
    public void OnTriggerCoin(){
        CoinApp.model.coinCount++;
        
        CoinApp.model.stringTitle = "Coin: "+CoinApp.model.coinCount.ToString();
    }

     
   
}
