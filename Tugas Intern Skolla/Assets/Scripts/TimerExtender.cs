using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerExtender : MonoBehaviour
{
    [SerializeField]
    private GameTimer gameTimer;    // Start is called before the first frame update
    void Start()
    {
        gameTimer = GameObject.FindObjectOfType<GameTimer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider coll){
        if(coll.gameObject.tag == "Player"){ 
            gameTimer.timer += 5f;
            Destroy(gameObject);
        }
    }
}
