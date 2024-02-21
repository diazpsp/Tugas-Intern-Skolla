using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpView : MonoBehaviour
{
    public PowerUpModel model;
    // Start is called before the first frame update
    public void DisplayPowerUp(bool isTrue  ){
        if(isTrue){
            model.powerUpText.text = (model.time).ToString("Power Up Time: "+(int)model.time);
        }
        else{
            model.powerUpText.text = ("");
        }
    }
   
}
