using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.DZ_1._11
{
    public class LevelNumberText : MonoBehaviour
    {
        public Text Text;
        public Game Game;

        private void Start()
        {
            Text.text =  (Game.LevelIndex + 1).ToString();   
        }
    }
}