using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool isGameStarted = false;
    public int score = 0;

    public void StartGame()
    {
        isGameStarted = true;
    }
    public void EndGame()
    {
        SceneManager.LoadScene(0);
    }
    private void Update()
    {
        if(Input.GetButtonDown("Jump"))
         {
            StartGame();
        }
    }
    public void IncreaseScore()
    {
        score++;

        if (score > GetHighScore())
        {
            PlayerPrefs.SetInt("BestScore", score);
        }
    }
    
    public int GetHighScore()
    {
        int bestScore = PlayerPrefs.GetInt("BestScore");
        return bestScore;
    }


}
