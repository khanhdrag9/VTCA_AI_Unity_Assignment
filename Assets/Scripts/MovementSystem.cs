using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class MovementSystem : MonoBehaviour
{
    NavMeshAgent navMeshAgent;

    public float DeltaSpeed => Mathf.Clamp(navMeshAgent.velocity.magnitude / navMeshAgent.speed, 0f, 1f);

    float originSpeed;
    bool wasSlowThisFrame = false;

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        originSpeed = navMeshAgent.speed;
    }

    public void MoveTo(Vector3 target)
    {
        navMeshAgent.SetDestination(target);
    }

    public void Slow(float value)
    {
        navMeshAgent.speed = Mathf.Clamp(navMeshAgent.speed, 0f, originSpeed * value);
        wasSlowThisFrame = true;
    }
    public void LateUpdate()
    {
        if (!wasSlowThisFrame)
            navMeshAgent.speed = originSpeed;

        wasSlowThisFrame = false;
    }
}
