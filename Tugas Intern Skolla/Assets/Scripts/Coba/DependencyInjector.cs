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
   
    //make this class a singleton (only 1 class over all scenes(dontdestroyonload))
    public void Awake(){
        if(singletonDI==null){
            singletonDI = this;
            DontDestroyOnLoad(gameObject);
        }else{
            Destroy(gameObject);
        }
        
    }
    
    public void RegisterController(Type type,Controller controller){
        dictionary.Add(type,controller);
        Debug.Log(type + "Registered");
    }
    //GetController<BounceController>();
    public T GetController<T>() where T : Controller{
        return dictionary[typeof(T)] as T;

    }
    
}
