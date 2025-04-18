using System;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Updated Values")]

    public TMP_Text scoreTxt;
    public float score;

    [Header("Game Over")]

    public bool isGameOver;
    public GameObject gameOver;

    [Header("Booleans")]

    public bool canIncrementScore = true;

    private void Start()
    {
        gameOver.SetActive(false);
        isGameOver = false;
    }

    private void Update()
    {
        if (canIncrementScore)
        {
            score += 0.05f;
            scoreTxt.text = $"SCORE: {score}";
        }

        if (isGameOver) 
        {
            canIncrementScore = false;
            gameOver.SetActive(true);
        }
    }
}