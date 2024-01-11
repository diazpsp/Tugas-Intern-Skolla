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
    public CoinApplication CoinApp { get { return GameObject.FindObjectOfType<CoinApplication>(); }}
}
