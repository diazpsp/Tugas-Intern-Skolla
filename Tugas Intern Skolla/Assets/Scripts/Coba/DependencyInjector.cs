using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DependencyInjector : MonoBehaviour
{
    // Start is called before the first frame update
    public static DependencyInjector singletonDI;
    public static DependencyInjector Instance
        {
            get
            {
                
                return singletonDI;
            }
        }
    
    Dictionary<Type, Controller> dictionary = new Dictionary<Type, Controller>();
    protected DependencyInjector(){}
    // private CoinModel coinModel;
    // private CoinView coinView;
    // public void GetScoreCoin()
    // {
        
    //     coinModel.coinText.text = "Coin: "+coinModel.coinCount.ToString();
    // }
    // public void AddScoreCoin(float coin,CoinModel coinModel){
    //     coinModel.coinCount+=coin;
        
    // }
    //make this class a singleton (only 1 class over all scenes(dontdestroyonload))
    public void Awake(){
        if(singletonDI==null){
            singletonDI = this;
            DontDestroyOnLoad(gameObject);
        }else{
            Destroy(gameObject);
        }
        
    }
    
    
    // void Start(){

        
    //     //  dictionary.Add(controllers,controllers.e);
         
    //     controllers.GetController<CoinController>();
    //     GetController<CoinController>();
    // }

    
    public void RegisterController(Type type,Controller controller){
        dictionary.Add(type,controller);
        Debug.Log(type + "Registered");
    }
    //GetController<BounceController>();
    public T GetController<T>() where T : Controller{
        return dictionary[typeof(T)] as T;

    }
    
}
