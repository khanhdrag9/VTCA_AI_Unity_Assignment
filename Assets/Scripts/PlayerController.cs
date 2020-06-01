using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    public float maxSpeed = 5f;


    PlayerInputHandler inputHandler;
    MovementSystem movementSystem;
    Animator animator;

    void Start()
    {
        inputHandler = GetComponent<PlayerInputHandler>();
        movementSystem = GetComponent<MovementSystem>();
        animator = GetComponentInChildren<Animator>();
    }

    void Update()
    {
        if(inputHandler.GetOnMoveClick(out Vector3 position))
        {
            movementSystem.MoveTo(position);
        }

        animator.SetFloat("speedMovement", movementSystem.DeltaSpeed);
    }

}
