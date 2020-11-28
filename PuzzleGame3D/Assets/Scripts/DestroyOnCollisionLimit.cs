using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyOnCollisionLimit : MonoBehaviour
{        
    public GameObject gameOverText;
    void OnCollisionEnter(Collision col)
    {
        Destroy(col.gameObject);
        StartCoroutine(GameOver(3));
    }

    IEnumerator GameOver(float time)
    {
        gameOverText.SetActive(true);
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene("MainMenu");
    }
}