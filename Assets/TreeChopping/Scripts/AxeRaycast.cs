using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeRaycast : MonoBehaviour
{
    public Animator animator;

    //Variables
    public GameObject axe;
    private bool isEquiped = false;
    public AudioClip axeHit;
    public AudioClip coqueiro;


    private void Update()
    {
        if(!axe.activeSelf && Input.GetKeyDown(KeyCode.Alpha3))
        {
            isEquiped = true;
            axe.SetActive(true);
        }
        else if(Input.GetKeyDown(KeyCode.Alpha3))
        {
            
            isEquiped = false;
            axe.SetActive(false);
        }




        //Raycast
        Vector3 fwd = transform.TransformDirection(Vector3.forward);
        RaycastHit hit;

        //Origin, Direction, RaycastHit, Length
        //
        if (Input.GetMouseButtonDown(0) && isEquiped == true)
        {
            Debug.Log("ENTROU NO IF DAAAAAAAAAAA");

            animator.SetFloat("Axe", 1.0f);

        }

        if (Physics.Raycast(transform.position, fwd, out hit, 20))
        {
            Debug.Log("ANTES NO IF");

            if (hit.collider.tag == "tree" && Input.GetMouseButtonDown(0) && isEquiped == true)
            {
                Debug.Log("ENTROU NO IF");

                AudioManager.PlaySFX(axeHit);
                Tree treeScript = hit.collider.gameObject.GetComponent<Tree>();
                Debug.Log("Health: " + treeScript.treeHealth);
                treeScript.treeHealth--;
            }

            if(hit.collider.tag == "palm" && Input.GetMouseButtonDown(0) && isEquiped == true)
            {
                Debug.Log("NÃO CORTE OS COQUEIROS, SE ESQUECEU QUE ELES TE DÃO AGUA?");
                AudioManager.PlaySFX(coqueiro);
            }
        }








    }
}
