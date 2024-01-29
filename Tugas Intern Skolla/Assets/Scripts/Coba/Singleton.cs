using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using UnityEngine;

public class Singleton<T> : MonoBehaviour
{
      public Singleton(T data) {
        Data = data;
    
      }
    public T Data;
    public static Singleton<T> Instance;
    public static Singleton<T> instance 
    {
        get{
            
            return Instance;
            }
    }
BallView controller = new(); 
    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null){
            Instance = this;
        }else{
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    
}
