using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int Score = 0;
    public Text scoreText;
    private void Update()
    {
        scoreText.text = "Score: " + Score.ToString();
    }

}
