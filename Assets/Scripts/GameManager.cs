using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;

    public static GameManager Instance => instance ?? (instance = FindObjectOfType<GameManager>());

    [SerializeField] private TMP_Text scoreText;
    private int score;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void IncreaseScore(int increase)
    {
        score += increase;
        scoreText.text = score.ToString();
    }

    public void GameOver()
    {
        SceneManager.LoadScene(0);
    }
}
