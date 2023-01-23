using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score_text : MonoBehaviour
{
    void Start()
    {
        scoreText = this.GetComponent<Text>();
    }
    private Text scoreText;
    public static long score = 0;
    void Update()
    {
        scoreText.text = "分数" + score;
    }

    public static void addScore(int sco)
    {
        score += sco;
    }
    public static void deleteScore(int sco)
    {
        score -= sco;
    }
}
