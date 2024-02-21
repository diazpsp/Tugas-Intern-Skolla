using UnityEngine.UI;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using System.Linq.Expressions;
using System;
using System.Collections.Generic;
// using UnityEngine.EventSystems;

public class PlayerController : Controller
{
    public PlayerView view;
    public PlayerModel model;
   
    void Awake(){
        if(model.character == null && model.players.Count >= 1){
            model.character = model.players[0];
        }
        view = model.character.GetComponent<PlayerView>();
    }

    void Update()
    {
        if(view != null){
            view.MovementInput();
            if(view.isGrounded ==true){
                view.Jump();
            } 
        }else if(model.character==null){
            
        }else{view = model.character.GetComponent<PlayerView>();}
    }

    void FixedUpdate(){
        if(model.character!= null) 
        {
            view.MoveBall();
        }else{}
    }
    public override Type GetControllerType()
    {
        return typeof(PlayerController);
    }
    
}
