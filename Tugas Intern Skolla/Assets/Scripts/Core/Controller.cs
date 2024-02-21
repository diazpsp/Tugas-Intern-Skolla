using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Controller : MonoBehaviour
{
    // Start is called before the first frame update
    
    public virtual void Start(){
        DependencyInjector.Instance.RegisterController(GetControllerType(),this);
        
    }
    public T GetController<T>() where T : Controller{
        
        return DependencyInjector.Instance.GetController<T>();

    }
   

    //dibawah ini buat KEY (KATAKUNCI) nya di DICTIONARY. jadi buat tulisan TOK. ndak ada isinya. krn return_type nya harus Type
    //ini jg bisa di override ke class sembarang 
    //method ini harus di implemen di semua class yang mewarisi
    public abstract Type GetControllerType();

    
}
