using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class UiManager : MonoBehaviour
{
    public TextMeshProUGUI playerScore;
    public TextMeshProUGUI bestScore;
    private GameManager gameManager;


    public void Awake()
    {
        gameManager = FindFirstObjectByType<GameManager>();
    }

    void Update()
    {
        playerScore.text = gameManager.score.ToString();
        bestScore.text = gameManager.GetHighScore().ToString();
    }
}
