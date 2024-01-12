using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class CoinApplication : CoinElement
{
    // Start is called before the first frame update
    public CoinModel model;
    public CoinView view;
    public CoinController controller;
}

public class CoinElement : MonoBehaviour{
    private CoinApplication coinApp;
    public CoinApplication CoinApp { get { return coinApp; }}

    protected virtual void Start(){
        coinApp = FindObjectOfType<CoinApplication>();
    }
}
