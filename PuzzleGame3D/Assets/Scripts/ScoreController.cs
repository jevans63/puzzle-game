using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// This is a simple script which is attached to the ScoreUI text object in the primary game scene
// It uses GetComponent<Text> to reference the object’s text 
// and the scoreText is updated whenever a block is successfully cleared
// This occurs through the CatcherController.cs class which uses a reference to a public ScoreController instance
public class ScoreController : MonoBehaviour
{
    public int scoreVal = 0;
    public string scoreText = "Score: 0";
    public Text ScoreUI;

    void Start()
    {
        ScoreUI = GetComponent<Text>();
    }

    void Update()
    {
        ScoreUI.text = scoreText;
    }
}
