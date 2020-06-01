using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    public float slow;

    Vector3 offset;

    void Start()
    {
        offset = target.position - transform.position;
    }

    void FixedUpdate()
    {
        Vector3 velocity = Vector3.zero;
        transform.position = Vector3.SmoothDamp(transform.position, target.position - offset, ref velocity, Time.fixedDeltaTime * slow);
    }
}
