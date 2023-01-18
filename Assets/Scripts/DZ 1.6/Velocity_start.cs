using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Velocity_start : MonoBehaviour
{
    public Vector3 Velocity;
    public Rigidbody Rigidbody;

    void Start()
    {
        Rigidbody.velocity = Velocity;
    }
}
