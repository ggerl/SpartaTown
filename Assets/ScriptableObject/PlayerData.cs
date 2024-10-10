using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "ScriptableObjects/PlayerData", order = 1)]
public class PlayerData : ScriptableObject
{
    public string Name;
    public Sprite characterSprite;
    public AnimatorOverrideController animatorController;

    public AnimationClip clip_Idle;
    public AnimationClip clip_Run;

}
