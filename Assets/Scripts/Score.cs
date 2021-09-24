using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    private TextMeshProUGUI scoreText = null;
    private int _score = 0;

    void Awake()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
    }
    void Update()
    {
        GetScore();
    }

    void GetScore()
    {
        _score = GameObject.FindWithTag("Player").GetComponent<PlatformController>()._score;
        scoreText.text = _score.ToString();
    }
}
