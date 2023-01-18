using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelPassed : MonoBehaviour
{
    public Text Text;
    public Game Game;

    private void Start()
    {
        Text.text = ("Level " + (Game.LevelIndex) + " Passed").ToString();
    }
}
