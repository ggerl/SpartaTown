using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : Controller2D
{
    private Camera camera;
    private void Awake()
    {
        camera = Camera.main;
    }

    public void OnMove(InputValue value)
    {
        Vector2 moveInput = value.Get<Vector2>().normalized;
        CallMoveEvent(moveInput);
    }

    public void OnLook(InputValue value)
    {
        Vector2 newaim = value.Get<Vector2>();
        Vector2 worldPos = camera.ScreenToWorldPoint(newaim);
        newaim = (worldPos - (Vector2)transform.position).normalized;
        CallLookEvent(newaim); 
    }
}
