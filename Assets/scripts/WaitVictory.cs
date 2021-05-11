using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class WaitVictory : MonoBehaviour
{
    // Use this for initialization
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
