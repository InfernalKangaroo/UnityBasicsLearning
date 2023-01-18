using Assets.Scripts.DZ_1._11;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float BounceSpeed;
    public Rigidbody Rigidbody;
    public Game Game;
    public LostDissolving LostDissolving;
    public AudioClip AudioClip;
    public ParticleSystem _jumpSpot;
    public ParticleSystem _death;
    private AudioSource _audioClip;

    public Platform CurrentPlatform;

    private void Awake()
    {
        _audioClip = GetComponent<AudioSource>();
        
     
    }
    public void ReachFinish()
    {
        Game.OnPlayerReachedFinish();
        Rigidbody.velocity = Vector3.zero;
        
    }

    public void Bounce()
    {
        Rigidbody.velocity = new Vector3(0, BounceSpeed, 0);
        _audioClip.Play();
        _jumpSpot.Play();
    }
    
    public  void Die()
    {
        Game.OnPlayerDied();
        LostDissolving.UpdateBallMaterial();
        Rigidbody.velocity = Vector3.zero;
        _death.gameObject.SetActive(true);
        _death.Play();
    }
}
