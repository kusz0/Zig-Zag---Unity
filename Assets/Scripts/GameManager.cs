using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool isGameStarted = false;
    
    public void StartGame()
    {
        isGameStarted = true;
    }
    private void Update()
    {
        if(Input.GetButtonDown("Jump"))
         {
            StartGame();
        }
    }
    
    


}
