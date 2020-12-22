using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager_script : MonoBehaviour
{
    bool gameEnd = false;

    public float restartDelay = 0.3f;

    public GameObject completeLevelUI;

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true); //sets the level complete text to true. Referencing is done in the Game Manager object in Unity
    }

    public void EndGame()
    {
        if(!gameEnd)
        {
            gameEnd = true;
            Invoke("Restart", restartDelay); //Invoke takes in two parameters, one is a function and the other is the delaytime to call that function

        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); //Through these methods the current scene is again reloaded
    }
   
}
