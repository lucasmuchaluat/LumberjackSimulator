using System.Collections;
using System.Collections.Generic;
using scripts;
using UnityEngine;
using UnityEngine.UI;

public class UI_MenuPrincipal : MonoBehaviour
{
    GameManager gm;


    private void OnEnable()
    {
        gm = GameManager.GetInstance();
        
    }
    
    public void Comecar()
    {
        gm.ChangeState(GameManager.GameState.GAME);
    }
}
