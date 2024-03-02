using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    [SerializeField] private float gameTime;
    [SerializeField] private Text timeText;


    private float timer;

    void Start()
    {
        timer = gameTime;
    }

    void Update()
    {
        timer -= Time.deltaTime;
        timeText.text = timer + " s";

        if (timer <= 0f)
        {
            EndGame();
        }
    }

    private void EndGame()
    {
        SceneManager.LoadScene("RatWin");
    }
}

