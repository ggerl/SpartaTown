using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAinmController : MonoBehaviour
{
    private static readonly int IsWalking = Animator.StringToHash("IsWalking");
    private Animator animator;
    private PlayerInputController Plyaercontroller;
    private readonly float magnituteThreshold = 0.5f;

    private void Awake()
    {
        animator = GetComponentInChildren<Animator>();
        Plyaercontroller = GetComponent<PlayerInputController>();

    }
    private void Start()
    {
        Plyaercontroller.OnMoveEvent += Move;
    }

    private void Move(Vector2 obj)
    {
        animator.SetBool(IsWalking, obj.magnitude > magnituteThreshold);

    }

}
