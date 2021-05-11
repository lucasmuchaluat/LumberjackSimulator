using scripts;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI_Pontos : MonoBehaviour
{
   Text textComp;
   GameManager gm;
   void Start()
   {
       textComp = GetComponent<Text>();
       gm = GameManager.GetInstance();
   }
   
   void Update()
   {
        gm = GameManager.GetInstance();
        if (gm.pontos >= 2)
        {
            SceneManager.LoadScene(2);
            gm.ChangeState(GameManager.GameState.MENU);
            gm.pontos = 0;
        }

        if (gm.pontos == 0)
        {
            textComp.text = "0";
        }
        else
        {
            textComp.text = gm.pontos.ToString();
        }
    }
}