using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorChangingDistance : MonoBehaviour
{
    public Transform Object1;
    public Transform Object2;

    void Update()
    {
        transform.position = new Vector3(0, Vector3.Distance(Object1.position, Object2.position), 0);
    }
}
