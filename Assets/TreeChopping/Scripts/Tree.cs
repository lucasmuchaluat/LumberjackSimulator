using System.Collections;
using System.Collections.Generic;
using scripts;
using UnityEngine;

public class Tree : MonoBehaviour
{
    //Variables
    GameObject thisTree;
    public int treeHealth = 5;
    private bool isFallen = false;
    public AudioClip treeFall;
    private GameManager gm;


    private void Start()
    {
        gm = GameManager.GetInstance();
        thisTree = transform.parent.gameObject;
    }

    private void FixedUpdate()
    {
        if(treeHealth <= 0 && isFallen == false)
        {
            AudioManager.PlaySFX(treeFall);
            Rigidbody rb = thisTree.AddComponent<Rigidbody>();
            rb.isKinematic = false;
            rb.useGravity = true;
            rb.AddForce(Vector3.forward*3, ForceMode.Impulse);
            StartCoroutine(destroyTree());
            isFallen = true;
        }
    }

    private IEnumerator destroyTree()
    {
        gm.pontos += 1;
        yield return new WaitForSeconds(7);
        Destroy(thisTree);
    }
}
