using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : Controller2D
{
    private Camera camera;
    [SerializeField] private TMP_Text text;
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private AnimatorOverrideController animatorOverrideController;
    private void Awake()
    {
        camera = Camera.main;

        DisplayPlayerName();
        PlayerSpriteChange();

        PlayerAnimChange("Player_Idle", GameManager.instance.playerData.clip_Idle);
        PlayerAnimChange("Player_Move", GameManager.instance.playerData.clip_Run);



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

    public void DisplayPlayerName()
    {
        text.text = GameManager.instance.PlayerName;
    }

    private void PlayerSpriteChange()
    {
        spriteRenderer.sprite = GameManager.instance.playerData.characterSprite;
    }

    public void PlayerAnimChange(string originalClipName, AnimationClip newClip)
    {
        animatorOverrideController[originalClipName] = newClip;

    }
}
