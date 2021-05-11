using System.Collections;
using System.Collections.Generic;
using scripts;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_Pause : MonoBehaviour
{
    GameManager gm;

    private void OnEnable()
    {
        gm = GameManager.GetInstance();
    }
    
    public void Retornar()
    {
        gm.ChangeState(GameManager.GameState.RESUME);
    }

    public void Inicio()
    {
        SceneManager.LoadScene(1);
        gm.ChangeState(GameManager.GameState.MENU);
    }

}
