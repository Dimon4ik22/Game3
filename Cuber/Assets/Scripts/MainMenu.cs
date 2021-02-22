using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public void PlayTutorial()
    {
        SceneManager.LoadScene(1);
    }
    public void PlayLevel1()
    {
        SceneManager.LoadScene(2);
    }
    public void PlayLevel2()
    {
        SceneManager.LoadScene(3);
    }
    public void PlayLevelE()
    {
        SceneManager.LoadScene(4);
    }
}
