using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorChangingSubstraction : MonoBehaviour
{
    public Transform Object1;
    public Transform Object2;

    void Update()
    {
        transform.position = Object1.position - Object2.position;
    }
}
