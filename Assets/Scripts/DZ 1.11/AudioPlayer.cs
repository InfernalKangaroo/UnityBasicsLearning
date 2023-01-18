using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    private AudioSource _audio;

    private void Awake()
    {
        _audio = GetComponent<AudioSource>();
    }
    private void OnEnable()
    {
        _audio.Play();
    }
    private void OnDisable()
    {
        _audio.Stop();
    }
}
