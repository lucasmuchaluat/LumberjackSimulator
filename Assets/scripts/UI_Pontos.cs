using scripts;
using UnityEngine;
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
        var player = gm.GetActivePlayer();
        
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