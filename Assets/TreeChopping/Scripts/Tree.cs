using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{
    //Variables
    GameObject thisTree;
    public int treeHealth = 5;
    private bool isFallen = false;
    private Color alphaColor;
    private float timeToFade = 1.0f;

    private void Start()
    {
        thisTree = transform.parent.gameObject;
        // alphaColor = thisTree.AddComponent<Renderer>().material.color;
        // alphaColor.a = 0;
        
    }

    private void FixedUpdate()
    {
        if(treeHealth <= 0 && isFallen == false)
        {
            Rigidbody rb = thisTree.AddComponent<Rigidbody>();
            rb.isKinematic = false;
            rb.useGravity = true;
            rb.AddForce(Vector3.forward*3, ForceMode.Impulse);
            StartCoroutine(destroyTree());
            // thisTree.GetComponent<Renderer>().material.color = Color.Lerp(thisTree.GetComponent<Renderer>().material.color, alphaColor, timeToFade * Time.deltaTime);
            isFallen = true;
        }
    }

    private IEnumerator destroyTree()
    {
        yield return new WaitForSeconds(7);
        Destroy(thisTree);
    }
}
