using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBehav : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(Collider col){
        if(col.gameObject.tag == "Player" && col.gameObject.GetComponent<PlayerView>() != null)
        {
            gameObject.SetActive(false);
        }
    }
    // Update is called once per frame

}
