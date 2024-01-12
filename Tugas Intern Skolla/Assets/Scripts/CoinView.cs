using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CoinView : CoinElement
{
    
    // Start is called before the first frame update
   
    void Update(){
        DisplayCoinCount();
    }
    
    void DisplayCoinCount(){
        CoinApp.model.coinText.text = CoinApp.model.stringTitle;
    }
    
}
