
using UnityEngine;
using UnityEngine.SceneManagement; // changing or reload the scene

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 1f;// 1 second
    public void EndGame()
    {   
        if(!gameHasEnded)
        {
            gameHasEnded = true;
            Debug.Log("game over");
            // first param is func name, second is the delay time in second
            Invoke("Restart",restartDelay);
        }
    }

    void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);// this is current scene
    }
}
