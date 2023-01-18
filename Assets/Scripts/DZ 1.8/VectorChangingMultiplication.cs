using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorChangingMultiplication : MonoBehaviour
{
    public Transform Object;
    public float Factor;

    void Update()
    {
        transform.position = Object.position * Factor;
    }
}
