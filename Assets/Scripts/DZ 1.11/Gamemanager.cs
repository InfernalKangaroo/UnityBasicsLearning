using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{
    public static bool Lost;
    public static bool Won;
    public static bool Pause;
    public static bool Started;
    public GameObject LoseScreen;
    public GameObject WinScreen;
    public GameObject PauseScreen;
    public GameObject GameScreen;
    public Game Game;
    void Start()
    {
        Time.timeScale = 1;
        Pause = true;
        Lost = Won = Started = false;
    }

    void Update()
    {
        if (Pause)
        {
            Time.timeScale = 0;
            PauseScreen.SetActive(true);

            if (Input.GetButtonDown("Fire1"))
            {
                Time.timeScale = 1;
                PauseScreen.SetActive(false);
                Pause = false;
                Started = true;
            }
        }

        if (Started)
        {
            Time.timeScale = 1;
            GameScreen.SetActive(true);
            PauseScreen.SetActive(false);
        }

        if (Lost) 
        {
            Time.timeScale = 1;
            LoseScreen.SetActive(true);
            
            if (Input.GetButtonDown("Fire1")) 
            {
                ReloadLevel();
            }
        }

        if (Won)
        {
            Time.timeScale = 1;
            WinScreen.SetActive(true);
            GameScreen.SetActive(false);

            if (Input.GetButtonDown("Fire1"))
            {
                ReloadLevel();
            }
        }

        
    }

    private void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }
}
