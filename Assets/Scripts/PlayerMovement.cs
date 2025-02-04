using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Controller2D movementcontroller2D;
    private Rigidbody2D Movementrb;
    [SerializeField]private SpriteRenderer CharacterRenderer;

    private Vector2 movementDirection = Vector2.zero;


    private void Awake()
    {
        movementcontroller2D = GetComponent<Controller2D>();
        Movementrb = GetComponent<Rigidbody2D>();   
    }

    private void Start()
    {
        movementcontroller2D.OnMoveEvent += Move;
        movementcontroller2D.OnLookEvent += IsFlipX;
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

    private void IsFlipX(Vector2 direction)
    {
        float rotz = Mathf.Atan2(direction.y , direction.x) * Mathf.Rad2Deg;
        CharacterRenderer.flipX = Mathf.Abs(rotz) > 90f;
    }

}


