using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIScreens : MonoBehaviour
{

    public GameObject PauseScreen;
    public GameObject VictoryScreen;
    public GameObject LoseScreen;

    public void PauseOn()
    {
        Time.timeScale = 0f;
        PauseScreen.SetActive(true);
    }
    public void PauseOff()
    {
        Time.timeScale = 1f;
        PauseScreen.SetActive(false);
    }
    public void Win()
    {
        Time.timeScale = 0f;
        VictoryScreen.SetActive(true);
    }
    public void Lose()
    {
        Time.timeScale = 0f;
        LoseScreen.SetActive(true);
    }

    public void NextLvl()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void ReloadLvl()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
}