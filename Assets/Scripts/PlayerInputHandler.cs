using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerInputHandler : MonoBehaviour
{

    Camera cam;
    private void Start()
    {
        cam = Camera.main;
    }

    public bool GetOnMoveClick(out Vector3 position)
    {
        position = Vector3.zero;
        if (!CanInput()) return false;

        if(Input.GetMouseButtonDown(1))
        {
            Ray mouse = cam.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(mouse, out RaycastHit info))
            {
                position = info.point;
                return true;
            }
        }

        return false;
    }

    private bool CanInput()
    {
        return true;
    }
}
