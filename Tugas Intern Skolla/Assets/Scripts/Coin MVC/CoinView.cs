using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
// using MVCMan;

public class CoinView : MonoBehaviour
{
 
    public void DisplayCoin(CoinModel coinModel){
    
        coinModel.coinText.text = "Coin: " + coinModel.coinCount.ToString();
    }
  
}