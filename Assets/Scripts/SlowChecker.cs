using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MovementSystem))]
public class SlowChecker : MonoBehaviour
{
    public float distance = 2f;
    public string objectName;
    public float slowValue;


    MovementSystem movementSystem;

    private void Start()
    {
        movementSystem = GetComponent<MovementSystem>();
    }

    void Update()
    {
        if (Physics.Raycast(transform.position, Vector3.down, out RaycastHit info, 2f))
        {
            if (info.collider.tag.Equals(objectName))
                movementSystem.Slow(slowValue);
        }
    }
}
