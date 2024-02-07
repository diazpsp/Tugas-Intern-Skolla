using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishCondition : MonoBehaviour
{
    public GameObject gameOverImage;
    public bool isCompleted;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(){
        isCompleted = true;
    }
    
}
