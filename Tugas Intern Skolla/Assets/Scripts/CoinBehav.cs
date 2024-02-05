using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBehav : CoinElement
{
    // Start is called before the first frame update
    void OnTriggerEnter(){
        gameObject.SetActive(false);
    }
    // Update is called once per frame

}
