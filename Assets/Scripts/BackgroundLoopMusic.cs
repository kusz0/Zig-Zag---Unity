using UnityEngine;

public class BackgroundLoopMusic : MonoBehaviour
{
    public static BackgroundLoopMusic instance;
    public void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }else if(instance != this)
        {
            Destroy(gameObject);
        }
            DontDestroyOnLoad(gameObject);
    }

}
