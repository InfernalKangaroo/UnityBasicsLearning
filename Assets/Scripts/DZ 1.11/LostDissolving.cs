using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LostDissolving : MonoBehaviour
{
  
    public Material PlayMaterial;
    public Material DeathMaterial;
    public float DissolveAmount = 0;
    public float DissolveSpeed;
    public static bool IsDissolving;
    private void Awake()
    {
        IsDissolving = false;
        UpdateBallMaterial();
    }
    private void UpdateBallMaterial()
    {
        Renderer sectorRenderer = GetComponent<Renderer>();
        sectorRenderer.sharedMaterial = IsDissolving ? PlayMaterial : DeathMaterial;
    }
    private void Update()
    {
        if (IsDissolving) 
        {
           DissolveAmount += Time.deltaTime;
           DeathMaterial.SetFloat("_dissolveAmount", DissolveAmount);
        }
        else
        {
           DissolveAmount -=  Time.deltaTime;
           DeathMaterial.SetFloat("_dissolveAmount", DissolveAmount);
        }
        
    }
    private void OnValidate()
    {
        UpdateBallMaterial();
    }
}
