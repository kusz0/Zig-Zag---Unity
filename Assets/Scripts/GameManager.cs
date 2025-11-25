using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool isGameStarted = false;
    
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
    
    


}
