using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBehav : CoinElement
{
    // Start is called before the first frame update
    void OnTriggerEnter(Collider col){
        if(col.gameObject.tag == "Player")
        {
            gameObject.SetActive(false);
        }
    }
    // Update is called once per frame

}
