using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Controller2D movementcontroller2D;
    private Rigidbody2D Movementrb;

    private Vector2 movementDirection = Vector2.zero;


    private void Awake()
    {
        movementcontroller2D = GetComponent<Controller2D>();
        Movementrb = GetComponent<Rigidbody2D>();   
    }

    private void Start()
    {
        movementcontroller2D.OnMoveEvent += Move;
    }

    private void FixedUpdate()
    {
        ApplyMovemnet(movementDirection);
    }

    private void Move(Vector2 direction)
    {
        movementDirection = direction;
    }

    private void ApplyMovemnet(Vector2 direction)
    {
        direction = direction * 5;

        Movementrb.velocity = direction;
    }

}


