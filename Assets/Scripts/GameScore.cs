using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScore : MonoBehaviour
{
    public Text gameScoreText;
    public static int gameScore;

    // Update is called once per frame
    void Update()
    {
        if(gameScore <= 0)
        {
            gameScore = 0;
        }

        gameScoreText.text = "" + gameScore;
    }

    public static void AddScore(int score)
    {
        gameScore = gameScore + score; 

    }

    public static void MinusScore(int score)
    {
        gameScore = gameScore - score;
    }

    public static void EndPoints(int time)
    {

    }
}
