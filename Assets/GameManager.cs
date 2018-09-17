using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    bool gameEnded = false;
    public float restartDelay = 3f;
    public GameObject completeLevelUI;
    public GameObject stopScoreCountUI;

    public void CompleteLevel()
    {
        Debug.Log("Level Complete");
        stopScoreCountUI.SetActive(false);
        completeLevelUI.SetActive(true);
    }

	public void EndGame()
    {
        if (gameEnded == false)
        {
            gameEnded = true;
            Debug.Log("GAME OVER!");
            Invoke("Restart", restartDelay);
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
