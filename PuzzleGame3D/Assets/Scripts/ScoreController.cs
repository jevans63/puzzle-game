using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public int scoreVal = 0;
    public string scoreText = "Score: 0";
    public Text ScoreUI;
    // Start is called before the first frame update
    void Start()
    {
        ScoreUI = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        ScoreUI.text = scoreText;
    }
}
