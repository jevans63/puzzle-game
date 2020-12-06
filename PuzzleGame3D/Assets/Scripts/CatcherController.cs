using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// This script  controls the bottom row of blocks whose colors will destroy the falling blocks if they are matching
// This is accomplished by using OnCollisonEnter() and OnCollisionStay() functions
// The color/symbol swapping makes use of OnMouseOver() as well as Input.GetMouseDown()
// The material and color variables are then changed depending on right or left clicking on the block
public class CatcherController : MonoBehaviour
{
    public Material red, green, blue;
    public GameObject floor;
    public string color = "Blue";
    public ScoreController scoreController;
    public AudioClip hit1;
    public AudioClip clear1;
    public AudioClip clear2;
    public AudioClip clear3;
    public AudioClip gameover;
    public GameObject gameOverText;
    public AudioSource Source;

    void OnMouseOver()
    {
        if(Input.GetMouseButtonDown(0)) swapColorLeft();
        if(Input.GetMouseButtonDown(1)) swapColorRight();
    }

    void OnCollisionStay(Collision col)
    {
        if (col.gameObject.tag == "Bomb")
        {
            Source.PlayOneShot(gameover, 0.2f);
            Destroy(col.gameObject);
            StartCoroutine(GameOver(2));
        }
        if (col.gameObject.CompareTag(color))
        {
            Destroy(col.gameObject);
            scoreController.scoreVal += 1;
            scoreController.scoreText = "Score: " + scoreController.scoreVal.ToString();
            if(color == "Red") Source.PlayOneShot(clear1, 0.2f);
            if(color == "Green") Source.PlayOneShot(clear2, 0.2f);
            if(color == "Blue") Source.PlayOneShot(clear3, 0.2f);
        } 
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Bomb")
        {
            Source.PlayOneShot(gameover, 0.2f);
            Destroy(col.gameObject);
            StartCoroutine(GameOver(2));
        }
        Source.PlayOneShot(hit1, 0.2f);
        if (col.gameObject.CompareTag(color))
        {
            Destroy(col.gameObject);
            scoreController.scoreVal += 1;
            scoreController.scoreText = "Score: " + scoreController.scoreVal.ToString();
            if(color == "Red") Source.PlayOneShot(clear1, 0.2f);
            if(color == "Green") Source.PlayOneShot(clear2, 0.2f);
            if(color == "Blue") Source.PlayOneShot(clear3, 0.2f);
        } 
    }

    void swapColorLeft()
    {
        if (color == "Red")
        {
            floor.GetComponent<MeshRenderer>().material = green;
            color = "Green";
        }
        else if (color == "Green")
        {
            floor.GetComponent<MeshRenderer>().material = blue;
            color = "Blue";
        }
        else if (color == "Blue")
        {
            floor.GetComponent<MeshRenderer>().material = red;
            color = "Red";
        }
    }

    void swapColorRight()
    {
        if (color == "Red")
        {
            floor.GetComponent<MeshRenderer>().material = blue;
            color = "Blue";
        }
        else if (color == "Blue")
        {
            floor.GetComponent<MeshRenderer>().material = green;
            color = "Green";
        }
        else if (color == "Green")
        {
            floor.GetComponent<MeshRenderer>().material = red;
            color = "Red";
        }
    }

    IEnumerator GameOver(float time)
    {
        gameOverText.SetActive(true);
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene("MainMenu");
    }
}
