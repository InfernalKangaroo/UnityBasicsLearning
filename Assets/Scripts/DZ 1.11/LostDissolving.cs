using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LostDissolving : MonoBehaviour
{
  
    public Material PlayMaterial;
    public Material DeathMaterial;
    public float DissolveAmount = -0.5f;
    public float DissolveSpeed;
    public static bool IsDissolving;
    private void Awake()
    {
        IsDissolving = false;
        UpdateBallMaterial();
        DeathMaterial.SetFloat("_dissolveAmount", DissolveAmount);
    }
    public void UpdateBallMaterial()
    {
        Renderer sectorRenderer = GetComponent<Renderer>();
        sectorRenderer.sharedMaterial = IsDissolving ? DeathMaterial : PlayMaterial;
    }
    private void Update()
    {
        if (IsDissolving) 
        {
           DissolveAmount += 0.1f * Time.deltaTime ;
           DeathMaterial.SetFloat("_dissolveAmount", DissolveAmount);
        }
        
        
    }
    private void OnValidate()
    {
        UpdateBallMaterial();
    }
}
