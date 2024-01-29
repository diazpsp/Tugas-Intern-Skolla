using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
// using MVCMan;

public class CoinView : MonoBehaviour
{
    
    // Start is called before the first frame update

    // [SerializeField]
    //  private MVCManager mVCManager;
 
    // void Update(){
    //     mVCManager.GetScore();        
    // }
    public void DisplayCoin(CoinModel coinModel){
        // coinController.GetScoreCoin(coinModel);
        coinModel.coinText.text = "Coin: " + coinModel.coinCount.ToString();
    }
   //public T GetView<T>(){
        
        // return DependencyInjector.Instance.GetController<T>();

    // }/
}