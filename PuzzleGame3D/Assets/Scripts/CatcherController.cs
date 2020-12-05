using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
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
    //bool swapable = true; 

    // void OnMouseDown()
    // {
    //     swapColorLeft();
    // }

    void OnMouseOver()
    {
        if(Input.GetMouseButtonDown(0)) swapColorLeft();
        if(Input.GetMouseButtonDown(1)) swapColorRight();
    }

    void Update()
    {
        // if (Input.GetKeyDown("z") && floor.gameObject.CompareTag("Block1") && swapable == true)
        // {
        //     swapColor();
        //     //StartCoroutine(DelaySwapable(1));
        // }

        // if (Input.GetKeyDown("x") && floor.gameObject.CompareTag("Block2") && swapable == true)
        // {
        //     swapColor();
        //     //StartCoroutine(DelaySwapable(1));
        // }

        // if (Input.GetKeyDown("c") && floor.gameObject.CompareTag("Block3") && swapable == true)
        // {
        //     swapColor();
        //     //StartCoroutine(DelaySwapable(1));
        // }

        // if (Input.GetKeyDown("v") && floor.gameObject.CompareTag("Block4") && swapable == true)
        // {
        //     swapColor();
        //     //StartCoroutine(DelaySwapable(1));
        // }

        // if (Input.GetKeyDown("b") && floor.gameObject.CompareTag("Block5") && swapable == true)
        // {
        //     swapColor();
        //     //StartCoroutine(DelaySwapable(1));
        // }
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

    // IEnumerator DelaySwapable(float time)
    // {
    //     swapable = false;
    //     yield return new WaitForSeconds(time);
    //     swapable = true;
    // }
}
