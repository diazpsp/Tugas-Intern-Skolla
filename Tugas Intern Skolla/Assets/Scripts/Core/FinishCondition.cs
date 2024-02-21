using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishCondition : MonoBehaviour
{

    public bool isCompleted;
    // Start is called before the first frame update
 
    void OnTriggerEnter(){
        isCompleted = true;
    }
    
}
