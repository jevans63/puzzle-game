using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyOnCollisionLimit : MonoBehaviour
{        
    public AudioClip gameover;
    public AudioSource Source;
    public GameObject gameOverText;
    void OnCollisionEnter(Collision col)
    {
        Source.PlayOneShot(gameover, 0.2f);
        Destroy(col.gameObject);
        StartCoroutine(GameOver(2));
    }

    IEnumerator GameOver(float time)
    {
        gameOverText.SetActive(true);
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene("MainMenu");
    }
}