﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeRaycast : MonoBehaviour
{
    //Variables
    public GameObject axe;
    private bool isEquiped = false;
    public AudioClip axeHit;

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
        if(Physics.Raycast(transform.position, fwd, out hit, 20))
        {
            if(hit.collider.tag == "tree" && Input.GetMouseButtonDown(0) && isEquiped == true)
            {
                AudioManager.PlaySFX(axeHit);
                Tree treeScript = hit.collider.gameObject.GetComponent<Tree>();
                Debug.Log("Health: " + treeScript.treeHealth);
                treeScript.treeHealth--;
            }

            if(hit.collider.tag == "palm" && Input.GetMouseButtonDown(0) && isEquiped == true)
            {
                Debug.Log("NÃO CORTE OS COQUEIROS, SE ESQUECEU QUE ELES TE DÃO AGUA?");
            }
        }
    }
}
