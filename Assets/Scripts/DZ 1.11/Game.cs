using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    public Controls Controls;
    
    
    public enum State
    {
        Playing,
        Won,
        Lost,
    }
  
    public State CurrentState { get; private set; }

    public void OnPlayerStarted()
    {
        CurrentState = State.Playing;
        Controls.enabled = true;
        Gamemanager.Started = true;
        LostDissolving.IsDissolving = false;
        Debug.Log("Playing");
    }

    public void OnPlayerDied()
    {
        if (CurrentState != State.Playing) return;
        CurrentState = State.Lost;
        Controls.enabled = false;
        LostDissolving.IsDissolving = true;
        Gamemanager.Lost = true;
        
        Debug.Log("Game over");
    }

    public void OnPlayerReachedFinish()
    {
        if (CurrentState != State.Playing) return;

        CurrentState = State.Won;
        Controls.enabled = false;
        Gamemanager.Won = true;
        LostDissolving.IsDissolving = false;
        LevelIndex++;
        Debug.Log("You Won!");
    }

    public int LevelIndex 
    {
        get => PlayerPrefs.GetInt(LevelIndexKey, 0);
        private set 
        {
            PlayerPrefs.SetInt(LevelIndexKey, value);
            PlayerPrefs.Save();
        }
    }

    private const string LevelIndexKey = "LevelIndex";
}
