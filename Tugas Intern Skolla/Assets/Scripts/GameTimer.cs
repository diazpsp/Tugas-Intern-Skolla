using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameTimer : MonoBehaviour
{
    
    public float timer;
    [SerializeField]
    private TMP_Text timerText;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer>0){
            timerText.text = timer.ToString("Timer: "+(int)timer);
            timer-=Time.deltaTime;
        }
        if(timer<0){
            timerText.text = timer.ToString("Timer: "+(int)timer);
            timer = 0;
        }
    }
}
