using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;


public class WaitClass : MonoBehaviour
{

    public float wait = 20f;

    void Start()
    {
        StartCoroutine(WaitIntro());
    }

    IEnumerator WaitIntro()
    {
        yield return new WaitForSeconds(wait);

        SceneManager.LoadScene(1);
    }

}
