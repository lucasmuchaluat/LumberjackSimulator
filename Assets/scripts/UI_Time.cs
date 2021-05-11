using scripts;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class UI_Time : MonoBehaviour
{
   Text textComp;
   GameManager gm;

   private int secondsLeft = 360;
   private bool takingAway = false;

   void Start()
   {
       textComp = GetComponent<Text>();
       gm = GameManager.GetInstance();
   }
   
   void Update()
   {
       
        gm = GameManager.GetInstance();


        if (Input.GetKeyDown(KeyCode.Escape)
            && (gm.gameState == GameManager.GameState.GAME || gm.gameState == GameManager.GameState.RESUME))
        {
            gm.ChangeState(GameManager.GameState.PAUSE);
        }

        if (gm.gameState != GameManager.GameState.GAME &
                gm.gameState != GameManager.GameState.RESUME)
        {
            return;
        }

        if (takingAway == false && secondsLeft > 0)
        {
            StartCoroutine(TimerTake());
        }

        if (secondsLeft <= 0)
        {
            SceneManager.LoadScene(3);
            secondsLeft = 360;
            gm.pontos = 0;
            gm.ChangeState(GameManager.GameState.MENU);
        }
    }

    private IEnumerator TimerTake()
    {
        takingAway = true;
        yield return new WaitForSeconds(1);
        secondsLeft -= 1;
        float minutes = Mathf.FloorToInt(secondsLeft / 60); 
        float seconds = Mathf.FloorToInt(secondsLeft % 60);
        textComp.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        // textComp.text = secondsLeft.ToString();
        takingAway = false;
    }
}