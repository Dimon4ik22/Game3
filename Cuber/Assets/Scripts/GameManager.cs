using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 1f;
    public GameObject endGameUI;
    public GameObject completeLevelUI;
    private void Start()
    {
        Time.timeScale = 1f;
    }
    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
        Time.timeScale = 0.1f;
    }
    //Рестарт после смерти
    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            endGameUI.SetActive(true);
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
