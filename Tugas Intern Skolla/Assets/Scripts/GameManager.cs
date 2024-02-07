using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject player,gameOverText,gameCompleteText;
    
    
    [SerializeField] private FinishCondition finishCon;
    [SerializeField] private GameTimer gameTimer;
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if(player == null){
            gameOverText.SetActive(true);
            StartCoroutine(PauseTime());
        }
        if(finishCon.isCompleted){
            gameCompleteText.SetActive(true);
            StartCoroutine(PauseTime()); 
        }
        if(gameTimer.timer <=0){
            gameOverText.SetActive(true);
            StartCoroutine(PauseTime());
        }
    }
    IEnumerator PauseTime(){
        yield return new WaitForSeconds(1f);
        Time.timeScale = 0 ;
    }
}
