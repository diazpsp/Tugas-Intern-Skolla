using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CoinModel : MonoBehaviour
{
    public string stringTitle;
    public float coinCount;
    public TMP_Text coinText;
    // Start is called before the first frame update
    
    public void AddScoreCoin(float coin){
        coinCount+=coin;
        
    } 
    
}
