using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Button[] buttons;
    public void PlayTutorial()
    {
        SceneManager.LoadScene(3);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
    public void PlayLevels(int count)
    {
        foreach (Button button in buttons)
        {
            if (button == buttons[count])
            {
                SceneManager.LoadScene(count);
                Debug.Log(count);
            }
        }
    }
}
